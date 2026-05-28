using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Validation;

namespace StorageSystemBuildingMaterials.Tests.Validation
{
    public class ShipmentValidationTests
    {
        private readonly ShipmentValidation _validator = new ShipmentValidation();

        #region ValidateCreateShipment Tests

        [Fact]
        public void ValidateCreateShipment_ValidData_DoesNotThrow()
        {
            // Arrange
            var address = new Address();
            var items = new List<ShipmentItem> { new ShipmentItem() };

            // Act
            var exception = Record.Exception(() => _validator.ValidateCreateShipment(address, items));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void ValidateCreateShipment_NullAddress_ThrowsException()
        {
            // Arrange
            Address address = null;
            var items = new List<ShipmentItem> { new ShipmentItem() };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateCreateShipment(address, items));
            Assert.Equal("AddressIsRequired", ex.Message);
        }

        [Fact]
        public void ValidateCreateShipment_NullItems_ThrowsException()
        {
            // Arrange
            var address = new Address();
            List<ShipmentItem> items = null;

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateCreateShipment(address, items));
            Assert.Equal("ShipmentItemsEmpty", ex.Message);
        }

        [Fact]
        public void ValidateCreateShipment_EmptyItems_ThrowsException()
        {
            // Arrange
            var address = new Address();
            var items = new List<ShipmentItem>();

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateCreateShipment(address, items));
            Assert.Equal("ShipmentItemsEmpty", ex.Message);
        }

        #endregion

        #region ValidateProductsAvailability Tests

        [Fact]
        public void ValidateProductsAvailability_EnoughStock_DoesNotThrow()
        {
            // Arrange
            var productId = Guid.NewGuid();
            var productDict = new Dictionary<Guid, Product>
            {
                { productId, new Product { Id = productId, CurrentStock = 10 } }
            };
            var items = new List<ShipmentItem>
            {
                new ShipmentItem { ProductId = productId, Quantity = 5 }
            };

            // Act
            var exception = Record.Exception(() => _validator.ValidateProductsAvailability(productDict, items));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void ValidateProductsAvailability_ProductNotFound_ThrowsException()
        {
            // Arrange
            var productDict = new Dictionary<Guid, Product>();
            var items = new List<ShipmentItem>
            {
                new ShipmentItem { ProductId = Guid.NewGuid(), Quantity = 1 }
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateProductsAvailability(productDict, items));
            Assert.Equal("ProductWithIdNotFound", ex.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void ValidateProductsAvailability_InvalidQuantity_ThrowsException(int quantity)
        {
            // Arrange
            var productId = Guid.NewGuid();
            var productDict = new Dictionary<Guid, Product>
            {
                { productId, new Product { Id = productId, CurrentStock = 10 } }
            };
            var items = new List<ShipmentItem>
            {
                new ShipmentItem { ProductId = productId, Quantity = quantity }
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateProductsAvailability(productDict, items));
            Assert.Equal("InvalidQuantity", ex.Message);
        }

        [Fact]
        public void ValidateProductsAvailability_NotEnoughStock_ThrowsException()
        {
            // Arrange
            var productId = Guid.NewGuid();
            var productDict = new Dictionary<Guid, Product>
            {
                { productId, new Product { Id = productId, CurrentStock = 3 } }
            };
            var items = new List<ShipmentItem>
            {
                new ShipmentItem { ProductId = productId, Quantity = 5 }
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateProductsAvailability(productDict, items));
            Assert.Equal("QuantityOfProductNotEnough", ex.Message);
        }

        #endregion

        #region ValidateShipmentFields Tests

        [Fact]
        public void ValidateShipmentFields_ValidData_DoesNotThrow()
        {
            // Arrange
            var address = new Address
            {
                Country = "Россия",
                City = "Москва",
                Street = "Тверская",
                Building = "1"
            };
            var cart = new List<CartItemDto> { new CartItemDto() };

            // Act
            var exception = Record.Exception(() => _validator.ValidateShipmentFields(address, cart));

            // Assert
            Assert.Null(exception);
        }

        [Theory]
        [InlineData("", "Москва", "Тверская", "1")]
        [InlineData("Россия", "", "Тверская", "1")]
        [InlineData("Россия", "Москва", "", "1")]
        [InlineData("Россия", "Москва", "Тверская", "")]
        public void ValidateShipmentFields_MissingAddressField_ThrowsException(
            string country, string city, string street, string building)
        {
            // Arrange
            var address = new Address
            {
                Country = country,
                City = city,
                Street = street,
                Building = building
            };
            var cart = new List<CartItemDto> { new CartItemDto() };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateShipmentFields(address, cart));
            Assert.Equal("RequiredFields", ex.Message);
        }

        [Fact]
        public void ValidateShipmentFields_NullCart_ThrowsException()
        {
            // Arrange
            var address = new Address
            {
                Country = "Россия",
                City = "Москва",
                Street = "Тверская",
                Building = "1"
            };
            List<CartItemDto> cart = null;

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateShipmentFields(address, cart));
            Assert.Equal("NoProducts", ex.Message);
        }

        [Fact]
        public void ValidateShipmentFields_EmptyCart_ThrowsException()
        {
            // Arrange
            var address = new Address
            {
                Country = "Россия",
                City = "Москва",
                Street = "Тверская",
                Building = "1"
            };
            var cart = new List<CartItemDto>();

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateShipmentFields(address, cart));
            Assert.Equal("NoProducts", ex.Message);
        }

        #endregion

        #region ValidateAddToCart Tests

        [Fact]
        public void ValidateAddToCart_ValidData_DoesNotThrow()
        {
            // Arrange
            var product = new ProductDto { Id = Guid.NewGuid(), Name = "Товар", CurrentStock = 20 };
            int quantity = 5;
            CartItemDto existing = null;

            // Act
            var exception = Record.Exception(() => _validator.ValidateAddToCart(product, quantity, existing));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void ValidateAddToCart_AddToExisting_DoesNotThrow()
        {
            // Arrange
            var product = new ProductDto { Id = Guid.NewGuid(), CurrentStock = 20 };
            int quantity = 5;
            var existing = new CartItemDto { ProductId = product.Id, Quantity = 3, Stock = 20 };

            // Act
            var exception = Record.Exception(() => _validator.ValidateAddToCart(product, quantity, existing));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void ValidateAddToCart_NullProduct_ThrowsException()
        {
            // Arrange
            ProductDto product = null;
            int quantity = 1;

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateAddToCart(product, quantity, null));
            Assert.Equal("ProductNotFound", ex.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void ValidateAddToCart_InvalidQuantity_ThrowsException(int quantity)
        {
            // Arrange
            var product = new ProductDto { CurrentStock = 10 };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateAddToCart(product, quantity, null));
            Assert.Equal("QuantityZero", ex.Message);
        }

        [Fact]
        public void ValidateAddToCart_QuantityExceedsStock_ThrowsException()
        {
            // Arrange
            var product = new ProductDto { CurrentStock = 5 };
            int quantity = 6;

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateAddToCart(product, quantity, null));
            Assert.Equal("NotEnoughStock", ex.Message);
        }

        [Fact]
        public void ValidateAddToCart_TotalExceedsStock_ThrowsException()
        {
            // Arrange
            var product = new ProductDto { CurrentStock = 10 };
            int quantity = 4;
            var existing = new CartItemDto { Quantity = 7 };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateAddToCart(product, quantity, existing));
            Assert.Equal("TotalExceedsStock", ex.Message);
        }

        #endregion
    }
}