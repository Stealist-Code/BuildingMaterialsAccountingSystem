using System;

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
        /// <param name="input"></param>
        /// <returns></returns>
        public string GetHash(string input);

        /// <summary>
        /// Проверить пароль на совпадение
        /// </summary>
        /// <param name="inputPassword"></param>
        /// <param name="passwordHashInDB"></param>
        /// <returns></returns>
        public bool VerifyPassword(string inputPassword, string passwordHashInDB);
    }
}