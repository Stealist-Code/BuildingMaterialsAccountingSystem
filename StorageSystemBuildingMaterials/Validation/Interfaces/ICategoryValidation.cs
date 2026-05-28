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
        /// <param name="name">Название категории</param>
        /// <exception cref="Exception">Пустое название категории</exception>
        public void Validate(string name);
    }
}
