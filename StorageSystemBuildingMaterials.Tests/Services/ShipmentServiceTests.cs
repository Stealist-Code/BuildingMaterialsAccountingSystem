using Microsoft.EntityFrameworkCore;
using Moq;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Tests.Services
{
    public class ShipmentServiceTests : TestBase
    {
        private readonly Mock<IShipmentValidation> _mockValidation;
        private readonly ShipmentService _shipmentService;

        public ShipmentServiceTests()
        {
            _mockValidation = new Mock<IShipmentValidation>();
            _shipmentService = new ShipmentService(DbContext, _mockValidation.Object);
        }

        [Fact]
        public async Task CreateShipment_ValidData_CreatesShipment()
        {
            // Arrange
            var user = CreateTestUser();

            var category = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Категория"
            };

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Товар",
                Article = "ART-1",
                Unit = "шт",
                CategoryId = category.Id,
                CurrentStock = 10
            };

            var address = new Address
            {
                Id = Guid.NewGuid(),
                Country = "Россия",
                Region = "Татарстан",
                City = "Казань",
                Street = "Пушкина",
                Building = "1"
            };

            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                TIN = "1234567890",
                FirstName = "Иван",
                LastName = "Петров",
                MiddleName = "Сергеевич",
                AddressId = address.Id,
                Address = address,
                Email = "ivan@example.com"
            };

            var stateRule = new StateRule
            {
                Id = Guid.NewGuid(),
                DaysBeforeDiscount = 0,
                Discount = 0
            };

            var productState = new ProductState
            {
                Id = Guid.NewGuid(),
                StateRuleId = stateRule.Id,
                StateRule = stateRule
            };

            var supplyItem = new SupplyItem
            {
                Id = Guid.NewGuid(),
                ProductId = product.Id,
                Product = product,
                Quantity = 10,
                CurrentStock = 10,
                PurchasePrice = 50m,
                PurchasePriceOnDayPurchace = 50m,
                ReceivedDate = DateTime.UtcNow.AddDays(-1),
                ExpirationDate = DateTime.UtcNow.AddDays(30),
                ProductStateId = productState.Id,
                ProductState = productState
            };

            DbContext.Users.Add(user);
            DbContext.Categories.Add(category);
            DbContext.Products.Add(product);
            DbContext.Addresses.Add(address);
            DbContext.Customers.Add(customer);
            DbContext.StateRules.Add(stateRule);
            DbContext.ProductStates.Add(productState);
            DbContext.SupplyItems.Add(supplyItem);
            await DbContext.SaveChangesAsync();

            var items = new List<ShipmentItem>
            {
                new ShipmentItem
                {
                    ProductId = product.Id,
                    Quantity = 3
                }
            };

            _mockValidation
                .Setup(x => x.ValidateCreateShipment(address, items))
                .Verifiable();

            // Act
            var shipment = await _shipmentService.CreateShipment(
                user.Id,
                address.Id,
                customer.Id,
                items,
                300m);

            // Assert
            Assert.NotNull(shipment);
            Assert.Equal(customer.Id, shipment.CustomerId);
            Assert.Equal(address.Id, shipment.AddressId);
            Assert.Equal(300m, shipment.PriceForSell);

            var savedShipment = await DbContext.Shipments
                .Include(x => x.ShipmentItems)
                .FirstOrDefaultAsync(x => x.Id == shipment.Id);

            Assert.NotNull(savedShipment);
            Assert.Single(savedShipment.ShipmentItems);

            var changedSupply = await DbContext.SupplyItems.FindAsync(supplyItem.Id);

            Assert.NotNull(changedSupply);
            Assert.Equal(7, changedSupply.CurrentStock);

            _mockValidation.Verify(x => x.ValidateCreateShipment(address, items), Times.Once);
        }

        [Fact]
        public async Task CreateShipment_CustomerNotFound_ThrowsException()
        {
            // Arrange
            var user = CreateTestUser();

            var address = new Address
            {
                Id = Guid.NewGuid(),
                Country = "Россия",
                Region = "Татарстан",
                City = "Казань",
                Street = "Пушкина",
                Building = "1"
            };

            DbContext.Users.Add(user);
            DbContext.Addresses.Add(address);
            await DbContext.SaveChangesAsync();

            var items = new List<ShipmentItem>
            {
                new ShipmentItem
                {
                    ProductId = Guid.NewGuid(),
                    Quantity = 1
                }
            };

            _mockValidation
                .Setup(x => x.ValidateCreateShipment(address, items))
                .Verifiable();

            // Act & Assert
            var ex = await Assert.ThrowsAnyAsync<Exception>(() =>
                _shipmentService.CreateShipment(
                    user.Id,
                    address.Id,
                    Guid.NewGuid(),
                    items,
                    100m));

            Assert.Equal("CustomerIsNull", ex.Message);
            _mockValidation.Verify(x => x.ValidateCreateShipment(address, items), Times.Once);
        }

        [Fact]
        public async Task CreateShipment_ProductWithoutSupply_ThrowsException()
        {
            // Arrange
            var user = CreateTestUser();

            var category = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Категория"
            };

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Товар",
                Article = "ART-1",
                Unit = "шт",
                CategoryId = category.Id,
                CurrentStock = 10
            };

            var address = new Address
            {
                Id = Guid.NewGuid(),
                Country = "Россия",
                Region = "Татарстан",
                City = "Казань",
                Street = "Пушкина",
                Building = "1"
            };

            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                TIN = "1234567890",
                FirstName = "Иван",
                LastName = "Петров",
                MiddleName = "Сергеевич",
                AddressId = address.Id,
                Address = address,
                Email = "ivan@example.com"
            };

            DbContext.Users.Add(user);
            DbContext.Categories.Add(category);
            DbContext.Products.Add(product);
            DbContext.Addresses.Add(address);
            DbContext.Customers.Add(customer);
            await DbContext.SaveChangesAsync();

            var items = new List<ShipmentItem>
            {
                new ShipmentItem
                {
                    ProductId = product.Id,
                    Quantity = 1
                }
            };

            _mockValidation
                .Setup(x => x.ValidateCreateShipment(address, items))
                .Verifiable();

            // Act & Assert
            var ex = await Assert.ThrowsAnyAsync<Exception>(() =>
                _shipmentService.CreateShipment(
                    user.Id,
                    address.Id,
                    customer.Id,
                    items,
                    100m));

            Assert.Equal("ProductNotFound", ex.Message);
        }

        [Fact]
        public async Task CreateShipment_NotEnoughProduct_ThrowsException()
        {
            // Arrange
            var user = CreateTestUser();

            var category = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Категория"
            };

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Товар",
                Article = "ART-1",
                Unit = "шт",
                CategoryId = category.Id,
                CurrentStock = 2
            };

            var address = new Address
            {
                Id = Guid.NewGuid(),
                Country = "Россия",
                Region = "Татарстан",
                City = "Казань",
                Street = "Пушкина",
                Building = "1"
            };

            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                TIN = "1234567890",
                FirstName = "Иван",
                LastName = "Петров",
                MiddleName = "Сергеевич",
                AddressId = address.Id,
                Address = address,
                Email = "ivan@example.com"
            };

            var stateRule = new StateRule
            {
                Id = Guid.NewGuid(),
                DaysBeforeDiscount = 0,
                Discount = 0
            };

            var productState = new ProductState
            {
                Id = Guid.NewGuid(),
                StateRuleId = stateRule.Id,
                StateRule = stateRule
            };

            var supplyItem = new SupplyItem
            {
                Id = Guid.NewGuid(),
                ProductId = product.Id,
                Product = product,
                Quantity = 2,
                CurrentStock = 2,
                PurchasePrice = 50m,
                PurchasePriceOnDayPurchace = 50m,
                ReceivedDate = DateTime.UtcNow.AddDays(-1),
                ExpirationDate = DateTime.UtcNow.AddDays(30),
                ProductStateId = productState.Id,
                ProductState = productState
            };

            DbContext.Users.Add(user);
            DbContext.Categories.Add(category);
            DbContext.Products.Add(product);
            DbContext.Addresses.Add(address);
            DbContext.Customers.Add(customer);
            DbContext.StateRules.Add(stateRule);
            DbContext.ProductStates.Add(productState);
            DbContext.SupplyItems.Add(supplyItem);
            await DbContext.SaveChangesAsync();

            var items = new List<ShipmentItem>
            {
                new ShipmentItem
                {
                    ProductId = product.Id,
                    Quantity = 5
                }
            };

            _mockValidation
                .Setup(x => x.ValidateCreateShipment(address, items))
                .Verifiable();

            // Act & Assert
            var ex = await Assert.ThrowsAnyAsync<Exception>(() =>
                _shipmentService.CreateShipment(
                    user.Id,
                    address.Id,
                    customer.Id,
                    items,
                    500m));

            Assert.Equal("InsufficientProduct", ex.Message);
        }

        [Fact]
        public async Task GetAllShipments_ReturnsShipmentWithCustomerAndAddress()
        {
            // Arrange
            var user = CreateTestUser();

            var category = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Категория"
            };

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Товар",
                Article = "ART-1",
                Unit = "шт",
                CategoryId = category.Id,
                CurrentStock = 10
            };

            var address = new Address
            {
                Id = Guid.NewGuid(),
                Country = "Россия",
                Region = "Татарстан",
                City = "Казань",
                Street = "Пушкина",
                Building = "1"
            };

            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                TIN = "1234567890",
                FirstName = "Иван",
                LastName = "Петров",
                MiddleName = "Сергеевич",
                AddressId = address.Id,
                Address = address,
                Email = "ivan@example.com"
            };

            var shipment = new Shipment
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                User = user,
                CustomerId = customer.Id,
                Customer = customer,
                AddressId = address.Id,
                Address = address,
                ShipmentDate = DateTime.UtcNow,
                PriceForSell = 300m,
                ShipmentItems = new List<ShipmentItem>
                {
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        ProductId = product.Id,
                        Product = product,
                        Quantity = 3,
                        TotalPurchasePrice = 150m
                    }
                }
            };

            DbContext.Users.Add(user);
            DbContext.Categories.Add(category);
            DbContext.Products.Add(product);
            DbContext.Addresses.Add(address);
            DbContext.Customers.Add(customer);
            DbContext.Shipments.Add(shipment);
            await DbContext.SaveChangesAsync();

            // Act
            var result = await _shipmentService.GetAllShipments();

            // Assert
            Assert.Single(result);
            Assert.Equal(customer.Email, result[0].CustomerEmail);
            Assert.Equal(300m, result[0].TotalPrice);
            Assert.Single(result[0].Items);
            Assert.Equal("Товар", result[0].Items[0].ProductName);
        }

        private User CreateTestUser()
        {
            var role = DbContext.Roles.First();

            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Тест",
                LastName = "Пользователь",
                MiddleName = "Тестович",
                Email = Guid.NewGuid() + "@test.com",
                PasswordHash = "hash",
                RoleId = role.Id,
                Role = role,
                IsActive = true
            };

            return user;
        }
    }
}