using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    public interface ITINService
    {
        public Task<CustomerDto> GetInfoCustomer(string tIN);

        public Task<Customer> FindCustomerWithTIN(string tIN);

        public Task<string> CheckCompanyOnBlackList(string tIN);

        /// <summary>
        /// Метод для получения координатов по адресу
        /// </summary>
        /// <param name="address">Адрес</param>
        /// <returns>Возвращает кортеж с широтой и долготой</returns>
        public Task<(double latitude, double longitude)> GetCoordinates(string address);
    }
}
