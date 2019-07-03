using Carbon_API.Dtos;
using Carbon_API.General;

namespace Carbon_API.Logic
{
    public class CombatManager
    {
        public Army attackArmy;
        public Army defendArmy;

        public CombatManager(Army attackArmy, Army defendArmy)
        {
            this.attackArmy = attackArmy;
            this.defendArmy = defendArmy;
        }

        private void Raid()
        {
            int attackDamage = attackArmy.GetArmyDamage();
            int defendDamage = defendArmy.GetArmyDamage();

            defendArmy = defendArmy.DamageArmyFor(attackDamage);
            attackArmy = attackArmy.DamageArmyFor(defendDamage);
        }

        private void Conquer()
        {
            for (; ; )
            {
                if ((attackArmy.IsArmyDefeated()) || (defendArmy.IsArmyDefeated()))
                {
                    break;
                }
                else
                {
                    Raid();
                }
            }
        }

        public CombatResultDto PerformCombat(string combatType)
        {

            CombatResultDto result = new CombatResultDto();
            if (combatType == "Raid")
                switch (combatType)
                {
                    case "Raid":
                        result.CombatType = "Raid";
                        Raid();

                        break;
                    case "Conquer":
                        Conquer();
                        result.CombatType = "Conquer";
                        break;
                }
            result.AttackArmyState = attackArmy;
            result.DefendArmyState = defendArmy;

            return result;
        }
    }
}