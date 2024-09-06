using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace ProductsAPI.Models
{
    public class ProductsContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "IPhone 14", Price = 60000, IsActive = true },
                new Product { ProductId = 2, ProductName = "IPhone 15", Price = 65000, IsActive = true },
                new Product { ProductId = 3, ProductName = "IPhone 16", Price = 70000, IsActive = false },
                new Product { ProductId = 4, ProductName = "IPhone 17", Price = 75000, IsActive = true },
                new Product { ProductId = 5, ProductName = "IPhone 18", Price = 80000, IsActive = true }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}
