using Microsoft.EntityFrameworkCore;

namespace StudentyApp_BackEnd.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Event> Events => Set<Event>();
    }
}
