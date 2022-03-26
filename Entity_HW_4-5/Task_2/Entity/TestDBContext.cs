using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Task_2.Entity
{
    public class TestDBContext : DbContext
    {
        public DbSet<TestEntity> TestEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var UserSecrets = new ConfigurationBuilder()
                .AddUserSecrets<TestDBContext>()
                .Build();

            string ConnectionString = UserSecrets.GetConnectionString("ConStrTestDB");

            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
        }
    }
}

