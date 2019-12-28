using Microsoft.EntityFrameworkCore;
using GameAPI.Models;

namespace GameAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Game> Games {get; set;}

        public DbSet<Movement> Movements {get; set;}
    }
}