namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с ИНН
    /// </summary>
    public interface ITINService
    {
        /// <summary>
        /// Возвращает информацию о клиенте по ИНН. Если клиент не найден, создаёт его.
        /// </summary>
        /// <param name="tIN">ИНН клиента.</param>
        /// <returns>Покупатель DTO</returns>
        public Task<CustomerDto> GetInfoCustomer(string tIN);

        /// <summary>
        /// Находит клиента по ИНН вместе с адресом.
        /// </summary>
        /// <param name="tIN">ИНН клиента.</param>
        /// <returns>Покупатель</returns>
        public Task<Customer> FindCustomerWithTIN(string tIN);

        /// <summary>
        /// Проверяет компанию по ИНН в списке недобросовестных контрагентов.
        /// </summary>
        /// <param name="tIN">ИНН компании.</param>
        /// <returns>Сообщение с признаками нарушений на русском или английском языке, либо пустая строка.</returns>
        public Task<string> CheckCompanyOnBlackList(string tIN);

        /// <summary>
        /// Метод для получения координатов по адресу
        /// </summary>
        /// <param name="address">Адрес</param>
        /// <returns>Возвращает кортеж с широтой и долготой</returns>
        public Task<(double latitude, double longitude)> GetCoordinates(string address);
    }
}
