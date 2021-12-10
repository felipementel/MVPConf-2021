using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace MVPConf.ProjectOne.Api.Controllers
{
    [ExcludeFromCodeCoverage]
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        private readonly ILogger<HealthCheckController> _logger;

        public HealthCheckController(ILogger<HealthCheckController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "HealthCheckController")]
        public IActionResult Get()
        {
            _logger.LogInformation("HealthCheckController executed");

            return Ok(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
        }
    }
}