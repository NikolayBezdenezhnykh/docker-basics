using Microsoft.AspNetCore.Mvc;

namespace DockerBasics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content("Description");
        }
    }
}
