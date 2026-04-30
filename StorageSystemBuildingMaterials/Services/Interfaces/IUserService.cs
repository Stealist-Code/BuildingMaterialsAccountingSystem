using StorageSystemBuildingMaterials.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с пользователями
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Получить список всех пользователей
        /// </summary>
        /// <returns></returns>
        public Task<List<User>> GetAllUsers();
    }
}