namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с товарами. Логика с БД, связанная с товарами!!!
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly AppDbContext _db;
        private readonly IProductValidation _productValidation;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="db">бд</param>
        /// <param name="productValidation">валидации товаров</param>
        public ProductService(AppDbContext db, IProductValidation productValidation)
        {
            _db = db;
            _productValidation = productValidation;
        }

        /// <summary>
        /// Получить товары по категории
        /// </summary>
        /// <param name="categoryId">Id категории</param>
        /// <returns>Товары с указанным категорией</returns>
        public async Task<List<ProductDto>> GetProducts(Guid categoryId)
        {
            try
            {
                return await _db.Products
                    .AsNoTracking()
                    .Where(x => x.CategoryId == categoryId)
                    .Select(x => new ProductDto
                    {
                        Id = x.Id,
                        Article = x.Article,
                        Name = x.Name,
                        CategoryName = x.Category.Name,
                        Unit = x.Unit,
                        CurrentStock = x.CurrentStock,
                    })
                    .OrderBy(x => x.Name)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка получения товаров по категории {categoryId}");
                throw;
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
                return await _db.Products
                    .AsNoTracking()
                    .Select(x => new ProductDto
                    {
                        Id = x.Id,
                        Article = x.Article,
                        Name = x.Name,
                        CategoryName = x.Category.Name,
                        CategoryId = x.CategoryId,
                        Unit = x.Unit,
                        CurrentStock = x.CurrentStock,
                        Insurance = x.Insurance,
                        ThermalContainer = x.ThermalContainer,
                    })
                    .OrderBy(x => x.Name)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка получения списка товаров");
                throw;
            }
        }

        /// <summary>
        /// Поиск товаров по названию/артикулу/названию категории (или сразу все вместе)
        /// </summary>
        /// <param name="article">Артикль</param>
        /// <param name="name">Название</param>
        /// <param name="categoryId">Id категории</param>
        /// <returns>Список товаров</returns>
        public async Task<List<ProductDto>> SearchProductsAdvanced(string articleStr, string name, Guid? categoryId)
        {
            try
            {
                var query = _db.Products.AsNoTracking().AsQueryable();

                if (!string.IsNullOrWhiteSpace(articleStr) && long.TryParse(articleStr, out long articleNum))
                {
                    query = query.Where(x => x.Article.ToLower() == $"art-" + articleNum);
                }

                if (!string.IsNullOrWhiteSpace(name))
                {
                    query = query.Where(x => x.Name.ToLower() == name.ToLower());
                }

                if (categoryId.HasValue)
                {
                    query = query.Where(x => x.CategoryId == categoryId.Value);
                }

                var now = DateTime.UtcNow;

                return await query
                    .Select(x => new ProductDto
                    {
                        Id = x.Id,
                        Article = x.Article,
                        Name = x.Name,

                        CategoryName = x.Category.Name,
                        Unit = x.Unit,
                        CurrentStock = x.CurrentStock
                    })
                    .OrderBy(x => x.Name)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка поиска товаров");
                throw;
            }
        }

        /// <summary>
        /// Создать товар
        /// </summary>
        /// <param name="product">Объект товара</param>
        public async Task CreateProduct(Product product)
        {
            _logger.Info($"Добавление нового товара: {product?.Name}");

            try
            {
                _productValidation.Validate(product);

                _logger.Debug("Проверка уникальности артикула");

                if (await _db.Products.AnyAsync(x => x.Article == product.Article))
                {
                    _logger.Info("Артикул уже существует");
                    throw new Exception("ProductWithSimilarArticle");
                }

                product.Id = Guid.NewGuid();
                product.Article = await GenerateArticle();
                await _db.Products.AddAsync(product);
                await _db.SaveChangesAsync();

                _logger.Info($"Товар создан id={product.Id}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка добавления товара");
                throw;
            }
        }

        /// <summary>
        /// Обновить данные товара
        /// </summary>
        /// <param name="updated">Объект товара</param>
        /// <exception cref="Exception">Ошибка обновления товара</exception>
        public async Task UpdateProduct(Guid id, Product updated)
        {
            _logger.Info($"Редактирование товара id={id}");
            try
            {
                _productValidation.Validate(updated);

                var existing = await _db.Products.FindAsync(id);

                if (existing is null)
                {
                    throw new Exception("ProductNotFound");
                }

                _logger.Debug("Проверка уникальности артикула");

                if (existing.Article != updated.Article && await _db.Products.AnyAsync(p => p.Article == updated.Article && p.Id != id))
                {
                    _logger.Info("Артикул уже существует");
                    throw new Exception("ProductWithSimilarArticle");
                }

                existing.Name = updated.Name;
                existing.CategoryId = updated.CategoryId;
                existing.Unit = updated.Unit;
                existing.CurrentStock = updated.CurrentStock;

                await _db.SaveChangesAsync();

                _logger.Info($"Товар обновлён id={id}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка обновления товара id={id}");
                throw;
            }
        }

        /// <summary>
        /// Удалить товар
        /// </summary>
        /// <param name="id">Id товара</param>
        /// <exception cref="Exception">Ошибка удаления товара</exception>
        public async Task DeleteProduct(Guid id)
        {
            try
            {
                var product = await _db.Products.FirstOrDefaultAsync(p => p.Id == id);

                if (product is null)
                {
                    return;
                }

                bool usedInShipment = await _db.ShipmentItems.AnyAsync(si => si.ProductId == id);

                if (usedInShipment)
                {
                    throw new Exception("ProductCannotDeletedInShippment");
                }

                _db.Products.Remove(product);
                await _db.SaveChangesAsync();

                _logger.Info($"Товар удалён id={id}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка удаления товара id={id}");
                throw;
            }
        }

        private async Task<string> GenerateArticle()
        {
            int count = await _db.Products.CountAsync() + 1;
            return $"ART-{count}";
        }

        /// <summary>
        /// Получить непросроченные товары 
        /// </summary>
        /// <returns>Список товаров</returns>
        public async Task<List<ProductDto>> GetActualProducts()
        {
            var today = DateTime.UtcNow.Date;

            var supplies = await _db.SupplyItems
                .Include(x => x.Product)
                .Where(x => x.ExpirationDate.Date > today && x.CurrentStock > 0)
                .ToListAsync();

            var suppliesDict = supplies
                .GroupBy(x => x.ProductId)
                .ToDictionary(
                    y => y.Key,
                    y => y.Sum(x => x.CurrentStock)
                );

            var products = await _db.Products
                .Include(x => x.Category)
                .ToListAsync();

            var result = products
                .Select(x => new ProductDto
                {
                    Id = x.Id,
                    Article = x.Article,
                    Name = x.Name,
                    CategoryName = x.Category.Name,
                    CategoryId = x.Category.Id,
                    Unit = x.Unit,
                    CurrentStock = suppliesDict.ContainsKey(x.Id) ? suppliesDict[x.Id] : 0
                }).OrderBy(x => x.Article).ToList();

            return result;
        }

        /// <summary>
        /// Получить просроченные товары
        /// </summary>
        /// <returns>Список товаров</returns>
        public async Task<List<ProductDto>> GetExpiredProducts()
        {
            var today = DateTime.UtcNow.Date;

            var supplies = await _db.SupplyItems
                .Include(x => x.Product)
                    .ThenInclude(p => p.Category)
                .Where(x => x.ExpirationDate < today)
                .ToListAsync();

            var result = supplies
                .GroupBy(x => x.Product)
                .Select(g =>
                {
                    var maxExpiration = g.Max(x => x.ExpirationDate);

                    return new ProductDto
                    {
                        Id = g.Key.Id,
                        Article = g.Key.Article,
                        Name = g.Key.Name,
                        CategoryName = g.Key.Category.Name,
                        CategoryId = g.Key.CategoryId,
                        Unit = g.Key.Unit,

                        CurrentStock = g.Sum(x => x.Quantity),

                        ExpirationDate = maxExpiration,
                        ReceivedDate = g.Max(x => x.ReceivedDate),

                        DaysLeft = (maxExpiration.Date - today).Days
                    };
                })
                .ToList();

            return result;
        }
    }
}