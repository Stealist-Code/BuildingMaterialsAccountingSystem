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

        [STAThread]
        static void Main()
        {
            try
            {
                _logger.Info("Запуск приложения");

                container = WindsorConfig.Register();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var startForm = new FormLogInApp(container);
                Application.Run(startForm);
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