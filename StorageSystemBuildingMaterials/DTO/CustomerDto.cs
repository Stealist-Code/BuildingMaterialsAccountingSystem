using System.ComponentModel.DataAnnotations.Schema;

namespace StorageSystemBuildingMaterials.DTO
{
    /// <summary>
    /// DTO для данных о покупателе
    /// </summary>
    public class CustomerDto
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
        public string Email { get; set; }

        /// <summary>
        /// Id адреса
        /// </summary>
        public Guid AddressId { get; set; }

        /// <summary>
        /// Страна для отгрузки
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Регион для отгрузки
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Город для отгрузки
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Улица для отгрузки
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Здание для отгрузки
        /// </summary>
        public string Building { get; set; }

        /// <summary>
        /// Полный адрес до покупателя, куда отгружаем
        /// </summary>
        public string FullAddress { get; set; }
    }
}
