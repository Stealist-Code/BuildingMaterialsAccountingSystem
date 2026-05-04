using Microsoft.EntityFrameworkCore;
using NLog;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Validation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
                return await _db.SupplyItems
                    .AsNoTracking()
                    .Include(x => x.Product)
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
                    .ToListAsync();
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

            return await _db.SupplyItems
                    .AsNoTracking()
                    .Where(x => x.ExpirationDate.Date > today)
                    .Include(x => x.Product)
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
                    .ToListAsync();
        }

        /// <summary>
        /// Получить просроченные товары
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductDto>> GetExpiredProducts()
        {
            var today = DateTime.UtcNow.Date;

            return await _db.SupplyItems
                    .AsNoTracking()
                    .Where(x => x.ExpirationDate.Date <= today)
                    .Include(x => x.Product)
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
                        DaysLeft = (x.ExpirationDate - today).Days,
                    })
                    .OrderBy(x => x.Name)
                    .ToListAsync();
        }
    }
}
