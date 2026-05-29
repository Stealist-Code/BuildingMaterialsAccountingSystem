namespace StorageSystemBuildingMaterials.Models
{
    /// <summary>
    /// Модель класса для адресов
    /// </summary>
    public class Address
    {
        /// <summary>
        /// ID адреса
        /// </summary>
        public Guid Id { get; set; }

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
        /// Навигационное свойство - объект покупателя
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Полный адрес до пользователя, кому отгружаем
        /// </summary>
        [NotMapped]
        public string FullAddress => $"{Country}, {Region},{City}, {Street}, {Building}";
    }
}