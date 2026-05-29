using Microsoft.EntityFrameworkCore;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.Models;

namespace StorageSystemBuildingMaterials.HelperClasses
{
    /// <summary>
    /// Класс для работы со скидками
    /// </summary>
    public static class DiscountHelper
    {
        /// <summary>
        /// Метод для применения скидок
        /// </summary>
        /// <param name="db">база данных</param>
        /// <param name="supplyItem">поставки</param>
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

        /// <summary>
        /// Применяет скидки к списку товаров в поставке
        /// </summary>
        /// <param name="db">Контекст базы данных</param>
        /// <param name="supplyItems">Поставки, к которым необходимо применить скидки</param>
        /// <returns>Задача, представляющая асинхронную операцию</returns>
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
