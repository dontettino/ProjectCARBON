using System.Threading.Tasks;
using Carbon_API.Data;
using Carbon_API.Data.DataStore.DataStoreMap;
using Carbon_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Carbon_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private readonly IMapRepository repo;
        public MapController(IMapRepository repo)
        {
            this.repo = repo;

        }

        [HttpGet]
        public async Task<IActionResult> GetMap()
        {
            //THIS AWFUL TRASH IS USED JUST TO TEST FRONTEND.
            var response = this.repo.GetMap();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapTile(int id)
        {
            var tile = repo.GetTile(id);
            return Ok(tile);
        }


        [HttpPut]
        public void UpdateMapTile(int id, [FromBody] string value)
        {

        }
    }
}