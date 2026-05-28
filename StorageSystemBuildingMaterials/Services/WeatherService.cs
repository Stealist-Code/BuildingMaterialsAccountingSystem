using StorageSystemBuildingMaterials.Services.Interfaces;
using System.Text.Json;

namespace StorageSystemBuildingMaterials.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _weatherHttps = "https://api.open-meteo.com/v1/";

        public WeatherService(HttpClient http)
        {
            _httpClient = http;
        }

        /// <summary>
        /// Метод для получения кода погоды и температуры
        /// </summary>
        /// <param name="latitude">Широта</param>
        /// <param name="longitude">Долгота</param>
        /// <returns>Возвращает кортеж с кодом погоды и температурой</returns>
        public async Task<(int? weather_code, double temperature)> GetWeatherCodeAndTemperature(double latitude, double longitude)
        {
            var url = $"{_weatherHttps}forecast?latitude={latitude}&longitude={longitude}&current=weather_code,temperature_2m";
            var json = await _httpClient.GetStringAsync(url);

            using var doc = JsonDocument.Parse(json);

            var weather_code = doc.RootElement
                .GetProperty("current")
                .GetProperty("weather_code")
                .GetInt32();

            var temperature = doc.RootElement
                .GetProperty("current")
                .GetProperty("temperature_2m")
                .GetDouble();

            return (weather_code, temperature);
        }
    }
}
