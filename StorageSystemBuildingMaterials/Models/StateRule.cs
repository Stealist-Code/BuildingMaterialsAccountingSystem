namespace StorageSystemBuildingMaterials.Models
{
    /// <summary>
    /// Определяет правила перехода товара в различные состояния и условия применения скидок
    /// </summary>
    public class StateRule
    {
        /// <summary>
        /// Идентификатор правил состояния товарной позиции
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Навигационное свойство состояния товарной позиции
        /// </summary>
        public ICollection<ProductState> ProductStates { get; set; }

        /// <summary>
        /// Количество дней до активации скидки
        /// </summary>
        public int DaysBeforeDiscount { get; set; }

        /// <summary>
        /// Размер скидки (в процентах)
        /// </summary>
        public decimal Discount { get; set; }
    }
}
