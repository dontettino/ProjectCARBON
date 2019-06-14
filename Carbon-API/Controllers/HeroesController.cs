using System.Linq;
using Carbon_API.Data;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetHeroes()
        {
            var heroes = this.context.Heroes.ToList();
            return Ok(heroes);
        }

        [HttpGet("{id}")]
        public IActionResult GetHero(int id)
        {
            var hero = this.context.Heroes.FirstOrDefault(x => x.Id == id);
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