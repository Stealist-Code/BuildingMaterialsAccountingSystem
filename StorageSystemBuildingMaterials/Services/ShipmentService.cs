namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с отгрузками. Логика с БД, связанная с отгрузками!!!
    /// </summary>
    public class ShipmentService : IShipmentService
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private AppDbContext _db;
        private IShipmentValidation _shipmentValidation;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="db">бд</param>
        /// <param name="shipmentValidation">валидация отгрузок</param>
        public ShipmentService(AppDbContext db, IShipmentValidation shipmentValidation)
        {
            _db = db;
            _shipmentValidation = shipmentValidation;
        }

        /// <summary>
        /// Возвращает все отгрузки с пользователями и позициями
        /// </summary>
        /// <returns>Список отгрузок</returns>
        public async Task<List<ShipmentDto>> GetAllShipments()
        {
            _logger.Debug("Загрузка списка отгрузок");

            return await _db.Shipments
                .Include(x => x.User)
                .Include(x => x.Customer)
                .Include(x => x.Address)
                .Include(x => x.ShipmentItems)
                    .ThenInclude(x => x.Product)
                .OrderByDescending(x => x.ShipmentDate)
                .Select(x => new ShipmentDto
                {
                    Id = x.Id,
                    UserEmail = x.User.Email,
                    Address = x.Address.FullAddress,
                    CustomerName = x.Customer.FullName,
                    CustomerEmail = x.Customer.Email,
                    ShipmentDate = x.ShipmentDate,

                    TotalPrice = x.PriceForSell,

                    Items = x.ShipmentItems.Select(i => new ShipmentItemDto
                    {
                        ProductName = i.Product.Name,
                        Quantity = i.Quantity
                    }).ToList()
                }).ToListAsync();
        }

        /// <summary>
        /// Создаёт новую отгрузку, списывая товары со склада
        /// </summary>
        /// <param name="userId">ID пользователя, создающего отгрузку.</param>
        /// <param name="addressId">ID адреса доставки.</param>
        /// <param name="customerId">ID покупателя.</param>
        /// <param name="items">Список товаров в отгрузке.</param>
        /// <param name="totalPrice">Общая цена продажи.</param>
        /// <returns>Созданная отгрузка.</returns>
        /// <exception cref="Exception">Ошибки валидации, недостаток товара или отсутствие данных.</exception>
        public async Task<Shipment> CreateShipment(Guid userId, Guid addressId, Guid customerId, List<ShipmentItem> items, decimal totalPrice)
        {
            _logger.Info($"Создание отгрузки userId={userId}");

            try
            {
                _logger.Debug("Валидация полей формы");

                var customer = await _db.Customers.FindAsync(customerId);
                var address = await _db.Addresses.FindAsync(addressId);

                _shipmentValidation.ValidateCreateShipment(address, items);

                if (customer is null)
                {
                    throw new Exception("CustomerIsNull");
                }

                var productIds = items.Select(x => x.ProductId).ToList();

                _logger.Debug("Проверка наличия товара");

                var supply = await _db.SupplyItems
                    .Where(x => productIds.Contains(x.ProductId)
                        && x.ExpirationDate > DateTime.UtcNow
                        && x.CurrentStock > 0)
                    .OrderBy(x => x.ExpirationDate)
                    .ToListAsync();

                await DiscountHelper.ApplyDiscount(_db, supply);

                var existingAddress = await _db.Addresses.FindAsync(address.Id);
                if (existingAddress is null)
                {
                    throw new Exception("AddressNotFound");
                }

                var products = await _db.Products.ToListAsync();

                var shipment = new Shipment
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    CustomerId = customer.Id,
                    Customer = customer,
                    ShipmentDate = DateTime.UtcNow,
                    AddressId = existingAddress.Id,
                    Address = existingAddress,
                    ShipmentItems = items,
                    PriceForSell = totalPrice
                };

                foreach (var item in items)
                {
                    var supplyItemProducts = supply
                        .Where(x => x.ProductId == item.ProductId)
                        .ToList();

                    if (!supplyItemProducts.Any())
                    {
                        throw new Exception("ProductNotFound");
                    }

                    var product = products.FirstOrDefault(x => x.Id == item.ProductId);

                    if (product is null || product is not null && product.CurrentStock < item.Quantity)
                    {
                        throw new Exception("InsufficientProduct");
                    }

                    item.Id = (item.Id == Guid.Empty) ? Guid.NewGuid() : item.Id;
                    item.ShipmentId = shipment.Id;

                    decimal totalPurchasePrice = 0;
                    var remainingQuantity = item.Quantity;

                    foreach (var supplyItem in supplyItemProducts)
                    {
                        if (remainingQuantity <= 0)
                        {
                            break;
                        }    

                        supplyItem.Product = product;

                        _logger.Info($"Товар зарезервирован: {supplyItem.Product.Name}, количество: {item.Quantity}");

                        if (supplyItem.CurrentStock <= remainingQuantity)
                        {
                            remainingQuantity -= supplyItem.CurrentStock;
                            totalPurchasePrice += supplyItem.CurrentStock * supplyItem.PurchasePriceOnDayPurchace;
                            supplyItem.CurrentStock = 0;
                        }
                        else
                        {
                            supplyItem.CurrentStock -= remainingQuantity;
                            totalPurchasePrice += remainingQuantity * supplyItem.PurchasePriceOnDayPurchace;
                            remainingQuantity = 0;
                        }

                        _logger.Info($"Остаток товара уменьшен: {supplyItem.Product.Name}");
                    }

                    item.TotalPurchasePrice += totalPurchasePrice;
                }

                await _db.Shipments.AddAsync(shipment);
                await _db.SaveChangesAsync();

                _logger.Info($"Отгрузка создана id={shipment.Id}");

                return shipment;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка при создании отгрузки userId={userId}");
                throw new Exception(ex.InnerException?.Message ?? ex.Message);
            }
        }

        /// <summary>
        /// Метод для получения закупочной цены
        /// </summary>
        /// <param name="items"></param>
        /// <returns>Закупочная цена</returns>
        /// <exception cref="Exception">Ошибки валидации</exception>
        public async Task<decimal> GetPurshacePrice(List<ShipmentItem> items)
        {
            var productIds = items.Select(x => x.ProductId).ToList();

            _logger.Debug("Проверка наличия товара");

            var supply = await _db.SupplyItems
                .Where(x => productIds.Contains(x.ProductId)
                    && x.ExpirationDate > DateTime.UtcNow
                    && x.CurrentStock > 0)
                .OrderBy(x => x.ExpirationDate)
                .ToListAsync();

            var products = await _db.Products.ToListAsync();

            decimal totalPurshace = 0;

            foreach (var item in items)
            {
                var supplyItemProducts = supply
                    .Where(x => x.ProductId == item.ProductId)
                    .ToList();

                if (!supplyItemProducts.Any())
                {
                    throw new Exception("ProductNotFound");
                }

                var product = products.FirstOrDefault(x => x.Id == item.ProductId);

                if (product is null || product is not null && product.CurrentStock < item.Quantity)
                {
                    throw new Exception("InsufficientProduct");
                }

                var remainingQuantity = item.Quantity;
                decimal itemPurchasePrice = 0;

                foreach (var supplyItem in supplyItemProducts)
                {
                    if (remainingQuantity <= 0)
                    {
                        break;
                    }

                    if (supplyItem.CurrentStock <= remainingQuantity)
                    {
                        remainingQuantity -= supplyItem.CurrentStock;
                        itemPurchasePrice += supplyItem.CurrentStock * supplyItem.PurchasePriceOnDayPurchace;
                    }
                    else
                    {
                        itemPurchasePrice += remainingQuantity * supplyItem.PurchasePriceOnDayPurchace;
                        remainingQuantity = 0;
                    }
                }

                totalPurshace += itemPurchasePrice;
            }
            return totalPurshace;
        }

        /// <summary>
        /// Создаёт поставку (приход товара) и увеличивает остатки на складе.
        /// </summary>
        /// <param name="userId">ID пользователя, создающего поставку.</param>
        /// <param name="address">Адрес поставки.</param>
        /// <param name="items">Список поставляемых товаров.</param>
        /// <exception cref="Exception">Если товар не найден в базе.</exception>
        public async Task CreateSupply(Guid userId, Address address, List<SupplyItem> items)
        {
            var shipment = new Shipment
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                ShipmentDate = DateTime.UtcNow,
                Address = address,
                IsSupply = true,
                PriceForSell = 0,
                CustomerId = null
            };

            foreach (var item in items)
            {
                var product = await _db.Products.FindAsync(item.ProductId);

                if (product is null)
                {
                    throw new Exception("ProductNotFound");
                }

                await _db.SupplyItems.AddAsync(item);

                product.CurrentStock += item.Quantity;
            }

            await _db.Shipments.AddAsync(shipment);
            await _db.SaveChangesAsync();
        }
    }
}