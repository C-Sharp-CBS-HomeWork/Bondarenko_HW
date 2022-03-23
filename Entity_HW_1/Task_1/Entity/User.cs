using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Task_1.Entity
{
    public class MyTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class MyDatabaseContext : DbContext
    {
        public DbSet<MyTable> MyTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<MyDatabaseContext>()
                .Build();

            string ConnectionString = config.GetConnectionString("ConnectionString");

            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
