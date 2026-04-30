using System;
using System.Collections.Generic;
using System.Text;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для получения курсов валют
    /// </summary>
    public interface ICurrencyService
    {
        /// <summary>
        /// Получает курс указанной валюты относительно рубля
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Task<decimal> GetRate(string code);
    }
}