namespace Carbon_API.Data
{
    public class DataStoreArcher : DataStoreTroop
    {
        private readonly int HIT_POINTS = 10;
        private readonly int ATK_POINTS = 5;
        private readonly int COST = 20;

        public int GetAtkPoints()
        {
            return ATK_POINTS;
        }

        public int GetCost()
        {
            return COST;
        }

        public int GetHitPoints()
        {
            return HIT_POINTS;
        }
    }
}