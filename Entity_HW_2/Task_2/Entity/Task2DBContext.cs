using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Task_2.Entity
{
    public class Task2DBContext : DbContext
    {
        public DbSet<FirstEntity> FirstEntities { get; set; }
        public DbSet<SecondEntity> SecondEntities { get; set; }
        public DbSet<ThirdEntity> ThirdEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConfigurationBuilder = new ConfigurationBuilder()
                .AddUserSecrets<Task2DBContext>()
                .Build();

            string connectionString = ConfigurationBuilder.GetConnectionString("ConnectStrDBTask2");

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FirstEntityConfiguratin());
            modelBuilder.ApplyConfiguration(new SecondEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ThirdEntityConfiguration());
        }
    }
}
