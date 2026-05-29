namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса конфигурации программы
    /// </summary>
    public interface IConfigurationAppService
    {
        /// <summary>
        /// Метод для получения языка интерфейса
        /// </summary>
        /// <returns>Язык интерфейса</returns>
        public string ReturnLanguageFromConfiguration();

        /// <summary>
        /// Создает конфигурацию, если она отсутсвует
        /// </summary>
        public string CreateConfiguration();

        /// <summary>
        /// Изменяет язык
        /// </summary>
        /// <param name="language">Язык</param>
        public void SetLanguage(string language);
    }
}
