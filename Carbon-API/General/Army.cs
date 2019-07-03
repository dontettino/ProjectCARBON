using System;
using System.Collections.Generic;
using Carbon_API.Data.DataStore.DataStoreTroop;

namespace Carbon_API.General
{
    public class Army
    {
        public Archer archer = new Archer();
        public Infantry infantry = new Infantry();
        public Cavalry cavalry = new Cavalry();

        // Maybe this should not be public... who knows.
        public Dictionary<string, int> army = new Dictionary<string, int>();

        public Army()
        {
            army.Add("Archer", 0);
            army.Add("Infantry", 0);
            army.Add("Cavalry", 0);
        }

        public Army(int[] army)
        {
            SetArmy(army);
        }

        public bool IsArmyDefeated()
        {
            bool defeat = true;
            if (army["Archer"] <= 0) { defeat = false; }
            if (army["Infantry"] <= 0) { defeat = false; }
            if (army["Cavalry"] <= 0) { defeat = false; }
            return defeat;
        }

        public void SetArmy(int[] army)
        {
            this.army["Archer"] = (army[0] < 0) ? 0 : army[0];
            this.army["Infantry"] = (army[1] < 0) ? 0 : army[1];
            this.army["Cavalry"] = (army[2] < 0) ? 0 : army[2];
        }
        /*
        @damage holds value of damage that should be distributed across whole army
        @return returns Army object that holds actual state of army after it was damaged
         */
        public Army DamageArmyFor(int damage)
        {
            float dmgShare = (float)damage / 3;
            int a = DamageArchersFor(Convert.ToInt32(Math.Ceiling(dmgShare)));
            int i = DamageInfantryFor(Convert.ToInt32(Math.Ceiling(dmgShare)));
            int c = DamageCavalryFor(Convert.ToInt32(Math.Ceiling(dmgShare)));

            return new Army(new int[] { a, i, c });
        }

        public int DamageArchersFor(int damage)
        {
            if (army["Archer"] <= 0)
            {
                return 0;
            }
            float loss = (float)damage / archer.hp;
            int lost = DecreaseNumber("Archer", Convert.ToInt32(Math.Ceiling(loss)));

            return lost;
        }

        public int DamageInfantryFor(int damage)
        {
            if (army["Infantry"] <= 0)
            {
                return 0;
            }
            float loss = (float)damage / infantry.hp;
            int lost = DecreaseNumber("Infantry", Convert.ToInt32(Math.Ceiling(loss)));

            return lost;
        }

        public int DamageCavalryFor(int damage)
        {
            if (army["Cavalry"] <= 0)
            {
                return 0;
            }
            float loss = (float)damage / cavalry.hp;
            int lost = DecreaseNumber("Cavalry", Convert.ToInt32(Math.Ceiling(loss)));

            return lost;
        }

        public int DecreaseNumber(string troopName, int number)
        {
            if (army[troopName] < number)
            {
                number = army[troopName];
            }
            army[troopName] -= number;
            if (army[troopName] < 0) { army[troopName] = 0; }

            return number;
        }
        public void SetTroopNum(string troopName, int number)
        {
            army[troopName] = number;
        }
        public int GetArmyDamage()
        {
            return GetArcherDamage() + GetInfantryDamage() + GetCavalryDamage();
        }

        public int GetArcherDamage()
        {
            return archer.atk * army["Archer"];
        }

        public int GetInfantryDamage()
        {
            return infantry.atk * army["Infantry"];
        }

        public int GetCavalryDamage()
        {
            return cavalry.atk * army["Cavalry"];
        }



    }
}