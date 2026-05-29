namespace StorageSystemBuildingMaterials.Data
{
    /// <summary>
    /// Создаёт контекст базы данных для миграций
    /// </summary>
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        /// <summary>
        /// Создаёт экземпляр <see cref="AppDbContext"/> для миграций.
        /// </summary>
        /// <param name="args">Аргументы командной строки (не используются).</param>
        /// <returns>Настроенный экземпляр контекста базы данных.</returns>
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseNpgsql(
                DatabaseConfig.ConnectionString
            );

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}