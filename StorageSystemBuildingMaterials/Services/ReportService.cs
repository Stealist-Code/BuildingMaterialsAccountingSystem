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
        /// Получает список отчётов за указанный период времени
        /// </summary>
        /// <param name="from">Начало периода (включительно).</param>
        /// <param name="to">Конец периода (включительно).</param>
        /// <returns>Список DTO отчетов, отсортированных по дате.</returns>
        /// <exception cref="ArgumentException">Если from или to больше текущей даты.</exception>
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
                    Profit = x.PriceForSell - x.ShipmentItems.Sum(i => i.TotalPurchasePrice),
                    CustomerEmail = x.Customer.Email
                })
                .OrderBy(x => x.Date)
                .ToListAsync();

            return reports;
        }
    }
}