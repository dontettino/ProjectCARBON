using Carbon_API.General;

namespace Carbon_API.Dtos
{
    public class CombatResultDto
    {
        public string CombatType { get; set; }
        public Army AttackArmyState { get; set; }
        public Army DefendArmyState { get; set; }
    }
}