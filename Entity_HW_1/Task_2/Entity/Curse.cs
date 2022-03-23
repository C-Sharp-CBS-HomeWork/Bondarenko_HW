using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace Task_2.Entity
{
    public class Curse
    {
        public int Id { get; set; }
        public string _Curse { get; set; }
        public int Count { get; set; }

    }


    public class CursesDBContext :  DbContext
    {
        public DbSet<Curse> Curse { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<CursesDBContext>()
                .Build();

            string ConnectionString = builder.GetConnectionString("EFConnectToDatabase");

            optionsBuilder.UseSqlServer(ConnectionString);
        }
    
    }
}
