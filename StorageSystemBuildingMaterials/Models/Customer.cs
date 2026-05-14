using System;

namespace StorageSystemBuildingMaterials.Models
{
    /// <summary>
    /// Модель покупателя
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Id покупателя
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// ИНН покупателя
        /// </summary>
        public string TIN {  get; set; }

        /// <summary>
        /// Имя 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string? MiddleName { get; set; }

        /// <summary>
        /// Электронная почта 
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Внешний ключ - id адреса
        /// </summary>
        public Guid AddressId { get; set; }

        /// <summary>
        /// Навигационной свойство - объект адреса
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Вычисляемое поле ФИО
        /// </summary>
        public string FullName => string.Join(' ', new[] { LastName, FirstName, MiddleName }
                                        .Where(x => !string.IsNullOrEmpty(x)));
        /// <summary>
        /// Список отгрузок, связанных с данным покупателем
        /// </summary>
        public List<Shipment> Shipments { get; set; }
    }
}