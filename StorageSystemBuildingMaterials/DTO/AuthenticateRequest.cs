using System;
using System.Collections.Generic;
using System.Text;

namespace StorageSystemBuildingMaterials.DTO
{
    /// <summary>
    /// Данные для авторизации пользователя
    /// </summary>
    public class AuthenticateRequest
    {
        /// <summary>
        /// Электронная почта для авторизации
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Пароль для авторизации
        /// </summary>
        public string Password { get; set; }
    }
}
