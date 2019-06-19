using System.Threading.Tasks;
using Carbon_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Carbon_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private readonly IMapRepository repo;
        private readonly ILogger logger;
        public MapController(IMapRepository repo, ILogger<MapController> logger)
        {
            this.repo = repo;
            this.logger = logger;

        }

        [HttpGet]
        public async Task<IActionResult> GetMap()
        {
            //THIS AWFUL TRASH IS USED JUST TO TEST FRONTEND.
            var response = this.repo.GetMap();
            logger.LogDebug("Map was loaded.");
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapTile(int id)
        {
            var tile = this.repo.GetTile(id);
            return Ok(tile);
        }


        [HttpPut]
        public void UpdateMapTile(int id, [FromBody] string value)
        {

        }
    }
}