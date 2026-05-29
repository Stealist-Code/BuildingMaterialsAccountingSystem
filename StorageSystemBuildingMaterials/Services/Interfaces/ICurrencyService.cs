namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для получения курсов валют
    /// </summary>
    public interface ICurrencyService
    {
        /// <summary>
        /// Получает курс указанной валюты относительно рубля
        /// </summary>
        /// <param name="code">Трехбуквенный код валюты.</param>
        /// <returns>Курс валюты к рублю</returns>
        public Task<decimal> GetRate(string code);

        /// <summary>
        /// Получает курс указанной валюты на соответствующую дату относительно рубля
        /// </summary>
        /// <param name="code">Трехбуквенный код валюты.</param>
        /// <param name="dateTime">Дата, на которую требуется получить курс.</param>
        /// <returns>Курс валюты к рублю на указанную дату</returns>
        public Task<decimal> GetRateByDate(string code, DateTime dateTime);
    }
}