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
        /// <returns></returns>
        public Task<List<ShipmentDto>> GetAllShipments();

        /// <summary>
        /// Создать отгрузку
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="address"></param>
        /// <param name="items"></param>
        /// <param name="totalPrice"></param>
        /// <returns></returns>
        public Task<Shipment> CreateShipment(Guid userId, Address address, Customer customer, List<ShipmentItem> items, decimal totalPrice);

        /// <summary>
        /// Создать поставкуы
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="address"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public Task CreateSupply(Guid userId, Address address, List<SupplyItem> items);
    }
}