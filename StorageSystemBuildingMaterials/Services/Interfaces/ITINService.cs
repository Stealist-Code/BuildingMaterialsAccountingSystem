using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    public interface ITINService
    {
        public Task<CustomerDto> GetInfoCustomer(string tIN);

        public Task<Customer> FindCustomerWithTIN(string tIN);

        public Task<string> CheckCompanyOnBlackList(string tIN);
    }
}
