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
                            .UseNpgsql(DatabaseConfig.ConnectionString)
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

                Component.For<CurrencyState>().LifestyleSingleton()
            );

            return container;
        }
    }
}