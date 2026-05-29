namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для авторизации
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Проверяет введенные данные при входе в аккаунт
        /// </summary>
        /// <param name="authenticateRequest">Запрос, содержащий email и пароль пользователя</param>
        /// <returns>Данные аутентифицированного пользователя (<see cref="User"/>)</returns>
        public Task<User?> Authenticate(AuthenticateRequest authenticateRequest);

        /// <summary>
        /// Метод, который создает пользователя
        /// </summary>
        /// <param name="request">Запрос, содержащий данные для регистрации</param>
        /// <exception cref="Exception">Выбрасывается, если роль "Worker" не найдена в базе данных или email не существует</exception>
        public Task Register(RegisterRequest request);
    }
}