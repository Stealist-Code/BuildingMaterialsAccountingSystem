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
        private readonly ISupplyService _supplyService;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public DiscountService(AppDbContext db, ISupplyService supplyService)
        {
            _db = db;
            _supplyService = supplyService;
        }

        public async Task<ProductState> CreateProductState()
        {
            var productState = await _db.ProductStates
                    .AsNoTracking()
                    .Include(x => x.StateRule)
                    .FirstOrDefaultAsync(x => x.StateRule.Discount == 30m && x.StateRule.DaysBeforeDiscount == 14);

            if (productState is null)
            {
                var stateRule = await CreateStateRule();
                productState = new ProductState()
                {
                    StateRuleId = stateRule.Id,
                    StateRule = stateRule
                };
                await _db.ProductStates.AddAsync(productState);
                await _db.SaveChangesAsync();
            }
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
