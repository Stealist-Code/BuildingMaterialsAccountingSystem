using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using System;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для авторизации
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Авторизирует пользователя
        /// </summary>
        /// <param name="authenticateRequest"></param>
        /// <returns></returns>
        public Task<User?> Authenticate(AuthenticateRequest authenticateRequest);

        /// <summary>
        /// Регистрирует пользователя
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task Register(RegisterRequest request);
    }
}