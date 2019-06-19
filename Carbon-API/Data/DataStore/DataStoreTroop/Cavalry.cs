namespace Carbon_API.Data.DataStore.DataStoreTroop
{
    public class Cavalry : Troop
    {
        public const int CAVALRY_COST = 50;

        public Cavalry()
        {
            hp = 10;
            atk = 15;
            def = 0;
        }
    }
}