namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с поставками
    /// </summary>
    public interface ISupplyService
    {
        /// <summary>
        /// Получение всех товаров
        /// </summary>
        /// <returns>Список товаров</returns>
        public Task<List<ProductDto>> GetProducts();

        /// <summary>
        /// Получение непросроченных товаров
        /// </summary>
        /// <returns>Список товаров</returns>
        public Task<List<ProductDto>> GetActualProducts();

        /// <summary>
        /// Получение просроченных товаров
        /// </summary>
        /// <returns>Список товаров</returns>
        public Task<List<ProductDto>> GetExpiredProducts();

        /// <summary>
        /// Поиск товаров по названию/артикулу/названию категории (или сразу все вместе)
        /// </summary>
        /// <param name="articleStr">Артикул в строковом формате (будет преобразован в число).</param>
        /// <param name="name">Название товара (точное совпадение).</param>
        /// <param name="categoryId">ID категории.</param>
        /// <returns>Список товаров</returns>
        public Task<List<ProductDto>> SearchProductsAdvanced(string article, string name, Guid? categoryId);

        
    }
}
