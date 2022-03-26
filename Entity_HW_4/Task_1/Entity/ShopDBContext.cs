using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Task_1.Entity
{
    public class ShopDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var UserSecrets = new ConfigurationBuilder()
                .AddUserSecrets<ShopDBContext>()
                .Build();

            string ConnectionString = UserSecrets.GetConnectionString("ConStrShopDB");

            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
        }
    }
}

