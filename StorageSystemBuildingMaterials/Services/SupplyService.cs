using Microsoft.EntityFrameworkCore;
using NLog;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.HelperClasses;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Services
{
    public class SupplyService : ISupplyService
    {
        private readonly AppDbContext _db;
        private readonly IProductValidation _productValidation;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public SupplyService(AppDbContext db, IProductValidation productValidation)
        {
            _db = db;
            _productValidation = productValidation;
        }

        /// <summary>
        /// Получить список товаров для отображения
        /// </summary>
        public async Task<List<ProductDto>> GetProducts()
        {
            try
            {
                var supplyItems = await _db.SupplyItems
                    .AsNoTracking()
                    .Include(x => x.Product)
                        .ThenInclude(x => x.Category)
                    .Include(x => x.ProductState)
                        .ThenInclude(x => x.StateRule)
                    .ToListAsync();

                await DiscountHelper.ApplyDiscount(_db, supplyItems);

                return supplyItems
                    .Select(x => new ProductDto
                    {
                        Id = x.Product.Id,
                        Article = x.Product.Article,
                        Name = x.Product.Name,
                        CategoryName = x.Product.Category.Name,
                        CategoryId = x.Product.CategoryId,
                        Unit = x.Product.Unit,
                        PurchasePrice = x.PurchasePrice,
                        CurrentStock = x.Quantity,
                        ExpirationDate = x.ExpirationDate,
                        ReceivedDate = x.ReceivedDate,
                        DaysLeft = (x.ExpirationDate - DateTime.UtcNow).Days,
                    })
                    .OrderBy(x => x.Name)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка получения списка товаров");
                throw;
            }
        }

        /// <summary>
        /// Получить непросроченные товары 
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductDto>> GetActualProducts()
        {
            var today = DateTime.UtcNow.Date;
            
            var supplyItems = await _db.SupplyItems
                    .AsNoTracking()
                    .Where(x => x.ExpirationDate.Date > today && x.CurrentStock > 0)
                    .Include(x => x.Product)
                        .ThenInclude(x => x.Category)
                    .Include(x => x.ProductState)
                        .ThenInclude(x => x.StateRule)
                    .ToListAsync();

            await DiscountHelper.ApplyDiscount(_db, supplyItems);

            return supplyItems
                    .Select(x => new ProductDto
                    {
                        Id = x.Product.Id,
                        Article = x.Product.Article,
                        Name = x.Product.Name,
                        CategoryName = x.Product.Category.Name,
                        CategoryId = x.Product.CategoryId,
                        Unit = x.Product.Unit,
                        PurchasePrice = x.PurchasePrice,
                        CurrentStock = x.CurrentStock,
                        ExpirationDate = x.ExpirationDate,
                        ReceivedDate = x.ReceivedDate,
                        DaysLeft = (x.ExpirationDate - DateTime.UtcNow).Days,
                    })
                    .OrderBy(x => x.Name)
                    .ToList();
        }

        /// <summary>
        /// Получить просроченные товары
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductDto>> GetExpiredProducts()
        {
            var today = DateTime.UtcNow.Date;

            var supplyItems = await _db.SupplyItems
                    .AsNoTracking()
                    .Where(x => x.ExpirationDate.Date <= today || x.CurrentStock <= 0)
                    .Include(x => x.Product)
                        .ThenInclude(x => x.Category)
                    .Include(x => x.ProductState)
                        .ThenInclude(x => x.StateRule)
                    .ToListAsync();

            await DiscountHelper.ApplyDiscount(_db, supplyItems);

            return supplyItems
                    .Select(x => new ProductDto
                    {
                        Id = x.Product.Id,
                        Article = x.Product.Article,
                        Name = x.Product.Name,
                        CategoryName = x.Product.Category.Name,
                        CategoryId = x.Product.CategoryId,
                        Unit = x.Product.Unit,
                        PurchasePrice = x.PurchasePrice,
                        CurrentStock = x.CurrentStock,
                        ExpirationDate = x.ExpirationDate,
                        ReceivedDate = x.ReceivedDate,
                        DaysLeft = (x.ExpirationDate - today).Days,
                    })
                    .OrderBy(x => x.Name)
                    .ToList();
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
                var supply = _db.SupplyItems.AsNoTracking().AsQueryable();

                if (!string.IsNullOrWhiteSpace(articleStr) && long.TryParse(articleStr, out long articleNum))
                {
                    supply = supply.Where(x => x.Product.Article.ToLower() == $"art-" + articleNum);
                }

                if (!string.IsNullOrWhiteSpace(name))
                {
                    supply = supply.Where(x => x.Product.Name.ToLower() == name.ToLower());
                }

                if (categoryId.HasValue)
                {
                    supply = supply.Where(x => x.Product.CategoryId == categoryId.Value);
                }

                var now = DateTime.UtcNow;

                return await supply
                    .Select(x => new ProductDto
                    {
                        Id = x.Id,
                        Article = x.Product.Article,
                        Name = x.Product.Name,

                        ExpirationDate = x.ExpirationDate,
                        DaysLeft = (x.ExpirationDate - now).Days,
                        CategoryName = x.Product.Category.Name,
                        Unit = x.Product.Unit,
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
    }
}
