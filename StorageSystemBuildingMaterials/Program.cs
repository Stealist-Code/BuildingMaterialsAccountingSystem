using Castle.Windsor;
using NLog;
using StorageSystemBuildingMaterials.Forms;
using StorageSystemBuildingMaterials.HelperClasses;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Services.State;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials
{
    internal static class Program
    {
        private static IWindsorContainer container;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                _logger.Info("Запуск приложения");

                container = WindsorConfig.Register();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var authService = container.Resolve<IAuthService>();
                var authValidation = container.Resolve<IAuthValidation>();
                var categoryService = container.Resolve<ICategoryService>();
                var productService = container.Resolve<IProductService>();
                var shipmentService = container.Resolve<IShipmentService>();
                var shipmentValidation = container.Resolve<IShipmentValidation>();
                var userService = container.Resolve<IUserService>();
                var reportService = container.Resolve<IReportService>();
                var currencyService = container.Resolve<ICurrencyService>();
                var supplyService = container.Resolve<ISupplyService>();
                var currencyState = container.Resolve<CurrencyState>();

                Application.Run(new FormLogin(
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
                    supplyService
                ));
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Приложение завершилось досрочно");
                throw;
            }
            finally
            {
                _logger.Info("Остановка приложения");
                LogManager.Shutdown();
            }
        }
    }
}