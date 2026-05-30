namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с конфигурацией программы
    /// </summary>
    public class ConfigurationAppService : IConfigurationAppService
    {
        private readonly AppDbContext _db;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="db">бд</param>
        public ConfigurationAppService(AppDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Метод для получения языка интерфейса
        /// </summary>
        /// <returns>Язык интерфейса</returns>
        public string ReturnLanguageFromConfiguration()
        {
            if (!_db.ConfigurationApps.Any())
            {
                return null;
            }
            return _db.ConfigurationApps.FirstOrDefault().Language;
        }

        /// <summary>
        /// Создает конфигурацию, если она отсутсвует
        /// </summary>
        /// <returns>Язык интерфейса</returns>
        public string CreateConfiguration()
        {
            var language = ReturnLanguageFromConfiguration();
            if (language is null)
            {
                var configuration = new ConfigurationApp()
                {
                    Id = Guid.NewGuid(),
                    Language = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName
                };
                _db.ConfigurationApps.Add(configuration);
                _db.SaveChanges();
                language = configuration.Language;
            }
            return language;
        }

        /// <summary>
        /// Изменяет язык
        /// </summary>
        /// <param name="language">Язык</param>
        public void SetLanguage(string language)
        {
            _db.ConfigurationApps.FirstOrDefault().Language = language;
            _db.SaveChanges();
        }
    }
}
