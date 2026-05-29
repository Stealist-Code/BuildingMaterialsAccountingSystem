namespace StorageSystemBuildingMaterials.Models
{
    /// <summary>
    /// Класс Role представляет роль пользователя в системе
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Уникальный идентификатор роли (GUID)
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название роли
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Список пользователей, у которых эта роль
        /// </summary>
        public List<User> Users { get; set; } = new();
    }
}