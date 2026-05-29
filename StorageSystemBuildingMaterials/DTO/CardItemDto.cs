namespace StorageSystemBuildingMaterials.DTO
{
    /// <summary>
    /// Класс, который представляет товар, добавленный в отгрузку. Содержит информацию: ID, название, кол-во, остаток
    /// </summary>
    public class CartItemDto
    {
        /// <summary>
        /// ID товара
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Цена закупки
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Цена отгрузки
        /// </summary>
        public decimal ShipmentPrice { get; set; }

        /// <summary>
        /// Количество товара в отгрузке
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Страховка
        /// </summary>
        public bool Insurance { get; set; }

        /// <summary>
        /// Термоконтейнер
        /// </summary>
        public bool ThermalContainer { get; set; }

        /// <summary>
        /// Остаток товара на складе
        /// </summary>
        public int Stock { get; set; }
    }
}