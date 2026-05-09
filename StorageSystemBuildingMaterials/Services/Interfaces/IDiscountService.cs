using StorageSystemBuildingMaterials.Models;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    public interface IDiscountService
    {
        public Task<ProductState> CreateProductState();
        public Task<StateRule> CreateStateRule();
    }
}
