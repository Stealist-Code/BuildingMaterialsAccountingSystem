using StorageSystemBuildingMaterials.HelperClasses.Interfaces;
using System.Security.Cryptography;
using System.Text;

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
        /// <param name="input"></param>
        /// <returns></returns>
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
        /// <param name="inputPassword"></param>
        /// <param name="storedHash"></param>
        /// <returns></returns>
        public bool VerifyPassword(string inputPassword, string passwordHashInDB)
        {
            var hashOfInput = GetHash(inputPassword);
            return hashOfInput == passwordHashInDB;
        }
    }
}