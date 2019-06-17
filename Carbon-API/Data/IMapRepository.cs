using System.Collections.Generic;
using System.Threading.Tasks;
using Carbon_API.Models;

namespace Carbon_API.Data
{
    public interface IMapRepository
    {
        string GetMap();
        string GetTile(int id);


    }
}