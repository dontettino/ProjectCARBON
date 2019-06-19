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

        public void Raid()
        {
            //int[] ha = new int[] { attackArmy.army["Archer"], attackArmy.army["Infantry"], attackArmy.army["Cavalry"] };
            //int[] ea = new int[] { defendArmy.army["Archer"], defendArmy.army["Infantry"], defendArmy.army["Cavalry"] };
            int attackDamage = attackArmy.GetArmyDamage();
            int defendDamage = defendArmy.GetArmyDamage();

            int[] defendLoss = defendArmy.DamageArmyFor(attackDamage);
            int[] attackLoss = attackArmy.DamageArmyFor(defendDamage);

            //return

        }

        public void Conquer()
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

            // Implement actions to save outcome or return it

        }
    }
}