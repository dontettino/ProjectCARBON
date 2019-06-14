using System.Linq;
using System.Threading.Tasks;
using Carbon_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Carbon_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private readonly DataContext context;
        public MapController(DataContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public async Task<IActionResult> GetMap()
        { 
            var map = "";
            return Ok(map);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapTile()
        {
            var tile = "";
            return Ok(tile);
        }

        [HttpPut]
        public async void UpdateMapTile(int id, [FromBody] string value)
        {

        }
    }
}