using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.EntityFrameworkCore;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System.Globalization;
using System.Text.Json;
using System.Xml.Linq;

/// <summary>
/// Сервис для получения курсов валют через API
/// </summary>
public class CurrencyService : ICurrencyService
{
    private readonly HttpClient _httpClient;
    private readonly AppDbContext _db;

    public CurrencyService(HttpClient http)
    {
        _httpClient = http;
    }

    /// <summary>
    /// Получает курс указанной валюты относительно рубля
    /// </summary>
    /// <param name="code">Трехбуквенный код валюты.</param>
    /// <returns></returns>
    public async Task<decimal> GetRate(string code)
    {
        if (code == "RUB")
        {
            return 1;
        }
        var json = await _httpClient.GetStringAsync("https://www.cbr-xml-daily.ru/daily_json.js");

        using var doc = JsonDocument.Parse(json);

        return doc.RootElement
            .GetProperty("Valute")
            .GetProperty(code)
            .GetProperty("Value")
            .GetDecimal();
    }

    /// <summary>
    /// Получает курс указанной валюты на соответствующую дату относительно рубля
    /// </summary>
    /// <param name="code">Трехбуквенный код валюты.</param>
    /// <param name="dateTime">Дата, на которую требуется получить курс.</param>
    /// <returns></returns>
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

    /// <summary>
    /// Меняет курс валюты поставок 
    /// </summary>
    /// <param name="code">Трехбуквенный код валюты</param>
    /// <param name="productId">Id товара</param>
    /// <returns></returns>
    public async Task PriceChangeSuppliesInDatabase(string code, Guid productId)
    {
        var supplies = await _db.SupplyItems
            .AsNoTracking()
            .Where(x => x.ProductId == productId)
            .ToListAsync();

        foreach (var supply in supplies)
        {
            supply.ExchangeRateOnDayPurchace = await GetRateByDate(code, supply.ReceivedDate);
        }
    }
}
