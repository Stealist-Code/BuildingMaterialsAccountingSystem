using System;
using System.Collections.Generic;
using System.Text;

namespace StorageSystemBuildingMaterials.DTO
{
    /// <summary>
    /// DTO для импорта поставок из JSON-файла
    /// </summary>
    public class ShipmentImportDto
    {
        /// <summary>
        /// Название товара 
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Количество товара в поставке
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Цена за единицу товара
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Срок годности товара
        /// </summary>
        public DateTime ExpirationDate { get; set; }
    }
}
