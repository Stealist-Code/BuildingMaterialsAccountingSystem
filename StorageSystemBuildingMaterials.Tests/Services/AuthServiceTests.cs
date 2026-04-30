using Microsoft.EntityFrameworkCore;
using Moq;
using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.HelperClasses.Interfaces;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Tests.Services
{
    public class AuthServiceTests : TestBase
    {
        private readonly Mock<IAuthValidation> _mockAuthValidation;
        private readonly Mock<IHashService> _mockHashService;
        private readonly AuthService _authService;

        public AuthServiceTests()
        {
            _mockAuthValidation = new Mock<IAuthValidation>();
            _mockHashService = new Mock<IHashService>();
            _authService = new AuthService(DbContext, _mockAuthValidation.Object, _mockHashService.Object);
        }

        [Fact]
        public async Task Register_EmailAlreadyExists_ThrowsException()
        {
            // Arrange
            var existingUser = new User
            {
                Id = Guid.NewGuid(),
                Email = "existing@example.com",
                PasswordHash = "hash",
                FirstName = "Existing",
                MiddleName = "Test",
                LastName = "User",
                RoleId = DbContext.Roles.First(r => r.Title == "Worker").Id,
                IsActive = true
            };
            DbContext.Users.Add(existingUser);
            await DbContext.SaveChangesAsync();

            var request = new RegisterRequest
            {
                Email = "existing@example.com",
                Password = "Pass123!",
                ConfirmPassword = "Pass123!",
                FirstName = "New",
                LastName = "User"
            };

            _mockAuthValidation.Setup(v => v.ValidateRegisterRequest(request)).Verifiable();
            _mockHashService.Setup(h => h.GetHash(It.IsAny<string>())).Returns("hash");

            // Act & Assert
            var ex = await Assert.ThrowsAsync<Exception>(() => _authService.Register(request));
            Assert.Equal("EmailExists", ex.Message);
        }

        [Fact]
        public async Task Register_RoleWorkerNotFound_ThrowsException()
        {
            // Arrange
            // Удаляем все роли, чтобы вызвать ошибку
            DbContext.Roles.RemoveRange(DbContext.Roles);
            await DbContext.SaveChangesAsync();

            var request = new RegisterRequest
            {
                FirstName = "Test",
                LastName = "User",
                Email = "test@example.com",
                Password = "Pass123!",
                ConfirmPassword = "Pass123!"
            };

            _mockAuthValidation.Setup(v => v.ValidateRegisterRequest(request)).Verifiable();
            _mockHashService.Setup(h => h.GetHash(It.IsAny<string>())).Returns("hash");

            // Act & Assert
            var ex = await Assert.ThrowsAsync<Exception>(() => _authService.Register(request));
            Assert.Equal("RoleNotFound", ex.Message);
        }

        [Fact]
        public async Task Authenticate_ValidCredentials_ReturnsUser()
        {
            // Arrange
            var password = "correctPassword";
            var hashed = "hashedCorrect";
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = "test@example.com",
                PasswordHash = hashed,
                FirstName = "Test",
                MiddleName = "Test",
                LastName = "User",
                RoleId = DbContext.Roles.First().Id,
                IsActive = true
            };
            DbContext.Users.Add(user);
            await DbContext.SaveChangesAsync();

            _mockHashService.Setup(h => h.VerifyPassword(password, hashed)).Returns(true);

            var authRequest = new AuthenticateRequest { Email = "test@example.com", Password = password };

            // Act
            var result = await _authService.Authenticate(authRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(user.Id, result.Id);
            Assert.Equal(user.Email, result.Email);
        }

        [Fact]
        public async Task Authenticate_UserNotFound_ReturnsNull()
        {
            // Arrange
            var authRequest = new AuthenticateRequest { Email = "nonexistent@example.com", Password = "pass" };

            // Act
            var result = await _authService.Authenticate(authRequest);

            // Assert
            Assert.Null(result);
        }
    }
}