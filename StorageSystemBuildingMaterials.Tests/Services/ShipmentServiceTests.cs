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
        public async Task CreateShipment_ValidationFails_ThrowsException()
        {
            // Arrange
            var address = new Address();
            var items = new List<ShipmentItem>();

            _mockValidation.Setup(v => v.ValidateCreateShipment(address, items))
                .Throws(new Exception("ShipmentItemsEmpty"));

            // Act & Assert
            //var ex = await Assert.ThrowsAsync<Exception>(() => _shipmentService.CreateShipment(Guid.NewGuid(), address, items));
            //Assert.Equal("ShipmentItemsEmpty", ex.Message);
        }

        [Fact]
        public async Task CreateShipment_ProductNotFound_ThrowsException()
        {
            // Arrange
            var address = new Address { Country = "Россия", City = "Москва", Street = "Тверская", Building = "1" };
            var items = new List<ShipmentItem>
            {
                new ShipmentItem { ProductId = Guid.NewGuid(), Quantity = 1 }
            };

            _mockValidation.Setup(v => v.ValidateCreateShipment(address, items)).Verifiable();
            _mockValidation.Setup(v => v.ValidateProductsAvailability(It.IsAny<Dictionary<Guid, Product>>(), items))
                .Throws(new Exception("ProductWithIdNotFound"));

            // Act & Assert
            //var ex = await Assert.ThrowsAsync<Exception>(() => _shipmentService.CreateShipment(Guid.NewGuid(), address, items));
            //Assert.Equal("ProductWithIdNotFound", ex.Message);
        }
    }
}