using System;

namespace StorageSystemBuildingMaterials.DTO
{
    /// <summary>
    /// Данные о товаре в отгрузке
    /// </summary>
    public class ShipmentItemDto
    {
        /// <summary>
        /// Идентификатор товара
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Количество товара
        /// </summary>
        public int Quantity { get; set; }
    }
}