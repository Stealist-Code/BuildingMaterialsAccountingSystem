using StorageSystemBuildingMaterials.Services.Interfaces;
using System.Text.Json;

/// <summary>
/// Сервис для получения курсов валют через API
/// </summary>
public class CurrencyService : ICurrencyService
{
    private readonly HttpClient _http;

    public CurrencyService(HttpClient http)
    {
        _http = http;
    }

    /// <summary>
    /// Получает курс выбранной валюты относительно рубля
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    public async Task<decimal> GetRate(string code)
    {
        if (code == "RUB")
        {
            return 1;
        }
        var json = await _http.GetStringAsync("https://www.cbr-xml-daily.ru/daily_json.js");

        using var doc = JsonDocument.Parse(json);

        return doc.RootElement
            .GetProperty("Valute")
            .GetProperty(code)
            .GetProperty("Value")
            .GetDecimal();
    }
}