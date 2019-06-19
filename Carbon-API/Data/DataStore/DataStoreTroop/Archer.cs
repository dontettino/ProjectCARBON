namespace Carbon_API.Data.DataStore.DataStoreTroop
{
    public class Archer : Troop
    {
        public const int ARCHER_COST = 20;

        public Archer()
        {
            hp = 10;
            atk = 5;
            def = 0;
        }
    }
}