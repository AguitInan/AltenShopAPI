using Microsoft.EntityFrameworkCore;
using ProductCore.Models;
using ProductCore.Datas;

namespace ProductAPI.Datas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(InitialProduct.products);
        }
    }
}
