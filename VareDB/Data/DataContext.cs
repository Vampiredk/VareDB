using Microsoft.EntityFrameworkCore;

namespace VareDB.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<vare> vare { get; set; }
        public DbSet<vare_type> vare_Type { get; set; }
        public DbSet<Ordre> Ordre { get; set; }
        public DbSet<Ordre_vare> Ordre_vare { get; set; }
        public DbSet<Kunde> Kunde { get; set; }
        public DbSet<Postnummer> Postnummer { get; set; }
    }
}
