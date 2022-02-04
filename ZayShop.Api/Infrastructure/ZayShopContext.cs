using Microsoft.EntityFrameworkCore;
using ZayShop.Api.Entities;

namespace ZayShop.Api.Infrastructure
{
    public class ZayShopContext : DbContext
    {
        public DbSet<Brand>Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public ZayShopContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DB\\zayshop.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
