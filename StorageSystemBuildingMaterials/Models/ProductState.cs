namespace StorageSystemBuildingMaterials.Models
{
    /// <summary>
    /// Текущее состояние товарной позиции
    /// </summary>
    public class ProductState
    {
        /// <summary>
        /// Идентификатор состояния товарной позиции
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор правил состояния
        /// </summary>
        public StateRule StateRule { get; set; }

        /// <summary>
        /// Идентификатор правил состояния
        /// </summary>
        public Guid StateRuleId { get; set; }
    }
}
