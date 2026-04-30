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
        /// <param name="product"></param>
        public void Validate(Product product);
    }
}
