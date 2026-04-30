using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Validation.Interfaces;
using System;

namespace StorageSystemBuildingMaterials.Validation
{
    /// <summary>
    /// Класс валидации отгрузки, вся логика валидации, связанная с отгрузками должна быть здесь!!!
    /// </summary>
    public class ShipmentValidation : IShipmentValidation
    {
        /// <summary>
        /// Валидация создания отгрузки
        /// </summary>
        /// <param name="address"></param>
        /// <param name="items"></param>
        /// <exception cref="Exception"></exception>
        public void ValidateCreateShipment(Address address, List<ShipmentItem> items)
        {
            if (address is null)
            {
                throw new Exception("AddressIsRequired");
            }

            if (items is null || !items.Any())
            {
                throw new Exception("ShipmentItemsEmpty");
            }
        }

        /// <summary>
        /// Валидация стоимости оценки на продажу
        /// </summary>
        /// <param name="price"></param>
        /// <exception cref="Exception"></exception>
        public void ValidatePrice(decimal price)
        {
            if (price <= 0)
            {
                throw new Exception("InvalidTotalPrice");
            }
        }

        /// <summary>
        /// Проверка, хватает ли товаров на складе
        /// </summary>
        /// <param name="productDict"></param>
        /// <param name="items"></param>
        /// <exception cref="Exception"></exception>
        public void ValidateProductsAvailability(Dictionary<Guid, Product> productDict, List<ShipmentItem> items)
        {
            foreach (var item in items)
            {
                if (!productDict.TryGetValue(item.ProductId, out var product))
                {
                    throw new Exception("ProductWithIdNotFound");
                }

                if (item.Quantity <= 0)
                {
                    throw new Exception("InvalidQuantity");
                }

                if (product.CurrentStock < item.Quantity)
                {
                    throw new Exception("QuantityOfProductNotEnough");
                }
            }
        }

        /// <summary>
        /// Проверка заполненности адреса и наличия товаров в корзине
        /// </summary>
        /// <param name="address"></param>
        /// <param name="cart"></param>
        /// <exception cref="Exception"></exception>
        public void ValidateShipmentFields(Address address, List<CartItemDto> cart)
        {
            if (string.IsNullOrWhiteSpace(address.Country) || string.IsNullOrWhiteSpace(address.City) ||
                string.IsNullOrWhiteSpace(address.Street) || string.IsNullOrWhiteSpace(address.Building))
            {
                throw new Exception("RequiredFields");
            }

            if (cart is null || !cart.Any())
            {
                throw new Exception("NoProducts");
            }
        }

        /// <summary>
        /// Проверка добавления товара в корзину
        /// </summary>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        /// <param name="existing"></param>
        /// <exception cref="Exception"></exception>
        public void ValidateAddToCart(ProductDto product, int quantity, CartItemDto existing)
        {
            if (product is null)
            {
                throw new Exception("ProductNotFound");
            }

            if (quantity <= 0)
            {
                throw new Exception("QuantityZero");
            }

            if (quantity > product.CurrentStock)
            {
                throw new Exception("NotEnoughStock");
            }

            if (existing != null && existing.Quantity + quantity > product.CurrentStock)
            {
                throw new Exception("TotalExceedsStock");
            }
        }
    }
}