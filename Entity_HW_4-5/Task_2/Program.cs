using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Task_2.Entity;

namespace Task_2
{
    public class Program
    {
        public async static Task Main()
        {
            using TestDBContext testDB = new TestDBContext();

            //TestEntity[] tests =
            //{
            //    new TestEntity() { Name ="First"},
            //    new TestEntity() { Name = "Second" },
            //    new TestEntity() { Name = "Third" },
            //    new TestEntity() { Name = "Fourth" },
            //    new TestEntity() { Name = "Fifth" },
            //    new TestEntity() { Name = "Sixth" }
            //};

            //testDB.AddRangeAsync(tests);

            //testDB.SaveChanges();

            Task.Run(async () =>
            {
                while (true)
                {
                    Console.Write("* ");
                    await Task.Delay(100);
                }        
            });

            SqlParameter ID = new SqlParameter()
            {
                ParameterName = "@paramID",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Int,
                Value = 6,
            };

            SqlParameter name = new SqlParameter()
            {
                ParameterName = "@paramName",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 40
            };
            await testDB.Database.ExecuteSqlRawAsync("dbo.FindName @paramID, @paramName OUT", ID, name);
            Console.WriteLine($"\nResult: {name.Value}");
        }
    }
}
