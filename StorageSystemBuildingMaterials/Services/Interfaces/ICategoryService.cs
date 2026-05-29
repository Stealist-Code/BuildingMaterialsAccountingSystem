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
        /// <returns>Список категорий</returns>
        public Task<List<Category>> GetAllCategories();

        /// <summary>
        /// Добавить категорию (только для админа)
        /// </summary>
        /// <param name="name">Название категории</param>
        /// <exception cref="Exception">Выбрасывается, если ошибка создания категории</exception>
        public Task AddCategory(string name);

        /// <summary>
        /// Обновляет название категории
        /// </summary>
        /// <param name="id">Id категории</param>
        /// <param name="newName">Новое название категории</param>
        /// <exception cref="Exception">Выбрасывается, если ошибка обновления категории</exception>
        public Task UpdateCategory(Guid id, string newName);

        /// <summary>
        /// Удалить категорию (только если нет товаров)
        /// </summary>
        /// <param name="id">Id категории</param>
        /// <exception cref="Exception">Выбрасывается, если ошибка удаления категории</exception>
        public Task DeleteCategory(Guid id);
    }
}