using Microsoft.EntityFrameworkCore;
using OnSale.Common.Entities;

namespace OnSale.Web.Data
{
    public class DataContext : DbContext
    {
        /*
         * The constructor. 
         */
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Department> Departments { get; set; }

        /*
         * Additionally, create a index to handle duplicate attributes.
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a index for City
            modelBuilder.Entity<City>()
                .HasIndex(t => t.Name)
                .IsUnique();            
            
            // Create a index for Country
            modelBuilder.Entity<Country>()
                .HasIndex(t => t.Name)
                .IsUnique();

            // Create a index for Department
            modelBuilder.Entity<Department>()
                .HasIndex(t => t.Name)
                .IsUnique();

            

        }
    }
}
