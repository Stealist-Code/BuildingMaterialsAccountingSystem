namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для получения курсов валют через API
    /// </summary>
    public class CurrencyService : ICurrencyService
    {
        private readonly HttpClient _httpClient;
        private Dictionary<string, decimal> _currentRatesCache = new();
        private DateTime? _currentRatesCacheTime;
        private static readonly TimeSpan _cacheDuration = TimeSpan.FromHours(1);

        public CurrencyService(HttpClient http)
        {
            _httpClient = http;
        }

        /// <summary>
        /// Получает курс указанной валюты относительно рубля (с кэшированием на 1 час)
        /// </summary>
        /// <param name="code">Трехбуквенный код валюты.</param>
        /// <returns>Курс валюты к рублю</returns>
        public async Task<decimal> GetRate(string code)
        {
            if (code == "RUB")
            {
                return 1;
            }

            if (_currentRatesCacheTime.HasValue
                && DateTime.UtcNow - _currentRatesCacheTime < _cacheDuration
                && _currentRatesCache.TryGetValue(code, out var cachedRate))
            {
                return cachedRate;
            }

            var json = await _httpClient.GetStringAsync("https://www.cbr-xml-daily.ru/daily_json.js");

            using var doc = JsonDocument.Parse(json);

            var valutes = doc.RootElement.GetProperty("Valute");
            var newCache = new Dictionary<string, decimal>();

            foreach (var property in valutes.EnumerateObject())
            {
                if (property.Value.TryGetProperty("Value", out var valueElement))
                {
                    newCache[property.Name] = valueElement.GetDecimal();
                }
            }

            _currentRatesCache = newCache;
            _currentRatesCacheTime = DateTime.UtcNow;

            return newCache.TryGetValue(code, out var rate) ? rate : 0;
        }

        /// <summary>
        /// Получает курс указанной валюты на соответствующую дату относительно рубля
        /// </summary>
        /// <param name="code">Трехбуквенный код валюты.</param>
        /// <param name="dateTime">Дата, на которую требуется получить курс.</param>
        /// <returns>Курс валюты к рублю на указанную дату</returns>
        public async Task<decimal> GetRateByDate(string code, DateTime dateTime)
        {
            var dateStr = dateTime.ToString("dd/MM/yyyy");
            var url = $"https://www.cbr.ru/scripts/XML_daily.asp?date_req={dateStr}";

            var xml = await _httpClient.GetStringAsync(url);

            var doc = XDocument.Parse(xml);

            var valute = doc.Descendants("Valute")
                .FirstOrDefault(v => v.Element("CharCode")?.Value == code.ToUpper());

            if (valute == null)
            {
                return 0;
            }

            var valueStr = valute.Element("Value")!.Value;
            var nominalStr = valute.Element("Nominal")!.Value;

            if (!decimal.TryParse(valueStr, new CultureInfo("ru-RU"), out decimal value))
            {
                return 0;
            }

            if (!decimal.TryParse(nominalStr, CultureInfo.InvariantCulture, out decimal nominal))
            {
                return 0;
            }

            if (nominal == 0)
            {
                return 0;
            }

            return value / nominal;
        }
    }
}
