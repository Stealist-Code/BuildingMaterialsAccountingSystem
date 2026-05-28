using System;

namespace StorageSystemBuildingMaterials.DTO
{
    /// <summary>
    /// DTO для отчетов
    /// </summary>
    public class ReportDto
    {
        /// <summary>
        /// Дата 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// ФИО покупателя
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Сумма отгрузки
        /// </summary>
        public decimal ShipmentAmount { get; set; }

        /// <summary>
        /// Прибыль
        /// </summary>
        public decimal Profit { get; set; }

        /// <summary>
        /// Электронная почта покупателя
        /// </summary>
        public string CustomerEmail { get; set; }
    }
}
