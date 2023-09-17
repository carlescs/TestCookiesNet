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
        public IRequestCookieCollection Get()
        {
            var cookies = Request.Cookies;
            return cookies;
        }
    }
}