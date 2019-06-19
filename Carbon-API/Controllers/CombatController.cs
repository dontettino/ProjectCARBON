using System;
using System.Threading.Tasks;
using Carbon_API.Dtos;
using Carbon_API.General;
using Carbon_API.Logic;
using Microsoft.AspNetCore.Mvc;

namespace Carbon_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CombatController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SimulateBattle(CombatDto combatDto)
        {
            var attackArmy = new Army(combatDto.AtkArmy);
            var defendArmy = new Army(combatDto.DefArmy);
            var combatManager = new CombatManager(attackArmy, defendArmy);

            if (combatDto.CombatType == "Raid")
            {
                combatManager.Raid();
            }
            else if (combatDto.CombatType == "Conquer")
            {
                combatManager.Conquer();
            }
            else
            {
                throw new ArgumentException();
            }
            var response = combatDto.CombatType + combatDto.AtkArmy[2] + combatDto.DefArmy[1];

            return Ok(response);
        }

    }
}