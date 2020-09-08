

using Microsoft.EntityFrameworkCore;

namespace ProductDAO.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext()
        {
            //Database.EnsureCreated();
        }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("ProductMaster");
            modelBuilder.Entity<Product>().Property("Price").HasColumnType("integer");
            modelBuilder.Entity<Product>()
                .Property("ProductName")
                .HasColumnType("varchar (20)")
                .IsRequired();

            modelBuilder.Entity<Product>().HasMany(o => o.Orders);

            //Password -> userid followed by 1234

            modelBuilder.Entity<Product>().Property("Price").HasDefaultValue(100);
            modelBuilder.Entity<Product>().Property("Description").HasComputedColumnSql("ProductName+'1234'");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\sqlexpress;database=shopdb;integrated security=true");
        }

        public DbSet<Product> Products { get; set; } //tablename :: Products mapped with model class Product
    }
}
