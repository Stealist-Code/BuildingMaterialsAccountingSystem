using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Microsoft.EntityFrameworkCore;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.HelperClasses.Interfaces;
using StorageSystemBuildingMaterials.Services;
using StorageSystemBuildingMaterials.Services.Interfaces;
using StorageSystemBuildingMaterials.Services.State;
using StorageSystemBuildingMaterials.Validation.Interfaces;

namespace StorageSystemBuildingMaterials.HelperClasses
{
    /// <summary>
    /// Конфигурация для Castle Windsor
    /// </summary>
    public static class WindsorConfig
    {
        /// <summary>
        /// Создает и настраивает контейнер зависимостей
        /// </summary>
        /// <returns></returns>
        public static IWindsorContainer Register()
        {
            var container = new WindsorContainer();

            container.Register(
                Component.For<DbContextOptions<AppDbContext>>()
                    .UsingFactoryMethod(() =>
                    {
                        var options = new DbContextOptionsBuilder<AppDbContext>()
                            .UseNpgsql("Host=localhost;Port=5432;Database=DB;Username=postgres;Password=1245admin")
                            .Options;

                        return options;
                    })
                    .LifestyleTransient(),

                Component.For<AppDbContext>()
                    .LifestyleTransient()
            );

            container.Register(
                Classes.FromAssemblyContaining<AuthService>()
                    .InNamespace("StorageSystemBuildingMaterials.Services")
                    .WithServiceAllInterfaces()
                    .LifestyleTransient(),

                Classes.FromAssemblyContaining<IAuthValidation>()
                    .InNamespace("StorageSystemBuildingMaterials.Validation")
                    .WithServiceAllInterfaces()
                    .LifestyleTransient(),

                Component.For<IHashService>()
                    .ImplementedBy<HashHelper>()
                    .LifestyleSingleton(),

                Component.For<HttpClient>().LifestyleSingleton(),

                Component.For<ICurrencyService>().ImplementedBy<CurrencyService>().LifestyleSingleton(),

                Component.For<CurrencyState>().LifestyleSingleton()
            );

            return container;
        }
    }
}