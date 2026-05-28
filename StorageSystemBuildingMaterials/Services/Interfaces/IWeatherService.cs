namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с погодой
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        /// Метод для получения кода погоды и температуры
        /// </summary>
        /// <param name="latitude">Широта</param>
        /// <param name="longitude">Долгота</param>
        /// <returns>Возвращает кортеж с кодом погоды и температурой</returns>
        public Task<(int? weather_code, double temperature)> GetWeatherCodeAndTemperature(double latitude, double longitude);
    }
}
