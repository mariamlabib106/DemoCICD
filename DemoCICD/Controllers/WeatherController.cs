using Microsoft.AspNetCore.Mvc;

namespace DemoCICD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Message = "Pipeline ",
                Date = DateTime.Now
            });
        }
    }
}
