using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace StudentyApp_BackEnd.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Event> Events { get; set; } 
        // public DbSet<Event> Events => Set<Event>(); 
    }
}


