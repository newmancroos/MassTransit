using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet("default")]
        public IActionResult Index()
        {
            return Ok("Success");
        }
    }
}
