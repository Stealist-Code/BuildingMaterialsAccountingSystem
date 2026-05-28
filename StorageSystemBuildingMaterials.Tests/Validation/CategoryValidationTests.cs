using StorageSystemBuildingMaterials.Validation;

namespace StorageSystemBuildingMaterials.Tests.Validation
{
    public class CategoryValidationTests
    {
        private readonly CategoryValidation _validator = new CategoryValidation();

        [Fact]
        public void Validate_ValidName_DoesNotThrow()
        {
            // Arrange
            string name = "Электроника";

            // Act
            var exception = Record.Exception(() => _validator.Validate(name));

            // Assert
            Assert.Null(exception);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Validate_EmptyOrWhitespaceName_ThrowsException(string name)
        {
            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.Validate(name));
            Assert.Equal("EmptyCategoryName", ex.Message);
        }
    }
}