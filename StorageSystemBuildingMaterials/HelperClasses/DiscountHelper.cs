using Microsoft.EntityFrameworkCore;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.Models;

namespace StorageSystemBuildingMaterials.HelperClasses
{
    public static class DiscountHelper
    {
        public static async Task ApplyDiscount(AppDbContext db, SupplyItem supplyItem)
        {
            if (supplyItem is not null && supplyItem.ExpirationDate > DateTime.UtcNow)
            {
                var productState = await db.ProductStates
                    .Include(x => x.StateRule)
                    .FirstOrDefaultAsync(x => x.Id == supplyItem.ProductStateId);

                var quantityDays = (supplyItem.ExpirationDate - supplyItem.ReceivedDate).Days;
                if (quantityDays > 0 && quantityDays <= productState.StateRule.DaysBeforeDiscount)
                {
                    supplyItem.PurchasePrice *= (1 - productState.StateRule.Discount / 100);
                }
            }
        }

        public static async Task ApplyDiscount(AppDbContext db, ICollection<SupplyItem> supplyItems)
        {
            if (supplyItems is null || supplyItems.Count == 0)
            {
                return;
            }

            foreach (var supplyItem in supplyItems)
            {
                await ApplyDiscount(db, supplyItem);
            }
        }
    }
}
