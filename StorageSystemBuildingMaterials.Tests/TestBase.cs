using Microsoft.EntityFrameworkCore;
using StorageSystemBuildingMaterials.Data;

namespace StorageSystemBuildingMaterials.Tests
{
    public abstract class TestBase : IDisposable
    {
        protected readonly AppDbContext DbContext;

        protected TestBase()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // уникальное им€ дл€ каждого теста
                .Options;

            DbContext = new AppDbContext(options);

            // »нициализаци€ тестовых данных при необходимости
            SeedData();
        }

        protected virtual void SeedData()
        {
            // ƒобавить базовые роли дл€ тестов
            DbContext.Roles.Add(new Models.Role { Id = Guid.NewGuid(), Title = "Admin" });
            DbContext.Roles.Add(new Models.Role { Id = Guid.NewGuid(), Title = "Worker" });
            DbContext.SaveChanges();
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}