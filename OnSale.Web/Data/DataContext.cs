using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnSale.Common.Entities;
using OnSale.Web.Data.Entities;

namespace OnSale.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        // The constructor. 
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // Mapping the database.
        public DbSet<Category> Categories { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        // Additionally, create a index to handle duplicate attributes.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create an index for Categories
            modelBuilder.Entity<Category>()
                .HasIndex(t => t.Name)
                .IsUnique();


            // Create an index for City
            modelBuilder.Entity<City>()
                .HasIndex(t => t.Name)
                .IsUnique();            
            
            // Create an index for Country
            modelBuilder.Entity<Country>()
                .HasIndex(t => t.Name)
                .IsUnique();

            // Create an index for Department
            modelBuilder.Entity<Department>()
                .HasIndex(t => t.Name)
                .IsUnique();

            // Create an index for Product
            modelBuilder.Entity<Product>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}
