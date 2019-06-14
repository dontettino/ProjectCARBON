using Carbon_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Carbon_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Hero> Heroes { get; set; }
    }
}