using Microsoft.EntityFrameworkCore;
using NLog;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.HelperClasses.Interfaces;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с авторизацией, вся логика работы с БД должна быть здесь!!!
    /// </summary>
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _db;
        private readonly IAuthValidation _authValidation;
        private readonly IHashService _hashService;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public AuthService(AppDbContext db, IAuthValidation authValidation, IHashService hashService)
        {
            _db = db;
            _authValidation = authValidation;
            _hashService = hashService;
        }

        /// <summary>
        /// Проверяет введенные данные при входе в аккаунт
        /// </summary>
        /// <param name="authenticateRequest">Запрос, содержащий email и пароль пользователя</param>
        /// <returns>Данные аутентифицированного пользователя (<see cref="User"/>)</returns>
        public async Task<User?> Authenticate(AuthenticateRequest authenticateRequest)
        {
            try
            {
                var emailToLower = authenticateRequest.Email.Trim().ToLower();

                _logger.Debug($"Поиск пользователя по email: {emailToLower}");

                var user = await _db.Users
                    .Include(x => x.Role)
                    .FirstOrDefaultAsync(x => x.Email == emailToLower && x.IsActive);

                if (user is null || !_hashService.VerifyPassword(authenticateRequest.Password, user.PasswordHash))
                {
                    _logger.Warn($"Неудачный вход {emailToLower}");
                    return null;
                }

                _logger.Info($"Успешная авторизация: {emailToLower}");

                return user;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка при авторизации");
                throw;
            }

        }

        /// <summary>
        /// Метод, который создает пользователя
        /// </summary>
        /// <param name="request">Запрос, содержащий данные для регистрации</param>
        /// <exception cref="Exception">Выбрасывается, если роль "Worker" не найдена в базе данных или email не существует</exception>
        public async Task Register(RegisterRequest request)
        {
            _authValidation.ValidateRegisterRequest(request);

            _logger.Debug("Валидация полей формы");

            try
            {
                _authValidation.ValidateRegisterRequest(request);

                var email = request.Email.Trim().ToLower();
                _logger.Debug($"Проверка уникальности email: {email}");

                if (await _db.Users.AnyAsync(x => x.Email == email))
                {
                    _logger.Info($"Введен email, который уже существует в системе: {email}");
                    throw new Exception("EmailExists");
                }

                var roleId = await _db.Roles
                    .Where(x => x.Title == "Worker")
                    .Select(x => x.Id)
                    .FirstOrDefaultAsync();

                if (roleId == Guid.Empty)
                {
                    throw new Exception("RoleNotFound");
                }

                var user = new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    MiddleName = request.MiddleName,
                    Email = email,
                    PasswordHash = _hashService.GetHash(request.Password),
                    RoleId = roleId,
                    IsActive = true
                };
                _logger.Info($"Создание пользователя: {email}");
                _db.Users.Add(user);
                await _db.SaveChangesAsync();

                _logger.Info($"Пользователь успешно зарегистрирован: {email}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка регистрации {request?.Email}");
                throw;
            }
        }
    }
}