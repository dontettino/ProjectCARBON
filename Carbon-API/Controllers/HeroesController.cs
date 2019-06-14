using System.Linq;
using System.Threading.Tasks;
using Carbon_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Carbon_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private readonly DataContext context;
        public HeroesController(DataContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public async Task<IActionResult> GetHeroes()
        {
            var heroes = await this.context.Heroes.ToListAsync();
            return Ok(heroes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHero(int id)
        {
            var hero = await this.context.Heroes.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(hero);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}