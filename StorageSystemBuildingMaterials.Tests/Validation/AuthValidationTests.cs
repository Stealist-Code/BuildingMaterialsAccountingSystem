using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Validation;

namespace StorageSystemBuildingMaterials.Tests.Validation
{
    public class AuthValidationTests
    {
        private readonly AuthValidation _validator = new AuthValidation();

        #region IsValidEmail Tests

        [Theory]
        [InlineData("test@example.com", true)]
        [InlineData("user.name+tag@domain.co.uk", true)]
        [InlineData("invalid-email", false)]
        [InlineData("", false)]
        [InlineData("   ", false)]
        [InlineData(null, false)]
        [InlineData("missing@domain", false)]
        [InlineData("@domain.com", false)]
        [InlineData("user@.com", false)]
        public void IsValidEmail_VariousInputs_ReturnsExpected(string email, bool expected)
        {
            // Act
            var result = _validator.IsValidEmail(email);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion

        #region ValidateRegisterRequest Tests

        [Fact]
        public void ValidateRegisterRequest_AllFieldsValid_DoesNotThrow()
        {
            // Arrange
            var request = new RegisterRequest
            {
                FirstName = "Иван",
                LastName = "Петров",
                Email = "ivan@example.com",
                Password = "StrongPass1!",
                ConfirmPassword = "StrongPass1!"
            };

            // Act
            var exception = Record.Exception(() => _validator.ValidateRegisterRequest(request));

            // Assert
            Assert.Null(exception);
        }

        [Theory]
        [InlineData("", "Петров", "ivan@example.com", "Pass1!", "FillFieldsForRegister")]
        [InlineData("Иван", "", "ivan@example.com", "Pass1!", "FillFieldsForRegister")]
        [InlineData("Иван", "Петров", "", "Pass1!", "FillFieldsForRegister")]
        [InlineData("Иван", "Петров", "ivan@example.com", "", "FillFieldsForRegister")]
        public void ValidateRegisterRequest_EmptyRequiredFields_ThrowsException(
            string firstName, string lastName, string email, string password, string expectedMessage)
        {
            // Arrange
            var request = new RegisterRequest
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                ConfirmPassword = password
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateRegisterRequest(request));
            Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void ValidateRegisterRequest_InvalidEmail_ThrowsException()
        {
            // Arrange
            var request = new RegisterRequest
            {
                FirstName = "Иван",
                LastName = "Петров",
                Email = "invalid-email",
                Password = "StrongPass1!",
                ConfirmPassword = "StrongPass1!"
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateRegisterRequest(request));
            Assert.Equal("InvalidEmail", ex.Message);
        }

        [Fact]
        public void ValidateRegisterRequest_WeakPassword_ThrowsException()
        {
            // Arrange
            var request = new RegisterRequest
            {
                FirstName = "Иван",
                LastName = "Петров",
                Email = "ivan@example.com",
                Password = "weak",
                ConfirmPassword = "weak"
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateRegisterRequest(request));
            Assert.Equal("PasswordMustCompleteConditions", ex.Message);
        }

        [Fact]
        public void ValidateRegisterRequest_PasswordsDoNotMatch_ThrowsException()
        {
            // Arrange
            var request = new RegisterRequest
            {
                FirstName = "Иван",
                LastName = "Петров",
                Email = "ivan@example.com",
                Password = "StrongPass1!",
                ConfirmPassword = "DifferentPass1!"
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateRegisterRequest(request));
            Assert.Equal("PasswordsDoNotMatch", ex.Message);
        }

        #endregion

        #region ValidateLogin Tests

        [Fact]
        public void ValidateLogin_ValidCredentials_DoesNotThrow()
        {
            // Arrange
            var request = new AuthenticateRequest
            {
                Email = "user@example.com",
                Password = "anypassword"
            };

            // Act
            var exception = Record.Exception(() => _validator.ValidateLogin(request));

            // Assert
            Assert.Null(exception);
        }

        [Theory]
        [InlineData("", "pass", "FillFieldsForAuth")]
        [InlineData("user@example.com", "", "FillFieldsForAuth")]
        public void ValidateLogin_EmptyFields_ThrowsException(string email, string password, string expectedMessage)
        {
            // Arrange
            var request = new AuthenticateRequest { Email = email, Password = password };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateLogin(request));
            Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void ValidateLogin_InvalidEmail_ThrowsException()
        {
            // Arrange
            var request = new AuthenticateRequest
            {
                Email = "not-an-email",
                Password = "password"
            };

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _validator.ValidateLogin(request));
            Assert.Equal("InvalidEmail", ex.Message);
        }

        #endregion

        #region ValidatePassword Tests

        [Theory]
        [InlineData("Short1!", false)]          // меньше 8 символов
        [InlineData("NoDigit!", false)]          // нет цифры
        [InlineData("nodigit1", false)]          // нет спецсимвола
        [InlineData("NOLOWER1!", false)]         // нет строчных букв
        [InlineData("noupper1!", false)]         // нет заглавных букв
        [InlineData("ValidPass1!", true)]        // всё есть
        [InlineData("C0mpl3x!P@ssw0rd", true)]   // всё есть
        [InlineData("", false)]
        [InlineData(null, false)]
        public void ValidatePassword_VariousInputs_ReturnsExpected(string password, bool expected)
        {
            // Act
            var result = _validator.ValidatePassword(password);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion
    }
}