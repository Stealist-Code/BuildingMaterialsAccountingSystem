namespace StorageSystemBuildingMaterials.Services.State
{
    /// <summary>
    /// Хранит текущее состояние выбранной валюты в приложении
    /// </summary>
    public class CurrencyState
    {
        /// <summary>
        /// Код выбранной валюты
        /// </summary>
        public string SelectedCurrency { get; set; } = "RUB";

        /// <summary>
        /// Текущий курс валюты по отношению к рублю
        /// </summary>
        public decimal CurrentRate { get; set; } = 1;
    }
}