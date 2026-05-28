using StorageSystemBuildingMaterials.DTO;

namespace StorageSystemBuildingMaterials.Validation.Interfaces
{
    /// <summary>
    /// Интерфейс для валидации авторизации
    /// </summary>
    public interface IAuthValidation
    {
        /// <summary>
        /// Проверяет почту на валидность
        /// </summary>
        /// <param name="email">Email.</param>
        /// <returns>true, если email валиден, иначе false.</returns>
        public bool IsValidEmail(string email);

        /// <summary>
        /// Проверяет запрос регистрации
        /// </summary>
        /// <param name="request">Запрос регистрации.</param>
        /// <exception cref="Exception">Ошибка валидации (незаполненные поля, невалидный email, слабый пароль, несовпадение паролей).</exception>
        public void ValidateRegisterRequest(RegisterRequest request);

        /// <summary>
        /// Проверяет 
        /// </summary>
        /// <param name="authenticateRequest">Запрос аутентификации.</param>
        /// <exception cref="Exception">Ошибка валидации (незаполненные поля или невалидный email).</exception>
        public void ValidateLogin(AuthenticateRequest authenticateRequest);

        /// <summary>
        /// Проверяет пароль
        /// </summary>
        /// <param name="password">Пароль для проверки.</param>
        /// <returns>true, если пароль соответствует требованиям, иначе false.</returns>
        public bool ValidatePassword(string password);
    }
}
