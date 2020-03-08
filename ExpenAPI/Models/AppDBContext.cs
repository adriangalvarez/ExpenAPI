using Microsoft.EntityFrameworkCore;

namespace ExpenAPI.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext( DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Caretaker> Caretakers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }
}
