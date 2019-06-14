using System.Linq;
using System.Threading.Tasks;
using Carbon_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Carbon_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {
        private readonly DataContext context;
        public BuildingsController(DataContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public async Task<IActionResult> GetBuildings()
        { 
            var town = "";
            return Ok(map);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBuilding()
        {
            var tile = "";
            return Ok(tile);
        }

        [HttpPut]
        public async void UpdateBuilding(int id, [FromBody] string value)
        {

        }
    }
}