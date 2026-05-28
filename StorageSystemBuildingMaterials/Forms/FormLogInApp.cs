using Castle.Windsor;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Services.State;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.Forms
{
    public partial class FormLogInApp : Form
    {
        private readonly IWindsorContainer _container;


        public FormLogInApp(IWindsorContainer container)
        {
            InitializeComponent();
            _container = container;

         
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {


            var authService = _container.Resolve<IAuthService>();
            var authValidation = _container.Resolve<IAuthValidation>();
            var categoryService = _container.Resolve<ICategoryService>();
            var productService = _container.Resolve<IProductService>();
            var shipmentService = _container.Resolve<IShipmentService>();
            var shipmentValidation = _container.Resolve<IShipmentValidation>();
            var userService = _container.Resolve<IUserService>();
            var reportService = _container.Resolve<IReportService>();
            var currencyService = _container.Resolve<ICurrencyService>();
            var supplyService = _container.Resolve<ISupplyService>();
            var discountService = _container.Resolve<IDiscountService>();
            var tINService = _container.Resolve<ITINService>();
            var currencyState = _container.Resolve<CurrencyState>();

            var loginForm = new FormLogin(
                authService,
                authValidation,
                categoryService,
                productService,
                shipmentService,
                shipmentValidation,
                reportService,
                userService,
                currencyState,
                currencyService,
                supplyService,
                discountService,
                tINService
            );

            loginForm.Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}