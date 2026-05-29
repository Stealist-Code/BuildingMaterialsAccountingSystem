namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с поставками
    /// </summary>
    public class SupplyService : ISupplyService
    {
        private readonly AppDbContext _db;
        private readonly IProductValidation _productValidation;
        private readonly ICurrencyService _currencyService;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public SupplyService(AppDbContext db, IProductValidation productValidation, ICurrencyService currencyService)
        {
            _db = db;
            _productValidation = productValidation;
            _currencyService = currencyService;
        }

        /// <summary>
        /// Пересчитывает актуальную цену (на сегодняшний день) для списка поставок
        /// по текущему курсу валюты закупки
        /// </summary>
        private async Task CalculateCurrentPrices(List<SupplyItem> supplyItems)
        {
            var currencies = supplyItems
                .Where(x => x.Currency != "RUB" && x.ExchangeRateOnDayPurchace > 0)
                .Select(x => x.Currency)
                .Distinct()
                .ToList();

            var todayRates = new Dictionary<string, decimal>();

            foreach (var currency in currencies)
            {
                try
                {
                    todayRates[currency] = await _currencyService.GetRate(currency);
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, $"Не удалось получить курс для валюты {currency}");
                }
            }

            foreach (var item in supplyItems)
            {
                if (item.Currency == "RUB" || item.ExchangeRateOnDayPurchace == 0)
                {
                    item.PurchasePrice = item.PurchasePriceOnDayPurchace;
                }
                else if (todayRates.TryGetValue(item.Currency, out var todayRate))
                {
                    item.PurchasePrice = Math.Round(item.PurchasePriceOnDayPurchace * (todayRate / item.ExchangeRateOnDayPurchace), 2);
                }
                else
                {
                    item.PurchasePrice = item.PurchasePriceOnDayPurchace;
                }
            }
        }

        /// <summary>
        /// Получить список товаров для отображения
        /// </summary>
        /// <returns>Список товаров</returns>
        public async Task<List<ProductDto>> GetProducts()
        {
            try
            {
                var supplyItems = await _db.SupplyItems
                    .AsNoTracking()
                    .Include(x => x.Product)
                        .ThenInclude(x => x.Category)
                    .Include(x => x.ProductState)
                        .ThenInclude(x => x.StateRule)
                    .ToListAsync();

                await CalculateCurrentPrices(supplyItems);
                await DiscountHelper.ApplyDiscount(_db, supplyItems);

                return supplyItems
                    .Select(x => new ProductDto
                    {
                        Id = x.Product.Id,
                        Article = x.Product.Article,
                        Name = x.Product.Name,
                        CategoryName = x.Product.Category.Name,
                        CategoryId = x.Product.CategoryId,
                        Unit = x.Product.Unit,
                        PurchasePrice = x.PurchasePrice,
                        CurrentStock = x.Quantity,
                        ExpirationDate = x.ExpirationDate,
                        ReceivedDate = x.ReceivedDate,
                        DaysLeft = (x.ExpirationDate - DateTime.UtcNow).Days,
                    })
                    .OrderBy(x => x.Name)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка получения списка товаров");
                throw;
            }
        }

        /// <summary>
        /// Получить непросроченные товары
        /// </summary>
        /// <returns>Список товаров</returns>
        public async Task<List<ProductDto>> GetActualProducts()
        {
            var today = DateTime.UtcNow.Date;

            var supplyItems = await _db.SupplyItems
                    .AsNoTracking()
                    .Where(x => x.ExpirationDate.Date > today && x.CurrentStock > 0)
                    .Include(x => x.Product)
                        .ThenInclude(x => x.Category)
                    .Include(x => x.ProductState)
                        .ThenInclude(x => x.StateRule)
                    .ToListAsync();

            await CalculateCurrentPrices(supplyItems);
            await DiscountHelper.ApplyDiscount(_db, supplyItems);

            return supplyItems
                    .Select(x => new ProductDto
                    {
                        Id = x.Product.Id,
                        Article = x.Product.Article,
                        Name = x.Product.Name,
                        CategoryName = x.Product.Category.Name,
                        CategoryId = x.Product.CategoryId,
                        Unit = x.Product.Unit,
                        PurchasePrice = x.PurchasePrice,
                        CurrentStock = x.CurrentStock,
                        ExpirationDate = x.ExpirationDate,
                        ReceivedDate = x.ReceivedDate,
                        DaysLeft = (x.ExpirationDate - DateTime.UtcNow).Days,
                    })
                    .OrderBy(x => x.Name)
                    .ToList();
        }

        /// <summary>
        /// Получить просроченные товары
        /// </summary>
        /// <returns>Список товаров</returns>
        public async Task<List<ProductDto>> GetExpiredProducts()
        {
            var today = DateTime.UtcNow.Date;

            var supplyItems = await _db.SupplyItems
                    .AsNoTracking()
                    .Where(x => x.ExpirationDate.Date <= today || x.CurrentStock <= 0)
                    .Include(x => x.Product)
                        .ThenInclude(x => x.Category)
                    .Include(x => x.ProductState)
                        .ThenInclude(x => x.StateRule)
                    .ToListAsync();

            await CalculateCurrentPrices(supplyItems);
            await DiscountHelper.ApplyDiscount(_db, supplyItems);

            return supplyItems
                    .Select(x => new ProductDto
                    {
                        Id = x.Product.Id,
                        Article = x.Product.Article,
                        Name = x.Product.Name,
                        CategoryName = x.Product.Category.Name,
                        CategoryId = x.Product.CategoryId,
                        Unit = x.Product.Unit,
                        PurchasePrice = x.PurchasePrice,
                        CurrentStock = x.CurrentStock,
                        ExpirationDate = x.ExpirationDate,
                        ReceivedDate = x.ReceivedDate,
                        DaysLeft = (x.ExpirationDate - today).Days,
                    })
                    .OrderBy(x => x.Name)
                    .ToList();
        }

        /// <summary>
        /// Поиск товаров по названию/артикулу/названию категории (или сразу все вместе)
        /// </summary>
        /// <param name="articleStr">Артикул в строковом формате (будет преобразован в число).</param>
        /// <param name="name">Название товара (точное совпадение).</param>
        /// <param name="categoryId">ID категории.</param>
        /// <returns>Список товаров</returns>
        public async Task<List<ProductDto>> SearchProductsAdvanced(string articleStr, string name, Guid? categoryId)
        {
            try
            {
                var supply = _db.SupplyItems.AsNoTracking().AsQueryable();

                if (!string.IsNullOrWhiteSpace(articleStr) && long.TryParse(articleStr, out long articleNum))
                {
                    supply = supply.Where(x => x.Product.Article.ToLower() == $"art-" + articleNum);
                }

                if (!string.IsNullOrWhiteSpace(name))
                {
                    supply = supply.Where(x => x.Product.Name.ToLower() == name.ToLower());
                }

                if (categoryId.HasValue)
                {
                    supply = supply.Where(x => x.Product.CategoryId == categoryId.Value);
                }

                var supplyItems = await supply
                    .Include(x => x.Product)
                        .ThenInclude(x => x.Category)
                    .Include(x => x.ProductState)
                        .ThenInclude(x => x.StateRule)
                    .ToListAsync();

                await CalculateCurrentPrices(supplyItems);
                await DiscountHelper.ApplyDiscount(_db, supplyItems);

                var now = DateTime.UtcNow;

                return supplyItems
                    .Select(x => new ProductDto
                    {
                        Id = x.Product.Id,
                        Article = x.Product.Article,
                        Name = x.Product.Name,
                        CategoryName = x.Product.Category.Name,
                        ExpirationDate = x.ExpirationDate,
                        DaysLeft = (x.ExpirationDate - now).Days,
                        Unit = x.Product.Unit,
                        PurchasePrice = x.PurchasePrice,
                        CurrentStock = x.CurrentStock
                    })
                    .OrderBy(x => x.Name)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка поиска товаров");
                throw;
            }
        }
    }
}
