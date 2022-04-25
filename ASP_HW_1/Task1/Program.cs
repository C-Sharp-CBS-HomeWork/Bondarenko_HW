namespace Task1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Task.Run(() =>
            {
                hostBuilder(args).Build().Run();
            });
        }

        public static IHostBuilder hostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webHostBuilder =>
                {
                    webHostBuilder.UseStartup<Startup>();
                });
        }
    }
}
