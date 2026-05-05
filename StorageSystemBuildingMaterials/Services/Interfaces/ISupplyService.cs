using StorageSystemBuildingMaterials.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    public interface ISupplyService
    {
        /// <summary>
        /// Получение всех товаров
        /// </summary>
        /// <returns></returns>
        public Task<List<ProductDto>> GetProducts();

        /// <summary>
        /// Получение непросроченных товаров
        /// </summary>
        /// <returns></returns>
        public Task<List<ProductDto>> GetActualProducts();

        /// <summary>
        /// Получение просроченных товаров
        /// </summary>
        /// <returns></returns>
        public Task<List<ProductDto>> GetExpiredProducts();

        /// <summary>
        /// Поиск товаров по артикулу, названию, категории
        /// </summary>
        /// <param name="article"></param>
        /// <param name="name"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public Task<List<ProductDto>> SearchProductsAdvanced(string article, string name, Guid? categoryId);
    }
}
