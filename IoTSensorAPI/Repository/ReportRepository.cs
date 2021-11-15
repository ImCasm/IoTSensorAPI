using IoTSensorAPI.Entities;

namespace IoTSensorAPI.Repository
{
    public class ReportRepository
    {
        private readonly AppDbContext _context;

        public ReportRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateReport(Report report)
        {
            report.Id = Guid.NewGuid();
            report.Date = DateTime.UtcNow;
            _context.Reports.Add(report);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
