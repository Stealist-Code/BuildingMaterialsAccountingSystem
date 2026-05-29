using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using System;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с отгрузками
    /// </summary>
    public interface IShipmentService
    {
        /// <summary>
        /// Получение всех отгрузок
        /// </summary>
        /// <returns>Список отгрузок</returns>
        public Task<List<ShipmentDto>> GetAllShipments();

        /// <summary>
        /// Создаёт новую отгрузку, списывая товары со склада
        /// </summary>
        /// <param name="userId">ID пользователя, создающего отгрузку.</param>
        /// <param name="addressId">ID адреса доставки.</param>
        /// <param name="customerId">ID покупателя.</param>
        /// <param name="items">Список товаров в отгрузке.</param>
        /// <param name="totalPrice">Общая цена продажи.</param>
        /// <returns>Созданная отгрузка.</returns>
        /// <exception cref="Exception">Ошибки валидации, недостаток товара или отсутствие данных.</exception>
        public Task<Shipment> CreateShipment(Guid userId, Guid addressId, Guid customerId, List<ShipmentItem> items, decimal totalPrice);

        /// <summary>
        /// Создаёт поставку (приход товара) и увеличивает остатки на складе.
        /// </summary>
        /// <param name="userId">ID пользователя, создающего поставку.</param>
        /// <param name="address">Адрес поставки.</param>
        /// <param name="items">Список поставляемых товаров.</param>
        /// <exception cref="Exception">Если товар не найден в базе.</exception>
        public Task CreateSupply(Guid userId, Address address, List<SupplyItem> items);

        /// <summary>
        /// Метод для получения закупочной цены
        /// </summary>
        /// <param name="items"></param>
        /// <returns>Закупочная цена</returns>
        /// <exception cref="Exception">Ошибки валидации</exception>
        public Task<decimal> GetPurshacePrice(List<ShipmentItem> items);
    }
}