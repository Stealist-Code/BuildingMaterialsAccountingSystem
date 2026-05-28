using Microsoft.EntityFrameworkCore;
using Moq;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Tests.Services
{
    public class ProductServiceTests : TestBase
    {
        private readonly Mock<IProductValidation> _mockValidation;
        private readonly ProductService _productService;

        public ProductServiceTests()
        {
            _mockValidation = new Mock<IProductValidation>();
            _productService = new ProductService(DbContext, _mockValidation.Object);
        }

        [Fact]
        public async Task GetProducts_ReturnsAllProductsOrdered()
        {
            // Arrange
            var category = new Category { Id = Guid.NewGuid(), Name = "Cat1" };
            DbContext.Categories.Add(category);
            DbContext.Products.AddRange(
                new Product { Id = Guid.NewGuid(), Name = "Z_Product", Unit = "шт", Article = "A1", CategoryId = category.Id, CurrentStock = 10 },
                new Product { Id = Guid.NewGuid(), Name = "A_Product", Unit = "шт", Article = "A2", CategoryId = category.Id, CurrentStock = 5 }
            );
            await DbContext.SaveChangesAsync();

            // Act
            var products = await _productService.GetProducts();

            // Assert
            Assert.Equal(2, products.Count);
            Assert.Equal("A_Product", products[0].Name);
            Assert.Equal("Z_Product", products[1].Name);
        }

        [Fact]
        public async Task GetProducts_ByCategoryId_ReturnsFiltered()
        {
            // Arrange
            var cat1 = new Category { Id = Guid.NewGuid(), Name = "Cat1" };
            var cat2 = new Category { Id = Guid.NewGuid(), Name = "Cat2" };
            DbContext.Categories.AddRange(cat1, cat2);
            DbContext.Products.AddRange(
                new Product { Name = "P1", Unit = "шт", Article = "A1", CategoryId = cat1.Id, CurrentStock = 10 },
                new Product { Name = "P2", Unit = "шт", Article = "A2", CategoryId = cat2.Id, CurrentStock = 10 }
            );
            await DbContext.SaveChangesAsync();

            // Act
            var result = await _productService.GetProducts(cat1.Id);

            // Assert
            Assert.Single(result);
            Assert.Equal("P1", result[0].Name);
        }

        [Fact]
        public async Task CreateProduct_ValidProduct_GeneratesArticleAndSaves()
        {
            // Arrange
            var category = new Category { Id = Guid.NewGuid(), Name = "Cat" };
            DbContext.Categories.Add(category);
            await DbContext.SaveChangesAsync();

            var product = new Product
            {
                Name = "New Product",
                CategoryId = category.Id,
                Unit = "pcs",
                PurchasePrice = 100m,
                CurrentStock = 50
            };

            _mockValidation.Setup(v => v.Validate(product)).Verifiable();

            // Act
            await _productService.CreateProduct(product);

            // Assert
            var saved = await DbContext.Products.FirstOrDefaultAsync(p => p.Name == "New Product");
            Assert.NotNull(saved);
            Assert.StartsWith("ART-", saved.Article);
            Assert.Equal(100m, saved.PurchasePrice);
            _mockValidation.Verify(v => v.Validate(product), Times.Once);
        }

        [Fact]
        public async Task CreateProduct_MultipleProducts_GeneratesSequentialArticle()
        {
            // Arrange
            var category = new Category { Id = Guid.NewGuid(), Name = "Cat" };
            DbContext.Categories.Add(category);
            await DbContext.SaveChangesAsync();

            _mockValidation.Setup(v => v.Validate(It.IsAny<Product>())).Verifiable();

            // Act
            await _productService.CreateProduct(new Product { Unit = "шт", Name = "First", CategoryId = category.Id, CurrentStock = 1 });
            await _productService.CreateProduct(new Product { Unit = "шт", Name = "Second", CategoryId = category.Id, CurrentStock = 1 });

            // Assert
            var products = await DbContext.Products.OrderBy(p => p.Article).ToListAsync();
            Assert.Equal("ART-1", products[0].Article);
            Assert.Equal("ART-2", products[1].Article);
        }

        [Fact]
        public async Task UpdateProduct_ValidData_UpdatesSuccessfully()
        {
            // Arrange
            var cat1 = new Category { Id = Guid.NewGuid(), Name = "Cat1" };
            var cat2 = new Category { Id = Guid.NewGuid(), Name = "Cat2" };
            DbContext.Categories.AddRange(cat1, cat2);

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Original",
                Article = "ART-1",
                CategoryId = cat1.Id,
                Unit = "kg",
                PurchasePrice = 10m,
                CurrentStock = 100
            };
            DbContext.Products.Add(product);
            await DbContext.SaveChangesAsync();

            var updated = new Product
            {
                Name = "Updated",
                CategoryId = cat2.Id,
                Unit = "pcs",
                PurchasePrice = 20m,
                CurrentStock = 200,
                Article = "ART-1" // same article
            };

            _mockValidation.Setup(v => v.Validate(updated)).Verifiable();

            // Act
            await _productService.UpdateProduct(product.Id, updated);

            // Assert
            var saved = await DbContext.Products.FindAsync(product.Id);
            Assert.Equal("Updated", saved.Name);
            Assert.Equal(cat2.Id, saved.CategoryId);
            Assert.Equal("pcs", saved.Unit);
            Assert.Equal(20m, saved.PurchasePrice);
            Assert.Equal(200, saved.CurrentStock);
            _mockValidation.Verify(v => v.Validate(updated), Times.Once);
        }

        [Fact]
        public async Task UpdateProduct_ProductNotFound_ThrowsException()
        {
            // Arrange
            var updated = new Product { Name = "Test", CategoryId = Guid.NewGuid() };
            _mockValidation.Setup(v => v.Validate(updated)).Verifiable();

            // Act & Assert
            var ex = await Assert.ThrowsAsync<Exception>(() => _productService.UpdateProduct(Guid.NewGuid(), updated));
            Assert.Equal("ProductNotFound", ex.Message);
        }

        [Fact]
        public async Task UpdateProduct_DuplicateArticle_ThrowsException()
        {
            // Arrange
            var category = new Category { Id = Guid.NewGuid(), Name = "Cat" };
            DbContext.Categories.Add(category);

            var product1 = new Product { Id = Guid.NewGuid(), Name = "P1", Unit = "шт", Article = "ART-1", CategoryId = category.Id, CurrentStock = 10 };
            var product2 = new Product { Id = Guid.NewGuid(), Name = "P2", Unit = "шт", Article = "ART-2", CategoryId = category.Id, CurrentStock = 10 };
            DbContext.Products.AddRange(product1, product2);
            await DbContext.SaveChangesAsync();

            var updated = new Product { Name = "P1", Unit = "шт", Article = "ART-2", CategoryId = category.Id };
            _mockValidation.Setup(v => v.Validate(updated)).Verifiable();

            // Act & Assert
            var ex = await Assert.ThrowsAsync<Exception>(() => _productService.UpdateProduct(product1.Id, updated));
            Assert.Equal("ProductWithSimilarArticle", ex.Message);
        }

        [Fact]
        public async Task DeleteProduct_ValidProduct_RemovesProduct()
        {
            // Arrange
            var category = new Category { Id = Guid.NewGuid(), Name = "Cat" };
            DbContext.Categories.Add(category);
            var product = new Product { Id = Guid.NewGuid(), Name = "ToDelete", Unit = "шт", Article = "ART-1", CategoryId = category.Id, CurrentStock = 10 };
            DbContext.Products.Add(product);
            await DbContext.SaveChangesAsync();

            // Act
            await _productService.DeleteProduct(product.Id);

            // Assert
            var deleted = await DbContext.Products.FindAsync(product.Id);
            Assert.Null(deleted);
        }

        [Fact]
        public async Task DeleteProduct_UsedInShipment_ThrowsException()
        {
            // Arrange
            var category = new Category { Id = Guid.NewGuid(), Name = "Cat" };
            var product = new Product { Id = Guid.NewGuid(), Name = "Used", Article = "ART-1", Unit = "шт", CategoryId = category.Id, CurrentStock = 10 };
            DbContext.Categories.Add(category);
            DbContext.Products.Add(product);

            var shipment = new Shipment { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), ShipmentDate = DateTime.UtcNow };
            DbContext.Shipments.Add(shipment);
            DbContext.ShipmentItems.Add(new ShipmentItem { ProductId = product.Id, ShipmentId = shipment.Id, Quantity = 1 });
            await DbContext.SaveChangesAsync();

            // Act & Assert
            var ex = await Assert.ThrowsAsync<Exception>(() => _productService.DeleteProduct(product.Id));
            Assert.Equal("ProductCannotDeletedInShippment", ex.Message);
        }

        [Fact]
        public async Task DeleteProduct_NotFound_DoesNothing()
        {
            // Act
            await _productService.DeleteProduct(Guid.NewGuid());

            // Assert (no exception)
            Assert.True(true);
        }

        [Fact]
        public async Task SearchProductsAdvanced_ByArticle_ReturnsMatching()
        {
            // Arrange
            var catId = Guid.NewGuid();
            DbContext.Categories.Add(new Category { Id = catId, Name = "Cat" });
            DbContext.Products.AddRange(
                new Product { Id = Guid.NewGuid(), Name = "Product A", Unit = "шт", Article = "ART-123", CategoryId = catId, CurrentStock = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Product B", Unit = "шт", Article = "ART-456", CategoryId = catId, CurrentStock = 10 }
            );
            await DbContext.SaveChangesAsync();

            // Act
            var results = await _productService.SearchProductsAdvanced("123", null, null);

            // Assert
            Assert.Single(results);
            Assert.Equal("ART-123", results[0].Article);
        }

        [Fact]
        public async Task SearchProductsAdvanced_ByName_ReturnsMatching()
        {
            // Arrange
            var catId = Guid.NewGuid();
            DbContext.Categories.Add(new Category { Id = catId, Name = "Cat" });
            DbContext.Products.AddRange(
                new Product { Name = "Гвозди", Unit = "шт", Article = "A1", CategoryId = catId, CurrentStock = 10 },
                new Product { Name = "Шурупы", Unit = "шт", Article = "A2", CategoryId = catId, CurrentStock = 10 }
            );
            await DbContext.SaveChangesAsync();

            // Act
            var results = await _productService.SearchProductsAdvanced(null, "гвозди", null);

            // Assert
            Assert.Single(results);
            Assert.Equal("Гвозди", results[0].Name);
        }

        [Fact]
        public async Task SearchProductsAdvanced_ByCategory_ReturnsMatching()
        {
            // Arrange
            var cat1 = new Category { Id = Guid.NewGuid(), Name = "Cat1" };
            var cat2 = new Category { Id = Guid.NewGuid(), Name = "Cat2" };
            DbContext.Categories.AddRange(cat1, cat2);
            DbContext.Products.AddRange(
                new Product { Name = "P1", Unit = "шт", Article = "A1", CategoryId = cat1.Id, CurrentStock = 10 },
                new Product { Name = "P2", Unit = "шт", Article = "A2", CategoryId = cat2.Id, CurrentStock = 10 }
            );
            await DbContext.SaveChangesAsync();

            // Act
            var results = await _productService.SearchProductsAdvanced(null, null, cat1.Id);

            // Assert
            Assert.Single(results);
            Assert.Equal("P1", results[0].Name);
        }

        [Fact]
        public async Task SearchProductsAdvanced_AllCriteria_ReturnsIntersection()
        {
            // Arrange
            var cat1 = new Category { Id = Guid.NewGuid(), Name = "Cat1" };
            DbContext.Categories.Add(cat1);
            DbContext.Products.AddRange(
                new Product { Name = "Target", Unit = "шт", Article = "ART-100", CategoryId = cat1.Id, CurrentStock = 10 },
                new Product { Name = "Target", Unit = "шт", Article = "ART-200", CategoryId = Guid.NewGuid(), CurrentStock = 10 },
                new Product { Name = "Other", Unit = "шт", Article = "ART-100", CategoryId = cat1.Id, CurrentStock = 10 }
            );
            await DbContext.SaveChangesAsync();

            // Act
            var results = await _productService.SearchProductsAdvanced("100", "target", cat1.Id);

            // Assert
            Assert.Single(results);
            Assert.Equal("Target", results[0].Name);
            Assert.Equal("ART-100", results[0].Article);
        }
    }
}