using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ShopProjectProductAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.ConfigureKestrel(serverOptions =>
                    {
                        serverOptions.ListenAnyIP(80); // Lắng nghe tất cả địa chỉ IP trên cổng 80
                    });
                });
    }
}
