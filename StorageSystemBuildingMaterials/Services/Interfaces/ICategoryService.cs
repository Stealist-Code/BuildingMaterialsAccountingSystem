using StorageSystemBuildingMaterials.Models;
using System;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с категориями
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// Получение списка всех категорий
        /// </summary>
        /// <returns></returns>
        public Task<List<Category>> GetAllCategories();

        /// <summary>
        /// Добавление категорий
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task AddCategory(string name);
        
        /// <summary>
        /// Обновление категории
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newName"></param>
        /// <returns></returns>
        public Task UpdateCategory(Guid id, string newName);
        
        /// <summary>
        /// Удаление категорий
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task DeleteCategory(Guid id);
    }
}