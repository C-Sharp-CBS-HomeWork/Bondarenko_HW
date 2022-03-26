using Task_1.Entity;

namespace Task_1
{
    public class Program
    {
        public static void Main()
        {
            using ShopDBContext shopDB = new ShopDBContext();
            //Product[] products =
            //{
            //    new Product { ProductName = "MacBook", Price = 33000.50m, Count = 92 },
            //    new Product { ProductName = "IPhone X", Price = 29500.50m, Count = 231 },
            //    new Product { ProductName = "Mouse X7", Price = 790, Count = 23 },
            //    new Product { ProductName = "Dell Latitude", Price = 17400, Count = 113 },
            //    new Product { ProductName = "Dell inspiron", Price = 21340, Count = 94 },
            //};

            //shopDB.AddRangeAsync(products);

            //shopDB.SaveChanges();

            var products = shopDB.Products.ToArray();

            foreach (var p in products)
                Console.WriteLine($"{p.ID}. {p.ProductName}{Environment.NewLine}" +
                    $"   Price: {p.Price}{Environment.NewLine}" +
                    $"   Count: {p.Count}{Environment.NewLine}");
            
        }
    }
}
