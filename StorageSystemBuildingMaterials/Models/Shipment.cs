using System;
using System.Collections.Generic;

namespace StorageSystemBuildingMaterials.Models
{
    /// <summary>
    /// Модель класса отгрузок
    /// </summary>
    public class Shipment
    {
        /// <summary>
        /// Уникальный идентификатор отгрузок (GUID)
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Кто отгрузил
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Дата и время отгрузки
        /// </summary>
        public DateTime ShipmentDate { get; set; }

        /// <summary>
        /// Адрес или наименование получателя
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// ID адреса
        /// </summary>
        public Guid AddressId { get; set; }

        /// <summary>
        /// Свойство с User
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Список позиций (товаров) в отгрузке
        /// </summary>
        public List<ShipmentItem> ShipmentItems { get; set; } = new();

        /// <summary>
        /// ID покупателя
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// Покупатель (кто заказал)
        /// </summary>
        public Customer? Customer { get; set; }

        /// <summary>
        /// Общая сумма продажи всей отгрузки
        /// </summary>
        public decimal PriceForSell { get; set; }

        /// <summary>
        /// Является ли поставкой
        /// </summary>
        public bool IsSupply {  get; set; } = false;
    }
}