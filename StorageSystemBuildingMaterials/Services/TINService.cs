using Dadata;
using Dadata.Model;
using Microsoft.EntityFrameworkCore;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System.Configuration;
using System.Net.Http.Json;
using System.Text.Json;

namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с ИНН через API
    /// </summary>
    public class TINService : ITINService
    {
        private readonly string _apiKey;
        private readonly string _secretKey;
        private readonly HttpClient _httpClient;
        private readonly AppDbContext _db;
      
        public TINService(AppDbContext db, HttpClient httpClient)
        {
            _apiKey = ConfigurationManager.AppSettings["DaDataApiKey"];
            _secretKey = ConfigurationManager.AppSettings["DaDataSecretKey"];
            _httpClient = httpClient;
            _db = db;
        }

        /// <summary>
        /// Возвращает информацию о клиенте по ИНН. Если клиент не найден, создаёт его.
        /// </summary>
        /// <param name="tIN">ИНН клиента.</param>
        /// <returns>Покупатель DTO</returns>
        public async Task<CustomerDto> GetInfoCustomer(string tIN)
        {
            var customer = await FindCustomerWithTIN(tIN);

            if (customer is null)
            {
                customer = await CreateCustomer(tIN);
                if (customer is null)
                {
                    return null;
                }
            }

            return new CustomerDto()
            {
                TIN = customer.TIN,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                MiddleName = customer.MiddleName,
                Country = customer.Address.Country,
                Region = customer.Address.Region,
                City = customer.Address.City,
                Street = customer.Address.Street,
                Building = customer.Address.Building,
                FullAddress = customer.Address.FullAddress,
            };
        }

        /// <summary>
        /// Находит клиента по ИНН вместе с адресом.
        /// </summary>
        /// <param name="tIN">ИНН клиента.</param>
        /// <returns>Покупатель</returns>
        public async Task<Customer> FindCustomerWithTIN(string tIN)
        {
            var customer = await _db.Customers
                .AsNoTracking()
                .Include(x => x.Address)
                .FirstOrDefaultAsync(x => x.TIN == tIN);

            return customer;
        }

        /// <summary>
        /// Создаёт клиента.
        /// </summary>
        /// <param name="tIN">ИНН клиента.</param>
        /// <returns>Созданный клиент или null, если ИНН не найден в API.</returns>
        private async Task<Customer> CreateCustomer(string tIN)
        {
            var apiSuggest = new SuggestClientAsync(_apiKey);
            var apiClean = new CleanClientAsync(_apiKey, _secretKey);
            var company = await apiSuggest.FindParty(tIN);

            if (company.suggestions.Count == 0)
            {
                return null;
            }

            var companyData = company.suggestions[0].data;
            var fioData = await apiClean.Clean<Fullname>(companyData.management.name);
            var addressData = companyData.address;

            var address = new Models.Address()
            {
                Id = Guid.NewGuid(),
                Country = addressData.data.country,
                Region = addressData.data.region,
                City = addressData.data.city,
                Street = addressData.data.street,
                Building = addressData.data.house,
            };

            var customer = new Customer()
            {
                Id = Guid.NewGuid(),
                TIN = tIN,
                FirstName = fioData.name,
                LastName = fioData.surname,
                MiddleName = fioData.patronymic,
                AddressId = address.Id,
                Address = address,
            };

            await _db.Addresses.AddAsync(address);
            await _db.Customers.AddAsync(customer);
            await _db.SaveChangesAsync();

            return customer;
        }

        /// <summary>
        /// Проверяет компанию по ИНН в списке недобросовестных контрагентов.
        /// </summary>
        /// <param name="tIN">ИНН компании.</param>
        /// <returns>Сообщение с признаками нарушений на русском или английском языке, либо пустая строка.</returns>
        public async Task<string> CheckCompanyOnBlackList(string tIN)
        {
            var baseUrl = "http://www.cbr.ru/warninglistapi/";

            var urlForSearch = $"{baseUrl}Search?sphrase={tIN}&page=0";
            var resultSearch = await _httpClient.GetStringAsync(urlForSearch);

            using var docSearch = JsonDocument.Parse(resultSearch);
            var rootSearch = docSearch.RootElement;

            var message = string.Empty;

            if (rootSearch.TryGetProperty("Data", out var dataElement) && dataElement.GetArrayLength() > 0)
            {
                var companyId = dataElement[0].GetProperty("id").GetInt32();

                var urlDetailInfo = $"{baseUrl}DetailInfo?id={companyId}";
                var resultDetail = await _httpClient.GetStringAsync(urlDetailInfo);

                using var doc = JsonDocument.Parse(resultDetail);
                var rootElem = doc.RootElement;

                var signs = rootElem.GetProperty("Signs");

                if (Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == "ru")
                {
                    message = $"Внимание, компания с ИНН: {tIN}, является контрагентом:\n";
                    message += string.Join("\n ", signs.EnumerateArray().Select(x => x.GetProperty("signRus").GetString()));
                }
                else
                {
                    message = $"Attention, the company with INN: {tIN}, is a counterparty:\n";
                    message += string.Join("\n ", signs.EnumerateArray().Select(x => x.GetProperty("signEng").GetString()));
                }
                return message;
            }
            return message;
        }

        /// <summary>
        /// Метод для получения координатов по адресу
        /// </summary>
        /// <param name="address">Адрес</param>
        /// <returns>Возвращает кортеж с широтой и долготой</returns>
        public async Task<(double latitude, double longitude)> GetCoordinates(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                return (0, 0);
            }

            var api = new CleanClientAsync(_apiKey, _secretKey);
            var result = await api.Clean<Dadata.Model.Address>(address);
            
            if (!double.TryParse(result.geo_lat, out var lat) || !double.TryParse(result.geo_lon, out var lon))
            {
                return (0, 0);
            }

            return (lat, lon);
        }
    }
}
