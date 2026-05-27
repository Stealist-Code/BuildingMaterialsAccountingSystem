using System.Reflection;
using System.Runtime.Serialization;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services;

namespace StorageSystemBuildingMaterials.Tests.Services
{
    public class TINServiceTests : TestBase
    {
        private readonly TINService _tinService;

        public TINServiceTests()
        {
            _tinService = CreateTINServiceWithoutConstructor(DbContext);
        }

        [Fact]
        public async Task FindCustomerWithTIN_ExistingCustomer_ReturnsCustomer()
        {
            // Arrange
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
                TIN = "7704407589",
                FirstName = "Иван",
                LastName = "Петров",
                MiddleName = "Сергеевич",
                AddressId = address.Id,
                Address = address,
                Email = "ivan@example.com"
            };

            DbContext.Addresses.Add(address);
            DbContext.Customers.Add(customer);
            await DbContext.SaveChangesAsync();

            // Act
            var result = await _tinService.FindCustomerWithTIN("7704407589");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(customer.Id, result.Id);
            Assert.Equal("7704407589", result.TIN);
            Assert.NotNull(result.Address);
            Assert.Equal("Казань", result.Address.City);
        }

        [Fact]
        public async Task FindCustomerWithTIN_NotExistingCustomer_ReturnsNull()
        {
            // Act
            var result = await _tinService.FindCustomerWithTIN("1234567890");

            // Assert
            Assert.Null(result);
        }

        private TINService CreateTINServiceWithoutConstructor(AppDbContext db)
        {
            var service = (TINService)FormatterServices.GetUninitializedObject(typeof(TINService));

            var dbField = typeof(TINService).GetField("_db", BindingFlags.Instance | BindingFlags.NonPublic);

            dbField.SetValue(service, db);

            return service;
        }
    }
}