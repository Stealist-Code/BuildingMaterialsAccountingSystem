using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с товарами
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Получение товаров по категории
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public Task<List<ProductDto>> GetProducts(Guid categoryId);

        /// <summary>
        /// Получение всех товаров
        /// </summary>
        /// <returns></returns>
        public Task<List<ProductDto>> GetProducts();

        /// <summary>
        /// Поиск товаров по артикулу, названию, категории
        /// </summary>
        /// <param name="article"></param>
        /// <param name="name"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public Task<List<ProductDto>> SearchProductsAdvanced(string article, string name, Guid? categoryId);

        /// <summary>
        /// Создание товара
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public Task CreateProduct(Product product);

        /// <summary>
        /// Обновление товара
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updated"></param>
        /// <returns></returns>
        public Task UpdateProduct(Guid id, Product updated);

        /// <summary>
        /// Удаление товара
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task DeleteProduct(Guid id);

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