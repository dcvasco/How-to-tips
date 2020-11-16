using WorkerService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WindowsServiceApiDemo.Controllers
{
    [ApiController]
    [Route("Command/{apiCommand}")]
    public class CommandController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private string RunningMessage() => $"apiCommand: {Worker.ApiCommand}";

        public CommandController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string SetCommand(string apiCommand)
        {
            Worker.ApiCommand = apiCommand;
            _logger.LogInformation(RunningMessage());
            return RunningMessage();
        }
    }
}
