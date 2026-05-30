namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с погодой через API 
    /// </summary>
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _weatherHttps = "https://api.open-meteo.com/v1/";

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="http">http</param>
        public WeatherService(HttpClient http)
        {
            _httpClient = http;
        }

        /// <summary>
        /// Метод для получения кода погоды и температуры
        /// </summary>
        /// <param name="latitude">Широта</param>
        /// <param name="longitude">Долгота</param>
        /// <returns>Кортеж с кодом погоды и температурой</returns>
        public async Task<(int weather_code, double temperature)> GetWeatherCodeAndTemperature(double latitude, double longitude)
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

        /// <summary>
        /// Метод для расшифровки кода погоды на текст
        /// </summary>
        /// <param name="code">Код погоды</param>
        /// <returns>Описание погоды</returns>
        public string GetWeatherText(int code)
        {
            switch (code)
            {
                case 0:
                    return "Ясно";

                case 1:
                    return "В основном ясно";

                case 2:
                    return "Переменная облачность";

                case 3:
                    return "Пасмурно";

                case 45:
                    return "Туман";

                case 48:
                    return "Туман с изморозью";

                case 51:
                    return "Слабая морось";

                case 53:
                    return "Умеренная морось";

                case 55:
                    return "Сильная морось";

                case 56:
                    return "Слабая переохлаждённая морось";

                case 57:
                    return "Сильная переохлаждённая морось";

                case 61:
                    return "Слабый дождь";

                case 63:
                    return "Умеренный дождь";

                case 65:
                    return "Сильный дождь";

                case 66:
                    return "Слабый переохлаждённый дождь";

                case 67:
                    return "Сильный переохлаждённый дождь";

                case 71:
                    return "Слабый снегопад";

                case 73:
                    return "Умеренный снегопад";

                case 75:
                    return "Сильный снегопад";

                case 77:
                    return "Снежная крупа";

                case 80:
                    return "Слабый ливень";

                case 81:
                    return "Умеренный ливень";

                case 82:
                    return "Сильный ливень";

                case 85:
                    return "Слабый снегопад с ливнем";

                case 86:
                    return "Сильный снегопад с ливнем";

                case 95:
                    return "Гроза";

                case 96:
                    return "Гроза с небольшим градом";

                case 99:
                    return "Гроза с сильным градом";

                default:
                    return "Неизвестно";
            }
        }
    }
}
