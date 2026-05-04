using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Forms.Interfaces;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Services.State;
using StorageSystemBuildingMaterials.Validation.Interfaces;
using System;
using System.Windows.Forms;

namespace StorageSystemBuildingMaterials.Forms
{
    /// <summary>
    /// Форма входа в систему
    /// </summary>
    public partial class FormLogin : Form, ILocalizable
    {
        private readonly IAuthService _authService;
        private readonly IAuthValidation _authValidation;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IShipmentService _shipmentService;
        private readonly IShipmentValidation _shipmentValidation;
        private readonly IUserService _userService;
        private readonly IReportService _reportService;
        private readonly ISupplyService _supplyService;
        private readonly CurrencyState _currencyState;
        private readonly ICurrencyService _currencyService;

        /// <summary>
        /// Конструктор формы входа
        /// </summary>
        public FormLogin(IAuthService authService,
                         IAuthValidation authValidation,
                         ICategoryService categoryService,
                         IProductService productService,
                         IShipmentService shipmentService,
                         IShipmentValidation shipmentValidation,
                         IReportService reportService,
                         IUserService userService,
                         CurrencyState currencyState,
                         ICurrencyService currencyService,
                         ISupplyService supplyService)
        {
            InitializeComponent();
            _authService = authService;
            _authValidation = authValidation;
            _shipmentService = shipmentService;
            _categoryService = categoryService;
            _productService = productService;
            _shipmentValidation = shipmentValidation;
            _userService = userService;
            _reportService = reportService;
            _currencyState = currencyState;
            _currencyService = currencyService;
            _supplyService = supplyService;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Login"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            var email = textBoxEmail.Text;
            var password = textBoxPassword.Text;

            try
            {
                _authValidation.ValidateLogin(new AuthenticateRequest
                {
                    Email = email,
                    Password = password
                });

                var user = await _authService.Authenticate(new AuthenticateRequest
                {
                    Email = email,
                    Password = password
                });

                if (user is not null)
                {
                    MessageBox.Show(Resources.LoginSuccess, Resources.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var mainForm = new FormMain(user,
                                                _categoryService,
                                                _productService,
                                                _shipmentService,
                                                _shipmentValidation,
                                                _userService,
                                                _reportService,
                                                () => new FormLogin(_authService, _authValidation, _categoryService, _productService, _shipmentService, _shipmentValidation, _reportService, _userService, _currencyState, _currencyService, _supplyService),
                                                _currencyState,
                                                _currencyService,
                                                _supplyService);
                    mainForm.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show(Resources.LoginFailed, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.ResourceManager.GetString(ex.Message));
            }
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public void ApplyLocalization()
        {
            this.Text = Resources.Login;

            buttonLogin.Text = Resources.Login;
            buttonRegister.Text = Resources.Register;
            labelTextVisualAuth.Text = Resources.Auth;
            labelTextVisualEmail.Text = Resources.Email;
            labelTextVisualPassword.Text = Resources.Password;
        }

        /// <summary>
        /// /Обработчик кнопки "Register" – открывает форму регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var regForm = new FormRegister(_authService);
            regForm.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
        }
    }
}