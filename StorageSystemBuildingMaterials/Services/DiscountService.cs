using Microsoft.EntityFrameworkCore;
using NLog;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы со скидками
    /// </summary>
    public class DiscountService : IDiscountService
    {
        private readonly AppDbContext _db;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public DiscountService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<ProductState> CreateProductState()
        {
            var stateRule = await CreateStateRule();

            var productState = new ProductState
            {
                Id = Guid.NewGuid(),
                StateRuleId = stateRule.Id
            };

            return productState;
        }

        public async Task<StateRule> CreateStateRule()
        {
            var stateRule = await _db.StateRules
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Discount == 30m && x.DaysBeforeDiscount == 14);

            if (stateRule is null)
            {
                stateRule = new StateRule()
                {
                    DaysBeforeDiscount = 14,
                    Discount = 30m
                };
                await _db.StateRules.AddAsync(stateRule);
                await _db.SaveChangesAsync();
            }
            return stateRule;
        }
    }
}
