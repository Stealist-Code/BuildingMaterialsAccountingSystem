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
    }
}
