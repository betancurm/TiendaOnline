using Microsoft.EntityFrameworkCore;
using TiendaOnline.web.Models;

namespace TiendaOnline.web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasIndex(t => t.Name).IsUnique();

            modelBuilder.Entity<City>().HasIndex(t => t.Name).IsUnique();

            modelBuilder.Entity<Department>().HasIndex(t => t.Name).IsUnique();
        }
    }
}
