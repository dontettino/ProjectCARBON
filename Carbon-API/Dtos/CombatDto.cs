namespace Carbon_API.Dtos
{
    public class CombatDto
    {
        public int TileId { get; set; }
        public string CombatType { get; set; }
        public int[] AtkArmy { get; set; }
        public int[] DefArmy { get; set; }
        //public string AtkArcher { get; set; }
        //public string AtkInfantry { get; set; }
        //public string AtkCavalry { get; set; }
        //public string DefArcher { get; set; }
        //public string DefInfantry { get; set; }
        //public string DefCavalry { get; set; }
    }
}