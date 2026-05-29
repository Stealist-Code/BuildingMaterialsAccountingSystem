namespace StorageSystemBuildingMaterials.Tests.Services
{
    public class TINValidationTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData("124AWFW124")]
        [InlineData("123")]
        [InlineData("123456789")]
        [InlineData("12345678901")]
        [InlineData("770 4407589")]
        public void CheckTIN_InvalidTIN_ReturnsMessage(string tin)
        {
            // Act
            var message = GetTINValidationMessage(tin);

            // Assert
            Assert.Equal("Указан неправильный ИНН.", message);
        }

        [Fact]
        public void CheckTIN_SpaceInStart_ReturnsEmptyMessage()
        {
            // Arrange
            var tin = " 7704407589";

            // Act
            var message = GetTINValidationMessage(tin);

            // Assert
            Assert.Equal(string.Empty, message);
        }

        [Fact]
        public void CheckTIN_SpaceInEnd_ReturnsEmptyMessage()
        {
            // Arrange
            var tin = "7704407589 ";

            // Act
            var message = GetTINValidationMessage(tin);

            // Assert
            Assert.Equal(string.Empty, message);
        }

        [Fact]
        public void CheckTIN_SpacesInStartAndEnd_ReturnsEmptyMessage()
        {
            // Arrange
            var tin = " 7704407589 ";

            // Act
            var message = GetTINValidationMessage(tin);

            // Assert
            Assert.Equal(string.Empty, message);
        }

        [Theory]
        [InlineData("7704407589")]
        [InlineData("1234567890")]
        public void CheckTIN_ValidTIN_ReturnsEmptyMessage(string tin)
        {
            // Act
            var message = GetTINValidationMessage(tin);

            // Assert
            Assert.Equal(string.Empty, message);
        }

        private string GetTINValidationMessage(string tin)
        {
            if (string.IsNullOrWhiteSpace(tin))
            {
                return "Указан неправильный ИНН.";
            }

            tin = tin.Trim();

            if (tin.Length != 10 || !tin.All(char.IsDigit))
            {
                return "Указан неправильный ИНН.";
            }

            return string.Empty;
        }
    }
}