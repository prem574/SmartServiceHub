using Microsoft.AspNetCore.Mvc;

namespace SmartServiceHub.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class Testcontroller : Controller
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok("smart ServiceHub API is running");
        }

    }
}
