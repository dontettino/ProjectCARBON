namespace Carbon_API.Data.DataStore.DataStoreTroop
{
    public class Infantry : Troop
    {
        public const int INFANTRY_COST = 30;

        public Infantry()
        {
            hp = 20;
            atk = 5;
            def = 0;
        }
    }
}