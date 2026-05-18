using Microsoft.EntityFrameworkCore;
using NLog;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.HelperClasses;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Validation.Interfaces;
using System;

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

        public ShipmentService(AppDbContext db, IShipmentValidation shipmentValidation)
        {
            _db = db;
            _shipmentValidation = shipmentValidation;
        }

        /// <summary>
        /// Возвращает все отгрузки с пользователями и позициями
        /// </summary>
        /// <returns></returns>
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
        /// <param name="userId"></param>
        /// <param name="destination"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
                    .Where(x => productIds.Contains(x.ProductId))
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
                    var supplyItemProducts = supply.Where(x => x.ProductId == item.ProductId);

                    if (!supplyItemProducts.Any())
                    {
                        throw new Exception("ProductNotFound");
                    }

                    var product = products.FirstOrDefault(x => x.Id == item.ProductId);

                    if (product is null || product is not null && product.CurrentStock < item.Quantity)
                    {
                        throw new Exception("InsufficientProduct");
                    }

                    foreach (var supplyItemProduct in supplyItemProducts)
                    {
                        supplyItemProduct.Product = products
                            .FirstOrDefault(x => x.Id == supplyItemProduct.ProductId && x.CurrentStock > 0);

                        item.Id = (item.Id == Guid.Empty) ? Guid.NewGuid() : item.Id;
                        item.ShipmentId = shipment.Id;

                        _logger.Info($"Товар зарезервирован: {supplyItemProduct.Product.Name}, количество: {item.Quantity}");

                        decimal totalPurchasePrice = 0;

                        foreach (var supplyItem in supply)
                        {
                            if (supplyItem.CurrentStock <= item.Quantity)
                            {
                                item.Quantity -= supplyItem.CurrentStock;
                                totalPurchasePrice += supplyItem.CurrentStock * supplyItem.PurchasePrice;
                                supplyItem.CurrentStock = 0;
                            }
                            else
                            {
                                supplyItem.CurrentStock -= item.Quantity;
                                totalPurchasePrice += item.Quantity * supplyItem.PurchasePrice;
                                item.Quantity = 0;
                            }
                        }

                        item.TotalPurchasePrice = totalPurchasePrice;

                        _logger.Info($"Остаток товара уменьшен: {supplyItemProduct.Product.Name}");
                    }
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
        /// Создать поставку
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="address"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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