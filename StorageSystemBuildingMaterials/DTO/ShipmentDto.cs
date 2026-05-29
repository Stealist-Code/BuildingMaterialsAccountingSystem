namespace StorageSystemBuildingMaterials.DTO
{
    /// <summary>
    /// Данные об отгрузке
    /// </summary>
    public class ShipmentDto
    {
        /// <summary>
        /// Идентификатор отгрузки
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Email пользователя, создавшего отгрузку
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// Адрес доставки
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Дата и время создания отгрузки
        /// </summary>
        public DateTime ShipmentDate { get; set; }

        /// <summary>
        /// Список товаров в отгрузке
        /// </summary>
        public List<ShipmentItemDto> Items { get; set; }

        /// <summary>
        /// ФИО покупателя
        /// </summary>
        public string CustomerName { get; set; } 

        /// <summary>
        /// Email покупателя
        /// </summary>
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Сумма отгрузки
        /// </summary>
        public decimal TotalPrice { get; set; }
    }
}