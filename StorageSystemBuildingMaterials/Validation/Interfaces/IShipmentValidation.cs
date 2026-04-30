using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using System;

namespace StorageSystemBuildingMaterials.Validation.Interfaces
{
    /// <summary>
    /// Интерфейс для валидации отгрузки
    /// </summary>
    public interface IShipmentValidation
    {
        /// <summary>
        /// Валидириует создание отгрузки
        /// </summary>
        /// <param name="address"></param>
        /// <param name="items"></param>
        public void ValidateCreateShipment(Address address, List<ShipmentItem> items);

        /// <summary>
        /// Валидирует хватает ли продукта на складе
        /// </summary>
        /// <param name="productDict"></param>
        /// <param name="items"></param>
        public void ValidateProductsAvailability(Dictionary<Guid, Product> productDict, List<ShipmentItem> items);


        /// <summary>
        /// Проверка полей отгрузки
        /// </summary>
        /// <param name="address"></param>
        /// <param name="cart"></param>
        public void ValidateShipmentFields(Address address, List<CartItemDto> cart);

        /// <summary>
        /// Проверка на возможность добавить товар в отгрузку
        /// </summary>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        /// <param name="existing"></param>
        public void ValidateAddToCart(ProductDto product, int quantity, CartItemDto existing);

        /// <summary>
        /// Проверка на правильную стоимость
        /// </summary>
        /// <param name="price"></param>
        public void ValidatePrice(decimal price);
    }
}