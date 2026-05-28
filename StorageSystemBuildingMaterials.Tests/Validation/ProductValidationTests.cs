using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Validation;

namespace StorageSystemBuildingMaterials.Tests.Validation
{
    public class ProductValidationTests
    {
        private readonly ProductValidation _validator = new ProductValidation();

        [Fact]
        public void Validate_ValidProduct_DoesNotThrow()
        {
            // Arrange
            var product = new Product
            {
                Name = "Гвозди 100мм",
                CategoryId = Guid.NewGuid(),
                PurchasePrice = 150.50m,
                Unit = "кг",
                CurrentStock = 1000
            };

            // Act
            var exception = Record.Exception(() => _validator.Validate(product));

            // Assert
            Assert.Null(exception);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Validate_EmptyName_ThrowsException(string name)
        {
            // Arrange
            var product = new Product
            {
                Name = name,
                CategoryId = Guid.NewGuid(),
                PurchasePrice = 10m
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.Validate(product));
            Assert.Equal("ProductNameRequired", ex.Message);
        }

        [Fact]
        public void Validate_NegativePurchasePrice_ThrowsException()
        {
            // Arrange
            var product = new Product
            {
                Name = "Товар",
                CategoryId = Guid.NewGuid(),
                PurchasePrice = -5m
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.Validate(product));
            Assert.Equal("InvalidPrice", ex.Message);
        }

        [Fact]
        public void Validate_ZeroPurchasePrice_Valid()
        {
            // Arrange
            var product = new Product
            {
                Name = "Бесплатный образец",
                CategoryId = Guid.NewGuid(),
                PurchasePrice = 0m
            };

            // Act
            var exception = Record.Exception(() => _validator.Validate(product));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void Validate_EmptyCategoryId_ThrowsException()
        {
            // Arrange
            var product = new Product
            {
                Name = "Товар без категории",
                CategoryId = Guid.Empty,
                PurchasePrice = 100m
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.Validate(product));
            Assert.Equal("CategoryRequired", ex.Message);
        }
    }
}