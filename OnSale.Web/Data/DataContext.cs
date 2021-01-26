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

        /*
         * To map the database
         */
        public DbSet<Country> Countries { get; set; }

        /*
         * Additionally, create a index to handle duplicate names in the countries.
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}
