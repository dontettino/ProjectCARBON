using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Carbon_API.Models;
using Newtonsoft.Json;

namespace Carbon_API.Data
{
    public class MapFileRepository : IMapRepository
    {
        public string GetMap()
        {
            using (StreamReader r = new StreamReader("Data\\DataStore\\DataStoreMap\\map_single.json"))
            {
                string json = r.ReadToEnd();

                return json;
            }
        }

        public string GetTile(int id)
        {
            var file = "Data\\DataStore\\DataStoreMap\\";
            switch (id)
            {
                case 1:
                    file += "tile_1.json";
                    break;
                case 2:
                    file += "tile_2.json";
                    break;
                case 3:
                    file += "tile_3.json";
                    break;
                case 4:
                    file += "tile_4.json";
                    break;
                case 5:
                    file += "tile_5.json";
                    break;
            }
            using (StreamReader r = new StreamReader(file))
            {
                string json = r.ReadToEnd();

                return json;
            }
        }
    }
}