using System;

namespace StorageSystemBuildingMaterials.DTO
{
    /// <summary>
    /// Класс, который представляет данные о товаре для отображения в приложении
    /// </summary>
    public class ProductDto
    {
        /// <summary>
        /// ID товара
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Артикул товара
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Название категории
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Идентификатор категории, к которой относится товар
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Цена закупки
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Текущий остаток на складе
        /// </summary>
        public int CurrentStock { get; set; }

        /// <summary>
        /// Срок годности
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Дата приемки
        /// </summary>
        public DateTime ReceivedDate { get; set; }

        /// <summary>
        /// Сколько дней осталось
        /// </summary>
        public int DaysLeft { get; set; }

        /// <summary>
        /// Страховка
        /// </summary>
        public bool Insurance { get; set; }

        /// <summary>
        /// Термоконтейнер
        /// </summary>
        public bool ThermalContainer { get; set; }
    }
}