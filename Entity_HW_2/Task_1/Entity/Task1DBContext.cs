using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Task_1.Entity
{
    public class Task1DBContext : DbContext 
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Curse> Curses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<Task1DBContext>()
                .Build();

            string connectStr = builder.GetConnectionString("ConnectDBTask1");

            optionsBuilder.UseSqlServer(connectStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfiguringCurse());
            modelBuilder.ApplyConfiguration(new ConfiguringAuthor());
        }
    }
}
