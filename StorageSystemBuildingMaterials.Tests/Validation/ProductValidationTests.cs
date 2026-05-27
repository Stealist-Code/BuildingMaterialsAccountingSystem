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
                Unit = "кг",
                CurrentStock = 10
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.Validate(product));
            Assert.Equal("ProductNameRequired", ex.Message);
        }

        [Fact]
        public void Validate_EmptyCategoryId_ThrowsException()
        {
            // Arrange
            var product = new Product
            {
                Name = "Товар без категории",
                CategoryId = Guid.Empty,
                Unit = "шт",
                CurrentStock = 100
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.Validate(product));
            Assert.Equal("CategoryRequired", ex.Message);
        }
    }
}