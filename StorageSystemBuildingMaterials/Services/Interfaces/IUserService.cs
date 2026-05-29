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
        /// <returns>Список пользователей</returns>
        public Task<List<User>> GetAllUsers();
    }
}