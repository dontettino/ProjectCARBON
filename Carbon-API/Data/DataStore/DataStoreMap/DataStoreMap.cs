using System.Collections.Generic;
using System.IO;
using Carbon_API.Models;
using Newtonsoft.Json;

namespace Carbon_API.Data.DataStore.DataStoreMap
{
    public class DataStoreMap
    {
        List<Tile> tiles;
        public List<Tile> LoadMapFromJson()
        {
            using (StreamReader r = new StreamReader("Data\\DataStore\\DataStoreMap\\map_single.json"))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
                tiles = new List<Tile>();
                foreach (Item i in items)
                {
                    var tile = new Tile();
                    tile.type = 1;
                    tile.description = i.description;
                    tile.info = i.info;
                    tile.money = i.money;
                    tile.army = "5-10-15";
                    tiles.Add(tile);
                }

                return tiles;
            }
        }

    }


}

public class Item
{
    public string type { get; set; }
    public NPC monster { get; set; }
    public string description { get; set; }
    public string info { get; set; }
    public int money { get; set; }
    public int[] resources;
    public int[] army;
    public string allegiance { get; set; }

    public override string ToString()
    {
        string str = "";
        str += type + "\n";
        str += monster.ToString() + "\n";
        str += info + "\n";
        str += money + "\n";
        str += resources[0] + " " + resources[1] + " " + resources[2] + "\n";
        str += army[0] + " " + army[1] + " " + army[2] + "\n";
        str += allegiance + "\n";

        return str;
    }
}

public class NPC
{
    public string name;
    public int hp;
    public int damage;

    public NPC()
    {
    }
    public NPC(string name, int hp, int damage)
    {
        this.name = name;
        this.hp = hp;
        this.damage = damage;
    }
}