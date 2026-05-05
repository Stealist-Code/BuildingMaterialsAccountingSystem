using Microsoft.EntityFrameworkCore;
using StorageSystemBuildingMaterials.Data;
using StorageSystemBuildingMaterials.DTO;
using StorageSystemBuildingMaterials.Models;
using StorageSystemBuildingMaterials.Services.Interfaces;
using System;

namespace StorageSystemBuildingMaterials.Services
{
    /// <summary>
    /// Сервис для работы с отчетами
    /// </summary>
    public class ReportService : IReportService
    {
        private readonly AppDbContext _db;

        public ReportService(AppDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Получить отчеты
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<List<ReportDto>> GetReports(DateTime from, DateTime to)
        {
            if (to > DateTime.Now || from > DateTime.Now)
            {
                throw new ArgumentException("IncorrectDate");
            }

            var fromUtc = DateTime.SpecifyKind(from.Date, DateTimeKind.Utc);
            var toUtc = DateTime.SpecifyKind(to.Date.AddDays(1), DateTimeKind.Utc);

            var reports = await _db.Shipments
                .AsNoTracking()
                .Where(x => x.ShipmentDate >= fromUtc && x.ShipmentDate < toUtc)
                .Where(x => !x.IsSupply)
                .Select(x => new ReportDto
                {
                    Date = x.ShipmentDate,
                    CustomerName = x.Customer.FullName,
                    ShipmentAmount = x.PriceForSell,
                    Profit = x.ShipmentItems.Sum(i => x.PriceForSell - x.ShipmentItems.Sum(y => y.TotalPurchasePrice)),
                    CustomerEmail = x.Customer.Email
                })
                .OrderBy(x => x.Date)
                .ToListAsync();

            return reports;
        }
    }
}