using Microsoft.EntityFrameworkCore;
using NLog;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Validation.Interfaces;
using System;

namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с товарами. Логика с БД, связанная с товарами!!!
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly AppDbContext _db;
        private readonly IProductValidation _productValidation;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public ProductService(AppDbContext db, IProductValidation productValidation)
        {
            _db = db;
            _productValidation = productValidation;
        }

        /// <summary>
        /// Получить товары по категории
        /// </summary>
        public async Task<List<ProductDto>> GetProducts(Guid categoryId)
        {
            try
            {
                return await _db.Products
                    .AsNoTracking()
                    .Where(x => x.CategoryId == categoryId)
                    .Select(x => new ProductDto
                    {
                        Id = x.Id,
                        Article = x.Article,
                        Name = x.Name,
                        CategoryName = x.Category.Name,
                        Unit = x.Unit,
                        PurchasePrice = x.PurchasePrice,
                        CurrentStock = x.CurrentStock,
                        ExpirationDate = x.ExpirationDate,
                        ReceivedDate = x.ReceivedDate,
                        DaysLeft = (x.ExpirationDate - DateTime.UtcNow).Days,
                    })
                    .OrderBy(x => x.Name)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка получения товаров по категории {categoryId}");
                throw;
            }
        }

        /// <summary>
        /// Получить список товаров для отображения
        /// </summary>
        public async Task<List<ProductDto>> GetProducts()
        {
            try
            {
                return await _db.Products
                    .AsNoTracking()
                    .Select(x => new ProductDto
                    {
                        Id = x.Id,
                        Article = x.Article,
                        Name = x.Name,
                        CategoryName = x.Category.Name,
                        CategoryId = x.CategoryId,
                        Unit = x.Unit,
                        PurchasePrice = x.PurchasePrice,
                        CurrentStock = x.CurrentStock,
                        ExpirationDate = x.ExpirationDate,
                        ReceivedDate = x.ReceivedDate,
                        DaysLeft = (x.ExpirationDate - DateTime.UtcNow).Days,
                    })
                    .OrderBy(x => x.Name)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка получения списка товаров");
                throw;
            }
        }

        /// <summary>
        /// Поиск товаров по названию/артикулу/названию категории (или сразу все вместе)
        /// </summary>
        /// <param name="article"></param>
        /// <param name="name"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public async Task<List<ProductDto>> SearchProductsAdvanced(string articleStr, string name, Guid? categoryId)
        {
            try
            {
                var query = _db.Products.AsNoTracking().AsQueryable();

                if (!string.IsNullOrWhiteSpace(articleStr) && long.TryParse(articleStr, out long articleNum))
                {
                    query = query.Where(x => x.Article.ToLower() == $"art-" + articleNum);
                }

                if (!string.IsNullOrWhiteSpace(name))
                {
                    query = query.Where(x => x.Name.ToLower() == name.ToLower());
                }

                if (categoryId.HasValue)
                {
                    query = query.Where(x => x.CategoryId == categoryId.Value);
                }

                var now = DateTime.UtcNow;

                return await query
                    .Select(x => new ProductDto
                    {
                        Id = x.Id,
                        Article = x.Article,
                        Name = x.Name,

                        ExpirationDate = x.ExpirationDate,
                        DaysLeft = (x.ExpirationDate - now).Days,
                        CategoryName = x.Category.Name,
                        Unit = x.Unit,
                        PurchasePrice = x.PurchasePrice,
                        CurrentStock = x.CurrentStock
                    })
                    .OrderBy(x => x.Name)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка поиска товаров");
                throw;
            }
        }

        /// <summary>
        /// Создать товар
        /// </summary>
        /// <param name="product"></param>
        public async Task CreateProduct(Product product)
        {
            _logger.Info($"Добавление нового товара: {product?.Name}");

            try
            {
                _productValidation.Validate(product);

                _logger.Debug("Проверка уникальности артикула");

                if (await _db.Products.AnyAsync(x => x.Article == product.Article))
                {
                    _logger.Info("Артикул уже существует");
                    throw new Exception("ProductWithSimilarArticle");
                }

                product.Id = Guid.NewGuid();
                product.Article = await GenerateArticle();
                product.ReceivedDate = DateTime.UtcNow;
                await _db.Products.AddAsync(product);
                await _db.SaveChangesAsync();

                _logger.Info($"Товар создан id={product.Id}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка добавления товара");
                throw;
            }
        }

        /// <summary>
        /// Обновить данные товара
        /// </summary>
        /// <param name="updated"></param>
        /// <exception cref="Exception"></exception>
        public async Task UpdateProduct(Guid id, Product updated)
        {
            _logger.Info($"Редактирование товара id={id}");
            try
            {
                _productValidation.Validate(updated);

                var existing = await _db.Products.FindAsync(id);

                if (existing is null)
                {
                    throw new Exception("ProductNotFound");
                }

                _logger.Debug("Проверка уникальности артикула");

                if (existing.Article != updated.Article && await _db.Products.AnyAsync(p => p.Article == updated.Article && p.Id != id))
                {
                    _logger.Info("Артикул уже существует");
                    throw new Exception("ProductWithSimilarArticle");
                }

                existing.Name = updated.Name;
                existing.CategoryId = updated.CategoryId;
                existing.Unit = updated.Unit;
                existing.PurchasePrice = updated.PurchasePrice;
                existing.CurrentStock = updated.CurrentStock;

                await _db.SaveChangesAsync();

                _logger.Info($"Товар обновлён id={id}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка обновления товара id={id}");
                throw;
            }
        }

        /// <summary>
        /// Удалить товар
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public async Task DeleteProduct(Guid id)
        {
            try
            {
                var product = await _db.Products.FirstOrDefaultAsync(p => p.Id == id);

                if (product is null)
                {
                    return;
                }

                bool usedInShipment = await _db.ShipmentItems.AnyAsync(si => si.ProductId == id);

                if (usedInShipment)
                {
                    throw new Exception("ProductCannotDeletedInShippment");
                }

                _db.Products.Remove(product);
                await _db.SaveChangesAsync();

                _logger.Info($"Товар удалён id={id}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка удаления товара id={id}");
                throw;
            }
        }

        private async Task<string> GenerateArticle()
        {
            int count = await _db.Products.CountAsync() + 1;
            return $"ART-{count}";
        }

        /// <summary>
        /// Получить непросроченные товары 
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductDto>> GetActualProducts()
        {
            var today = DateTime.UtcNow.Date;

            var supplies = await _db.SupplyItems
                .Include(x => x.Product)
                    .ThenInclude(p => p.Category)
                .Where(x => x.ExpirationDate.Date > today)
                .ToListAsync();

            var result = supplies
                .GroupBy(x => x.Product)
                .Select(g =>
                {
                    var minExpiration = g.Min(x => x.ExpirationDate);

                    return new ProductDto
                    {
                        Id = g.Key.Id,
                        Article = g.Key.Article,
                        Name = g.Key.Name,
                        CategoryName = g.Key.Category.Name,
                        CategoryId = g.Key.CategoryId,
                        Unit = g.Key.Unit,
                        PurchasePrice = g.Key.PurchasePrice,

                        CurrentStock = g.Sum(x => x.Quantity),

                        ExpirationDate = minExpiration,
                        ReceivedDate = g.Max(x => x.ReceivedDate),

                        DaysLeft = (minExpiration.Date - today).Days
                    };
                })
                .ToList();

            return result;
        }

        /// <summary>
        /// Получить просроченные товары
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductDto>> GetExpiredProducts()
        {
            var today = DateTime.UtcNow.Date;

            var supplies = await _db.SupplyItems
                .Include(x => x.Product)
                    .ThenInclude(p => p.Category)
                .Where(x => x.ExpirationDate < today)
                .ToListAsync();

            var result = supplies
                .GroupBy(x => x.Product)
                .Select(g =>
                {
                    var maxExpiration = g.Max(x => x.ExpirationDate);

                    return new ProductDto
                    {
                        Id = g.Key.Id,
                        Article = g.Key.Article,
                        Name = g.Key.Name,
                        CategoryName = g.Key.Category.Name,
                        CategoryId = g.Key.CategoryId,
                        Unit = g.Key.Unit,
                        PurchasePrice = g.Key.PurchasePrice,

                        CurrentStock = g.Sum(x => x.Quantity),

                        ExpirationDate = maxExpiration,
                        ReceivedDate = g.Max(x => x.ReceivedDate),

                        DaysLeft = (maxExpiration.Date - today).Days
                    };
                })
                .ToList();

            return result;
        }
    }
}