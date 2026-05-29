namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с товарами
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Получить товары по категории
        /// </summary>
        /// <param name="categoryId">Id категории</param>
        /// <returns>Товары с указанным категорией</returns>
        public Task<List<ProductDto>> GetProducts(Guid categoryId);

        /// <summary>
        /// Получение всех товаров
        /// </summary>
        /// <returns>Список товаров</returns>
        public Task<List<ProductDto>> GetProducts();

        /// <summary>
        /// Создать товар
        /// </summary>
        /// <param name="product">Объект товара</param>
        public Task CreateProduct(Product product);

        /// <summary>
        /// Обновить данные товара
        /// </summary>
        /// <param name="updated">Объект товара</param>
        /// <exception cref="Exception">Ошибка обновления товара</exception>
        public Task UpdateProduct(Guid id, Product updated);

        /// <summary>
        /// Удалить товар
        /// </summary>
        /// <param name="id">Id товара</param>
        /// <exception cref="Exception">Ошибка удаления товара</exception>
        public Task DeleteProduct(Guid id);

        /// <summary>
        /// Получение непросроченных товаров
        /// </summary>
        /// <returns></returns>
        public Task<List<ProductDto>> GetActualProducts();

        /// <summary>
        /// Получение просроченных товаров
        /// </summary>
        /// <returns>Список товаров</returns>
        public Task<List<ProductDto>> GetExpiredProducts();

        /// <summary>
        /// Поиск товаров по названию/артикулу/названию категории (или сразу все вместе)
        /// </summary>
        /// <param name="article">Артикль</param>
        /// <param name="name">Название</param>
        /// <param name="categoryId">Id категории</param>
        /// <returns>Список товаров</returns>
        public Task<List<ProductDto>> SearchProductsAdvanced(string articleStr, string name, Guid? categoryId);
    }
}