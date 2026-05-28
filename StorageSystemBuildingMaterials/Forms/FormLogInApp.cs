using Castle.Windsor;
using Microsoft.Extensions.DependencyModel;
using StorageSystemBuildingMaterials.Properties;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Services.State;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Forms
{
    public partial class FormLogInApp : Form
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
        private readonly IDiscountService _discountService;
        private readonly CurrencyState _currencyState;
        private readonly ICurrencyService _currencyService;
        private readonly ITINService _tINService;
        private readonly IWeatherService _weatherService;
        private readonly IWindsorContainer _container;

        public FormLogInApp(IAuthService authService,
                         IAuthValidation authValidation,
                         ICategoryService categoryService,
                         IProductService productService,
                         IShipmentService shipmentService,
                         IShipmentValidation shipmentValidation,
                         IReportService reportService,
                         IUserService userService,
                         CurrencyState currencyState,
                         ICurrencyService currencyService,
                         ISupplyService supplyService,
                         IDiscountService discountService,
                         ITINService tINService,
                         IWeatherService weatherService)
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
            _discountService = discountService;
            _tINService = tINService;
            _weatherService = weatherService;
            ApplyLocalization();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var loginForm = new FormLogin(
                _authService,
                _authValidation,
                _categoryService,
                _productService,
                _shipmentService,
                _shipmentValidation,
                _reportService,
                _userService,
                _currencyState,
                _currencyService,
                _supplyService,
                _discountService,
                _tINService,
                _weatherService
            );

            loginForm.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ApplyLocalization()
        {
            labelText.Text = Resources.SystemAccountingBuildingMaterials;
            buttonClose.Text = Resources.CloseApp;
            buttonOpen.Text = Resources.OpenApp;
            this.Text = Resources.LogInTheApp;
        }
    }
}