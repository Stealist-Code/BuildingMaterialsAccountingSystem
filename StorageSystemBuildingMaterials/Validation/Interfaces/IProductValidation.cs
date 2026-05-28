using StorageSystemBuildingMaterials.Models;
using System;

namespace StorageSystemBuildingMaterials.Validation.Interfaces
{
    /// <summary>
    /// Интерфейс для валидации товара
    /// </summary>
    public interface IProductValidation
    {
        /// <summary>
        /// Проверяет товар на валидность
        /// </summary>
        /// <param name="product">Объект товара.</param>
        /// <exception cref="Exception">Название не заполнено, цена (остаток) отрицательная или категория не указана.</exception>
        public void Validate(Product product);
    }
}
