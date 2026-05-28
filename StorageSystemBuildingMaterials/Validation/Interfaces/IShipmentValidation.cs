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
        /// Валидация создания отгрузки
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в отгрузке.</param>
        /// <exception cref="Exception">Если address равен null, или items равен null или пуст.</exception>
        public void ValidateCreateShipment(Address address, List<ShipmentItem> items);

        /// <summary>
        /// Проверка, хватает ли товаров на складе
        /// </summary>
        /// <param name="productDict">Словарь товаров с их ID.</param>
        /// <param name="items">Список товаров в отгрузке.</param>
        /// <exception cref="Exception">Если товар не найден, количество <= 0 или остатка на складе недостаточно.</exception>
        public void ValidateProductsAvailability(Dictionary<Guid, Product> productDict, List<ShipmentItem> items);


        /// <summary>
        /// Проверка заполненности адреса и наличия товаров в корзине
        /// </summary>
        /// <param name="address">Адрес для проверки.</param>
        /// <param name="cart">Корзина с товарами.</param>
        /// <exception cref="Exception">Если поля адреса (страна, город, улица, дом) не заполнены, или корзина пуста.</exception>
        public void ValidateShipmentFields(Address address, List<CartItemDto> cart);

        /// <summary>
        /// Проверка добавления товара в корзину
        /// </summary>
        /// <param name="product">Добавляемый товар.</param>
        /// <param name="quantity">Запрашиваемое количество.</param>
        /// <param name="existing">Существующая позиция в корзине (может быть null).</param>
        /// <exception cref="Exception">Если товар не найден, количество <= 0, запрошено больше остатка, или общее количество превышает остаток.</exception>
        public void ValidateAddToCart(ProductDto product, int quantity, CartItemDto existing);

        /// <summary>
        /// Валидация стоимости оценки на продажу
        /// </summary>
        /// <param name="price">Цена для проверки.</param>
        /// <exception cref="Exception">Если price меньше или равна 0.</exception>
        public void ValidatePrice(decimal price);
    }
}