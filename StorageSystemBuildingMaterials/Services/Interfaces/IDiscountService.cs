using StorageSystemBuildingMaterials.Models;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы со скидками 
    /// </summary>
    public interface IDiscountService
    {
        /// <summary>
        /// Создаёт или возвращает существующее состояние продукта с правилом скидки 30% за 14 дней.
        /// </summary>
        /// <returns>Возвращает существующее или вновь созданное состояние продукта</returns>
        public Task<ProductState> CreateProductState();

        /// <summary>
        /// Возвращает правило скидки 30% за 14 дней.
        /// </summary>
        /// <returns>Возвращает существующее или вновь созданное состояние продукта</returns>
        public Task<StateRule> CreateStateRule();
    }
}
