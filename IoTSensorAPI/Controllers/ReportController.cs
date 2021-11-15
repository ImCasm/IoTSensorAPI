using IoTSensorAPI.Entities;
using IoTSensorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace IoTSensorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ReportService _reportService;
        public ReportController(ReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpPost]
        public IActionResult CreateReport([FromBody] Report report)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(_reportService.CreateReport(report));
        }
    }
}
