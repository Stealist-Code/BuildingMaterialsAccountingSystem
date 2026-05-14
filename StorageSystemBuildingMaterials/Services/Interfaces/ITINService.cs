using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    public interface ITINService
    {
        public Task<CustomerDto> GetInfoCustomer(string tIN);
    }
}
