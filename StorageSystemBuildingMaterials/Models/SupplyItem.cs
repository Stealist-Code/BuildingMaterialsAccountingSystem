using System;
using System.Collections.Generic;
using System.Text;

namespace StorageSystemBuildingMaterials.Models
{
    /// <summary>
    /// Модель поставки
    /// </summary>
    public class SupplyItem
    {
        /// <summary>
        /// Идентификатор поставки
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор товара
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Навигационное свойство товара
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Количество товара в данной поставке
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Текущий остаток
        /// </summary>
        public int CurrentStock { get; set; }

        /// <summary>
        /// Цена закупки
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Срок годности
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Дата приема
        /// </summary>
        public DateTime ReceivedDate { get; set; }

        /// <summary>
        /// Навигационное свойство состояния товарной позиции
        /// </summary>
        public Guid ProductStateId { get; set; }

        /// <summary>
        /// Навигационное свойство состояния товарной позиции
        /// </summary>
        public ProductState ProductState { get; set; } 
    }
}