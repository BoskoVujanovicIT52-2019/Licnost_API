using Licnost.Model;
using Microsoft.EntityFrameworkCore;

namespace Licnost.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
            
        }
        public DbSet<Adresa> Adrese{ get; set; }
        public DbSet<FizickoLice> FizickaLica { get; set; }
        public DbSet<KontaktOsoba> KontaktOsobe { get;set; }
        public DbSet<Kupac> Kupci { get; set; }
        public DbSet<LicnostM> Licnosti { get; set; }   
        public DbSet<PravnoLice> PravnaLica { get; set; }
    }
}
