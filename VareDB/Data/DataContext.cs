using Microsoft.EntityFrameworkCore;

namespace VareDB.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<vare> vare { get; set; }
        public DbSet<vare_type> vare_Type { get; set; }
    }
}
