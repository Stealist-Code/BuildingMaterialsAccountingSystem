using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services;

namespace StorageSystemBuildingMaterials.Tests.Services
{
    public class UserServiceTests : TestBase
    {
        private readonly UserService _userService;

        public UserServiceTests()
        {
            _userService = new UserService(DbContext);
        }

        [Fact]
        public async Task GetAllUsers_ReturnsUsersWithRoles()
        {
            // Arrange
            var role = new Role { Id = Guid.NewGuid(), Title = "Worker" };
            DbContext.Roles.Add(role);
            DbContext.Users.Add(new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Петров",
                MiddleName = "Сергеевич",
                Email = "ivan@example.com",
                PasswordHash = "hash",
                RoleId = role.Id,
                IsActive = true
            });
            await DbContext.SaveChangesAsync();

            // Act
            var result = await _userService.GetAllUsers();

            // Assert
            Assert.Single(result);
            var user = result[0];
            Assert.Equal("Иван", user.FirstName);
            Assert.Equal("Worker", user.Role.Title);
        }

        [Fact]
        public async Task GetAllUsers_EmptyDatabase_ReturnsEmptyList()
        {
            // Act
            var result = await _userService.GetAllUsers();

            // Assert
            Assert.Empty(result);
        }
    }
}