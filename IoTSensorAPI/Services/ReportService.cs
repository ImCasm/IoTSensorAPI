using IoTSensorAPI.Entities;
using IoTSensorAPI.Repository;

namespace IoTSensorAPI.Services
{
    public class ReportService
    {
        private readonly ReportRepository _reportRepository;

        public ReportService(ReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public async Task<bool> CreateReport(Report report)
        {
            return await _reportRepository.CreateReport(report);
        }
    }
}
