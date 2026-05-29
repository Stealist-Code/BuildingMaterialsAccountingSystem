using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Forms.Interfaces;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Services.State;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace StorageSystemBuildingMaterials.Forms
{
    /// <summary>
    /// Форма для изменения настроек программы (валюта, язык интерфейса)
    /// </summary>
    public partial class FormSettings : Form, ILocalizable
    {
        private bool _isUpdating = false;
        private readonly ICurrencyService _currencyService;
        private readonly CurrencyState _currencyState;
        private readonly IConfigurationAppService _configurationAppService;

        public FormSettings(ICurrencyService currencyService, CurrencyState currencyState, IConfigurationAppService configurationAppService)
        {
            InitializeComponent();
            _currencyService = currencyService;
            _currencyState = currencyState;
            _configurationAppService = configurationAppService;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (comboBoxLanguage.SelectedIndex == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("ru");
                _configurationAppService.SetLanguage("ru");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
                _configurationAppService.SetLanguage("en");
            }

            _isUpdating = true;
            _isUpdating = false;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            comboBoxLanguage.Items.Clear();
            comboBoxLanguage.Items.Add(Resources.LanguageRussian);
            comboBoxLanguage.Items.Add(Resources.LanguageEnglish);

            if (Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == "en")
            {
                comboBoxLanguage.SelectedIndex = 1;
            }
            else
            {
                comboBoxLanguage.SelectedIndex = 0;
            }

            ApplyLocalization();
            InitCurrencies();

            comboBoxCurrency.SelectedValue = _currencyState.SelectedCurrency;
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.SettingsTitle;

            buttonBack.Text = Resources.BackButton;
            btnSave.Text = Resources.SaveButton;
            buttonSettings.Text = Resources.GeneralLabel;
            btnClose.Text = Resources.Cancel;

            labelLanguage.Text = Resources.LanguageLabel;
            labelCurrency.Text = Resources.CurrencyLabel;
            labelGeneral.Text = Resources.GeneralLabel;

            comboBoxLanguage.Items.Clear();
            comboBoxLanguage.Items.Add(Resources.LanguageRussian);
            comboBoxLanguage.Items.Add(Resources.LanguageEnglish);

            if (Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == "en")
            {
                comboBoxLanguage.SelectedIndex = 1;
            }
            else
            {
                comboBoxLanguage.SelectedIndex = 0;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedIndex == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("ru");
                _configurationAppService.SetLanguage("ru");
            }
            else if (comboBoxLanguage.SelectedIndex == 1)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
                _configurationAppService.SetLanguage("en");
            }

            var selectedCode = comboBoxCurrency.SelectedValue.ToString();

            var rate = await _currencyService.GetRate(selectedCode);

            _currencyState.SelectedCurrency = selectedCode;
            _currencyState.CurrentRate = rate;

            foreach (Form form in Application.OpenForms)
            {
                if (form is ILocalizable localizable)
                {
                    localizable.ApplyLocalization();
                }

                if (form is FormMain main)
                {
                    main.RefreshData();
                }
            }
        }

        private void InitCurrencies()
        {
            var currencies = new List<CurrencyDto>
            {
                new CurrencyDto { Code = "RUB", Name = Resources.Rubles },
                new CurrencyDto { Code = "USD", Name = Resources.Dollars },
                new CurrencyDto { Code = "CNY", Name = Resources.Yuan }
            };

            comboBoxCurrency.DataSource = currencies;
            comboBoxCurrency.DisplayMember = "Name";
            comboBoxCurrency.ValueMember = "Code";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}