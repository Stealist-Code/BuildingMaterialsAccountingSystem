namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с пользователями. Логика с БД, связанная с пользователями!!!
    /// </summary>
    public class UserService : IUserService
    {
        private readonly AppDbContext _db;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="db">бд</param>
        public UserService(AppDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Возвращает всех пользователей с их ролями
        /// </summary>
        /// <returns>Список пользователей</returns>
        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                return await _db.Users
                                .Include(x => x.Role)
                                .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка получения списка пользователей");
                throw;
            }
        }
    }
}