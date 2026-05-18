using Dadata;
using Dadata.Model;
using Microsoft.EntityFrameworkCore;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System.Configuration;
using IO.Swagger;

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
        private readonly Client _client;
        private readonly AppDbContext _db;
      
        public TINService(AppDbContext db, HttpClient httpClient)
        {
            _apiKey = ConfigurationManager.AppSettings["DaDataApiKey"];
            _secretKey = ConfigurationManager.AppSettings["DaDataSecretKey"];
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiLink"]);
            _client = new Client(httpClient);
            _db = db;
        }

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
        public async Task<Customer> FindCustomerWithTIN(string tIN)
        {
            var customer = await _db.Customers
                .AsNoTracking()
                .Include(x => x.Address)
                .FirstOrDefaultAsync(x => x.TIN == tIN);

            return customer;
        }

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

        public async Task<string> CheckCompanyOnBlackList(string tIN)
        {
            Search company = await _client.SearchAsync(tIN, null, null, null, null, 0);

            var message = string.Empty;
            // является ли компания контрагентом
            if (company.Data.Any())
            {
                var companyId = company.Data.First().Id;
                var info = await _client.DetailInfoAsync(companyId);
                var signs = info.Signs;

                if (Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == "ru")
                {
                    message = $"Внимание, компания: {info.Info.First().NameOrg}, с ИНН: {tIN}, является контрагентом:\n";
                    message += string.Join("\n ", signs.Select(x => x.SignRus));
                }
                else
                {
                    message = $"Attention, the company: {info.Info.First().NameOrg}, with INN: {tIN}, is a counterparty:\n";
                    message += string.Join("\n ", signs.Select(x => x.SignEng));
                }

                return message;
            }
            return message;
        }
    }
}
