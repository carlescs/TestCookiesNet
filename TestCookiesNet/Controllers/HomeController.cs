using Microsoft.AspNetCore.Mvc;

namespace TestCookiesNet.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/")]
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }
    }
}