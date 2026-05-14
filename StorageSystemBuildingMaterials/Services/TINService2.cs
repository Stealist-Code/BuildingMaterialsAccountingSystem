using Dadata;
using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System.Configuration;
using System.Text;
using System.Text.Json;

namespace StorageSystemBuildingMaterials.Services
{
    public class TINService2 : ITINService
    {
        private readonly string _key;
        private readonly HttpClient _httpClient;

        public TINService2(HttpClient httpClient)
        {
            _key = ConfigurationManager.AppSettings["FnsApiKey"];
            _httpClient = httpClient;
        }



        public async Task<CustomerDto> GetInfoCustomer(string tIN)
        {
            var json = await _httpClient.GetStringAsync($"https://api-fns.ru/api/check?req={tIN}&key={_key}");
            MessageBox.Show(_key);
            await File.WriteAllTextAsync("D:\\Files\\Git\\BuildingMaterialsAccountingSystem\\FnsData.json", json, Encoding.UTF8);

            using var doc = JsonDocument.Parse(json);

            if (doc.RootElement.TryGetProperty("items", out var items))
            {
                var item = items[0].GetProperty("ЮЛ");
                //if (item.Name is null)
                //{
                //    return new CustomerDto();
                //}

                if (string.IsNullOrWhiteSpace(item.GetProperty("Негатив").ToString()))
                {
                    MessageBox.Show("Компания находится в черном списке");
                    return new CustomerDto();
                }

                return await GetCustomer(tIN);
            }



            MessageBox.Show(doc.RootElement.GetProperty("items")[0].GetProperty("ЮЛ").GetProperty("Позитив").ToString());
            return new CustomerDto(); //2311146207
        }


        private async Task<CustomerDto> GetCustomer(string tIN)
        {
            var json = await _httpClient.GetStringAsync($"https://api-fns.ru/api/egr?req={tIN}&key={_key}");
            using var doc = JsonDocument.Parse(json);

            if (doc.RootElement.TryGetProperty("items", out var items))
            {
                var item = items[0].GetProperty("ЮЛ");
                //if (item i null)
                //{
                //    return new CustomerDto();
                //}

                var addressJson = item.GetProperty("Адрес");
                var address = SplitAddress(addressJson);

                var customerFullName = item.GetProperty("Руководитель").GetProperty("ФИОПолн").ToString();
                var arrayCustomerFullName = SplitFullName(customerFullName);

                var customer = new Customer()
                {
                    Id = Guid.NewGuid(),
                    FirstName = arrayCustomerFullName[1],
                    LastName = arrayCustomerFullName[0],
                    MiddleName = arrayCustomerFullName[2],
                    Address = address,
                    AddressId = address.Id,
                };

                return new CustomerDto()
                {
                    TIN = item.GetProperty("ИНН").ToString(),
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    MiddleName = customer.MiddleName,
                    Country = address.Country,
                    Region = address.Region,
                    City = address.City,
                    Street = address.Street,
                    Building = address.Building,
                    FullAddress = address.FullAddress,
                };
            }
            return new CustomerDto();
        }

        private string[] SplitFullName(string fullName)
        {
            if (fullName is null)
            {
                return Array.Empty<string>();
            }

            var parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return parts;
        }

        private Address SplitAddress(JsonElement jsonElement)
        {
            return new Address()
            {
                Id = Guid.NewGuid(),
                Country = "Россия",
                Region = jsonElement.GetProperty("АдресДетали").GetProperty("Регион").GetProperty("Наим").ToString(),
                City = jsonElement.GetProperty("АдресДетали").GetProperty("Город").GetProperty("Наим").ToString(),
                Street = jsonElement.GetProperty("АдресДетали").GetProperty("Улица").GetProperty("Наим").ToString(),
                Building = jsonElement.GetProperty("АдресДетали").GetProperty("Дом").ToString(),
            };
        }
    }
}
