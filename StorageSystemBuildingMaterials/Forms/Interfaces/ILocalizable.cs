using System;

namespace StorageSystemBuildingMaterials.Forms.Interfaces
{
    /// <summary>
    /// Интерфейс для поддержки локализации формы или контролов
    /// </summary>
    public interface ILocalizable
    {
        /// <summary>
        /// Применяет локализованные значения к элементам интерфейса
        /// </summary>
        public void ApplyLocalization();
    }
}
