using Microsoft.EntityFrameworkCore;
using Moq;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Tests.Services
{
    public class CategoryServiceTests : TestBase
    {
        private readonly Mock<ICategoryValidation> _mockValidation;
        private readonly CategoryService _categoryService;

        public CategoryServiceTests()
        {
            _mockValidation = new Mock<ICategoryValidation>();
            _categoryService = new CategoryService(DbContext, _mockValidation.Object);
        }

        [Fact]
        public async Task GetAllCategories_ReturnsOrderedList()
        {
            // Arrange
            DbContext.Categories.Add(new Category { Name = "Z_Category" });
            DbContext.Categories.Add(new Category { Name = "A_Category" });
            await DbContext.SaveChangesAsync();

            // Act
            var result = await _categoryService.GetAllCategories();

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("A_Category", result[0].Name);
            Assert.Equal("Z_Category", result[1].Name);
        }

        [Fact]
        public async Task AddCategory_ValidName_CreatesCategory()
        {
            // Arrange
            var categoryName = "Electronics";
            _mockValidation.Setup(v => v.Validate(categoryName)).Verifiable();

            // Act
            await _categoryService.AddCategory(categoryName);

            // Assert
            var category = await DbContext.Categories.FirstOrDefaultAsync(c => c.Name == categoryName);
            Assert.NotNull(category);
            _mockValidation.Verify(v => v.Validate(categoryName), Times.Once);
        }

        [Fact]
        public async Task AddCategory_DuplicateName_ThrowsException()
        {
            // Arrange
            var existing = new Category { Name = "Electronics" };
            DbContext.Categories.Add(existing);
            await DbContext.SaveChangesAsync();

            _mockValidation.Setup(v => v.Validate(It.IsAny<string>())).Verifiable();

            // Act & Assert
            var ex = await Assert.ThrowsAsync<Exception>(() => _categoryService.AddCategory("Electronics"));
            Assert.Equal("CategoryExisted", ex.Message);
        }

        [Fact]
        public async Task UpdateCategory_ValidNewName_UpdatesSuccessfully()
        {
            // Arrange
            var catId = Guid.NewGuid();
            DbContext.Categories.Add(new Category { Id = catId, Name = "OldName" });
            await DbContext.SaveChangesAsync();

            _mockValidation.Setup(v => v.Validate("NewName")).Verifiable();

            // Act
            await _categoryService.UpdateCategory(catId, "NewName");

            // Assert
            var updated = await DbContext.Categories.FindAsync(catId);
            Assert.Equal("NewName", updated.Name);
            _mockValidation.Verify(v => v.Validate("NewName"), Times.Once);
        }

        [Fact]
        public async Task UpdateCategory_DuplicateName_ThrowsException()
        {
            // Arrange
            var cat1 = new Category { Id = Guid.NewGuid(), Name = "First" };
            var cat2 = new Category { Id = Guid.NewGuid(), Name = "Second" };
            DbContext.Categories.AddRange(cat1, cat2);
            await DbContext.SaveChangesAsync();

            _mockValidation.Setup(v => v.Validate(It.IsAny<string>())).Verifiable();

            // Act & Assert
            var ex = await Assert.ThrowsAsync<Exception>(() => _categoryService.UpdateCategory(cat1.Id, "Second"));
            Assert.Equal("CategoryExisted", ex.Message);
        }

        [Fact]
        public async Task UpdateCategory_CategoryNotFound_ThrowsException()
        {
            // Arrange
            _mockValidation.Setup(v => v.Validate(It.IsAny<string>())).Verifiable();

            // Act & Assert
            var ex = await Assert.ThrowsAsync<Exception>(() => _categoryService.UpdateCategory(Guid.NewGuid(), "NewName"));
            Assert.Equal("CategoryNull", ex.Message);
        }

        [Fact]
        public async Task DeleteCategory_NoProducts_RemovesCategory()
        {
            // Arrange
            var catId = Guid.NewGuid();
            DbContext.Categories.Add(new Category { Id = catId, Name = "ToDelete" });
            await DbContext.SaveChangesAsync();

            // Act
            await _categoryService.DeleteCategory(catId);

            // Assert
            var category = await DbContext.Categories.FindAsync(catId);
            Assert.Null(category);
        }

        [Fact]
        public async Task DeleteCategory_HasProducts_ThrowsException()
        {
            // Arrange
            var catId = Guid.NewGuid();
            DbContext.Categories.Add(new Category { Id = catId, Name = "WithProducts" });
            DbContext.Products.Add(new Product { CategoryId = catId, Name = "Product1", Unit = "шт", Article = "ART-1", CurrentStock = 10 });
            await DbContext.SaveChangesAsync();

            // Act & Assert
            var ex = await Assert.ThrowsAsync<Exception>(() => _categoryService.DeleteCategory(catId));
            Assert.Equal("CategoryWithProductsForDelete", ex.Message);
        }

        [Fact]
        public async Task DeleteCategory_NotFound_ThrowsException()
        {
            // Act & Assert
            var ex = await Assert.ThrowsAsync<Exception>(() => _categoryService.DeleteCategory(Guid.NewGuid()));
            Assert.Equal("CategoryNull", ex.Message);
        }
    }
}