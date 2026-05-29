namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с категориями. Вся логика с БД, связанная с категориями!!!
    /// </summary>
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryValidation _categoryValidation;
        private readonly AppDbContext _db;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public CategoryService(AppDbContext db, ICategoryValidation categoryValidation)
        {
            _db = db;
            _categoryValidation = categoryValidation;
        }

        /// <summary>
        /// Возвращает все категории
        /// </summary>
        /// <returns>Список категорий</returns>
        public async Task<List<Category>> GetAllCategories()
        {
            try
            {
                return await _db.Categories.OrderBy(x => x.Name).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Ошибка получения категорий");
                throw;
            }
        }

        /// <summary>
        /// Добавить категорию (только для админа)
        /// </summary>
        /// <param name="name">Название категории</param>
        /// <exception cref="Exception">Выбрасывается, если ошибка создания категории</exception>
        public async Task AddCategory(string name)
        {
            _logger.Info($"Создание категории {name}");

            try
            {
                _categoryValidation.Validate(name);

                _logger.Debug("Проверка уникальности названия");

                if (await _db.Categories.AnyAsync(c => c.Name == name))
                {
                    _logger.Info("Категория уже существует");
                    throw new Exception("CategoryExisted");
                }

                await _db.Categories.AddAsync(new Category { Name = name });
                await _db.SaveChangesAsync();

                _logger.Info($"Категория создана: {name}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка создания категории {name}");
                throw;
            }
        }

        /// <summary>
        /// Обновляет название категории
        /// </summary>
        /// <param name="id">Id категории</param>
        /// <param name="newName">Новое название категории</param>
        /// <exception cref="Exception">Выбрасывается, если ошибка обновления категории</exception>
        public async Task UpdateCategory(Guid id, string newName)
        {
            try
            {
                _categoryValidation.Validate(newName);

                var cat = await _db.Categories.FindAsync(id);

                if (cat is null)
                {
                    throw new Exception("CategoryNull");
                }

                _logger.Debug("Проверка уникальности названия");

                bool exists = await _db.Categories.AnyAsync(c => c.Name == newName && c.Id != id);

                if (exists)
                {
                    _logger.Info("Новое название уже существует");
                    throw new Exception("CategoryExisted");
                }

                cat.Name = newName;

                await _db.SaveChangesAsync();

                _logger.Info($"Категория изменена id={id}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка обновления категории id={id}");
                throw;
            }
        }

        /// <summary>
        /// Удалить категорию (только если нет товаров)
        /// </summary>
        /// <param name="id">Id категории</param>
        /// <exception cref="Exception">Выбрасывается, если ошибка удаления категории</exception>
        public async Task DeleteCategory(Guid id)
        {
            _logger.Info($"Удаление категории id={id}");

            try
            {
                var category = await _db.Categories.FindAsync(id);

                if (category is null)
                {
                    throw new Exception("CategoryNull");
                }

                bool hasProducts = await _db.Products.AnyAsync(p => p.CategoryId == id);

                if (hasProducts)
                {
                    throw new Exception("CategoryWithProductsForDelete");
                }

                _db.Categories.Remove(category);
                await _db.SaveChangesAsync();

                _logger.Info($"Категория удалена id={id}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка удаления категории id={id}");
                throw;
            }
        }
    }
}