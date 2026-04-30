using Microsoft.EntityFrameworkCore;
using NLog;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.DTO;
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
        public async Task<Shipment> CreateShipment(Guid userId, Address address, Customer customer, List<ShipmentItem> items, decimal totalPrice)
        {
            _logger.Info($"Создание отгрузки userId={userId}");

            try
            {
                _logger.Debug("Валидация полей формы");

                _shipmentValidation.ValidateCreateShipment(address, items);

                if (customer is null)
                {
                    throw new Exception("CustomerIsNull");
                }

                address.Id = address.Id == Guid.Empty ? Guid.NewGuid() : address.Id;

                var productIds = items.Select(x => x.ProductId).ToList();

                _logger.Debug("Проверка наличия товара");

                var products = await _db.Products
                    .Where(x => productIds.Contains(x.Id))
                    .ToListAsync();

                var productDict = products.ToDictionary(x => x.Id);

                _shipmentValidation.ValidateProductsAvailability(productDict, items);

                var minPrice = items.Sum(i => productDict[i.ProductId].PurchasePrice * i.Quantity);

                if (totalPrice < minPrice)
                {
                    throw new Exception("PriceBelowCost");
                }

                var existingCustomer = await _db.Customers.FirstOrDefaultAsync(x => x.Email == customer.Email);

                if (existingCustomer is null)
                {
                    customer.Id = Guid.NewGuid();
                    await _db.Customers.AddAsync(customer);
                    existingCustomer = customer;
                }

                await _db.Addresses.AddAsync(address);

                var shipment = new Shipment
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    CustomerId = existingCustomer.Id,
                    Customer = existingCustomer,
                    ShipmentDate = DateTime.UtcNow,
                    Address = address,
                    AddressId = address.Id,
                    ShipmentItems = items,
                    PriceForSell = totalPrice
                };

                foreach (var item in items)
                {
                    if (!productDict.TryGetValue(item.ProductId, out var product))
                    {
                        throw new Exception("ProductNotFound");
                    }

                    item.Id = item.Id == Guid.Empty ? Guid.NewGuid() : item.Id;
                    item.ShipmentId = shipment.Id;

                    _logger.Info($"Товар зарезервирован: {product.Name}, количество: {item.Quantity}");

                    product.CurrentStock -= item.Quantity;

                    _logger.Info($"Остаток товара уменьшен: {product.Name}");
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