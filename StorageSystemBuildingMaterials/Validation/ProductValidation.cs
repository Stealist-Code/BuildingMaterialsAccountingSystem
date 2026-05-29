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
        /// <param name="product">Объект товара.</param>
        /// <exception cref="Exception">Название не заполнено, цена (остаток) отрицательная или категория не указана.</exception>
        public void Validate(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new Exception("ProductNameRequired");
            }

            if (product.CurrentStock < 0)
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