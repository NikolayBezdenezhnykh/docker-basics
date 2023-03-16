using DockerBasics.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DockerBasics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DockerController : ControllerBase
    {
        private readonly RepositoryDbContext _dbContext;

        public DockerController(RepositoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("imagenames")]
        public IActionResult GetImageNames()
        {
            var imageNames = _dbContext.DockerImages.Select(x => x.Name).ToList();

            return Ok(imageNames);
        }
    }
}
