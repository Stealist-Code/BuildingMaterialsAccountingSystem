namespace StorageSystemBuildingMaterials.HelperClasses.Interfaces
{
    /// <summary>
    /// Интерфейс для хэширования
    /// </summary>
    public interface IHashService
    {
        /// <summary>
        /// Получить хэш
        /// </summary>
        /// <param name="input">Пароль</param>
        /// <returns>Хэш</returns>
        public string GetHash(string input);

        /// <summary>
        /// Проверить пароль на совпадение
        /// </summary>
        /// <param name="inputPassword">Пароль-1</param>
        /// <param name="storedHash">Пароль-2</param>
        /// <returns>true или false</returns>
        public bool VerifyPassword(string inputPassword, string passwordHashInDB);
    }
}