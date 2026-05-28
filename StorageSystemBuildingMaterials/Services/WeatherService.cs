using IO.Swagger;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System.Text.Json;

namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с погодой через API 
    /// </summary>
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

        private string GetWeatherTextRus(int code)
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

        private string GetWeatherTextEng(int code)
        {
            switch (code)
            {
                case 0:
                    return "Clear sky";

                case 1:
                    return "Mainly clear";

                case 2:
                    return "Partly cloudy";

                case 3:
                    return "Overcast";

                case 45:
                    return "Fog";

                case 48:
                    return "Fog with rime deposit";

                case 51:
                    return "Light drizzle";

                case 53:
                    return "Moderate drizzle";

                case 55:
                    return "Dense drizzle";

                case 56:
                    return "Light freezing drizzle";

                case 57:
                    return "Dense freezing drizzle";

                case 61:
                    return "Slight rain";

                case 63:
                    return "Moderate rain";

                case 65:
                    return "Heavy rain";

                case 66:
                    return "Light freezing rain";

                case 67:
                    return "Heavy freezing rain";

                case 71:
                    return "Slight snowfall";

                case 73:
                    return "Moderate snowfall";

                case 75:
                    return "Heavy snowfall";

                case 77:
                    return "Snow grains";

                case 80:
                    return "Slight rain showers";

                case 81:
                    return "Moderate rain showers";

                case 82:
                    return "Violent rain showers";

                case 85:
                    return "Slight snow showers";

                case 86:
                    return "Heavy snow showers";

                case 95:
                    return "Thunderstorm: Slight or moderate";

                case 96:
                    return "Thunderstorm with slight hail";

                case 99:
                    return "Thunderstorm with heavy hail";

                default:
                    return "Unknown";
            }
        }

        /// <summary>
        /// Метод для расшифровки кода погоды на текст (русский/английский язык)
        /// </summary>
        /// <param name="code">Код погоды</param>
        /// <returns>Описание погоды</returns>
        public string GetWeatherText(int code)
        {
            if (Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == "ru")
            {
                return GetWeatherTextRus(code);
            }
            else
            {
                return GetWeatherTextEng(code);
            }
        }
    }
}
