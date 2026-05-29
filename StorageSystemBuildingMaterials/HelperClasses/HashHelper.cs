namespace StorageSystemBuildingMaterials.HelperClasses
{
    /// <summary>
    /// Kласс для хэширования паролей с помощью алгоритма SHA256.
    /// </summary>
    public class HashHelper : IHashService
    {
        /// <summary>
        /// Преобразует пароль в хэш
        /// </summary>
        /// <param name="input">Пароль</param>
        /// <returns>Хэш</returns>
        public string GetHash(string input)
        {
            using var sha256 = SHA256.Create();

            var bytes = Encoding.UTF8.GetBytes(input);
            var hash = sha256.ComputeHash(bytes);

            var sb = new StringBuilder();

            foreach (var b in hash)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Метод, который проверяет пароли на совпадение
        /// </summary>
        /// <param name="inputPassword">Пароль-1</param>
        /// <param name="storedHash">Пароль-2</param>
        /// <returns>true или false</returns>
        public bool VerifyPassword(string inputPassword, string passwordHashInDB)
        {
            var hashOfInput = GetHash(inputPassword);
            return hashOfInput == passwordHashInDB;
        }
    }
}