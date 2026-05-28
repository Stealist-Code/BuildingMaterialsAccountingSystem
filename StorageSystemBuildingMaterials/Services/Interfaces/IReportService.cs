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
        /// <param name="from">Начало периода (включительно).</param>
        /// <param name="to">Конец периода (включительно).</param>
        /// <returns>Список DTO отчетов, отсортированных по дате.</returns>
        /// <exception cref="ArgumentException">Если from или to больше текущей даты.</exception>
        public Task<List<ReportDto>> GetReports(DateTime from, DateTime to);
    }
}