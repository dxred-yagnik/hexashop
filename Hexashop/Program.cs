using EPiServer.Logging.Compatibility;
using Serilog;
using Serilog.Formatting.Compact;

namespace Hexashop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Information()
               .WriteTo.Debug(new RenderedCompactJsonFormatter())
               .WriteTo.File("app_data/log.txt", rollingInterval: RollingInterval.Day)
               .CreateLogger();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
                .ConfigureCmsDefaults()
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }
}
