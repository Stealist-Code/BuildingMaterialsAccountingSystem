namespace StorageSystemBuildingMaterials.Validation
{
    /// <summary>
    /// Класс валидации категории, вся логика валидации, связанная с категориями должна быть здесь!!!
    /// </summary>
    public class CategoryValidation : ICategoryValidation
    {
        /// <summary>
        /// Проверяет заполнено ли поле название категории
        /// </summary>
        /// <param name="name">Название категории</param>
        /// <exception cref="Exception">Пустое название категории</exception>
        public void Validate(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("EmptyCategoryName");
            }
        }
    }
}