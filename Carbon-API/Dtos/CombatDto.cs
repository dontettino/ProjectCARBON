namespace Carbon_API.Dtos
{
    public class CombatDto
    {
        public int TileId { get; set; }
        public string CombatType { get; set; }
        public int[] AtkArmy { get; set; }
        public int[] DefArmy { get; set; }
    }
}