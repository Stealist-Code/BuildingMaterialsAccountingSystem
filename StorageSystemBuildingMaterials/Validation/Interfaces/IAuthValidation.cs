using StorageSystemBuildingMaterials.DTO;
using System;

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
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsValidEmail(string email);

        /// <summary>
        /// Проверяет запрос регистрации
        /// </summary>
        /// <param name="request"></param>
        public void ValidateRegisterRequest(RegisterRequest request);

        /// <summary>
        /// Проверяет 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void ValidateLogin(AuthenticateRequest authenticateRequest);

        /// <summary>
        /// Проверяет пароль
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatePassword(string password);
    }
}
