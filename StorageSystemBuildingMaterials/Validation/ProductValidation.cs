using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Validation.Interfaces;
using System;

namespace StorageSystemBuildingMaterials.Validation
{
    /// <summary>
    /// Класс валидации товара, вся логика валидации, связанная с товарами должна быть здесь!!!
    /// </summary>
    public class ProductValidation : IProductValidation
    {
        /// <summary>
        /// Проверка на заполнение поля имени, а также проверка на корректную цену закупки
        /// </summary>
        /// <param name="product"></param>
        /// <exception cref="Exception"></exception>
        public void Validate(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new Exception("ProductNameRequired");
            }

            if (product.PurchasePrice < 0)
            {
                throw new Exception("InvalidPrice");
            }

            if (product.CategoryId == Guid.Empty)
            {
                throw new Exception("CategoryRequired");
            }
        }
    }
}