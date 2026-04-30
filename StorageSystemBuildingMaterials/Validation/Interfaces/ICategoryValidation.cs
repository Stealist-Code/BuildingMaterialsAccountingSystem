using System;

namespace StorageSystemBuildingMaterials.Validation.Interfaces
{
    /// <summary>
    /// Интерфейс для валидации категории
    /// </summary>
    public interface ICategoryValidation
    {
        /// <summary>
        /// Проверяет название категории на валидность
        /// </summary>
        /// <param name="name"></param>
        public void Validate(string name);
    }
}
