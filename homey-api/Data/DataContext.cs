using homey_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace homey_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<House> Houses { get; set; }
    }
}