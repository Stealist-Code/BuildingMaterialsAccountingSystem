using StorageSystemBuildingMaterials.DTO;
using System;

namespace StorageSystemBuildingMaterials.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для формирования отчётов по отгрузкам
    /// </summary>
    public interface IReportService
    {
        /// <summary>
        /// Получает список отчётов за указанный период времени
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public Task<List<ReportDto>> GetReports(DateTime from, DateTime to);
    }
}