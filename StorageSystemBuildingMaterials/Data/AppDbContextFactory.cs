using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StorageSystemBuildingMaterials.Data
{
    /// <summary>
    /// Создаёт контекст базы данных для миграций
    /// </summary>
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Database=DB;Username=postgres;Password=1245admin"
            );

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}