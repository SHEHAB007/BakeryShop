using BakeryShop.Data.Configurations;
using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryShop.Data
{
    public class BakeryShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = BakeryDb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Will apply configuration in ProductConfiguration => Migration (when using fluent)&& while seeding
            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }
    }
}
