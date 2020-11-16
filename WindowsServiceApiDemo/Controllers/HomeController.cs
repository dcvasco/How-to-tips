using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WindowsServiceApiDemo.Controllers
{
    [ApiController]
    [Route("Home")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private const string runningMessage = "WindowsServiceApiDemo is running...";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation(runningMessage);
            return runningMessage;
        }
    }
}
