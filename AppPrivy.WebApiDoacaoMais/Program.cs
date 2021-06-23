using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Reflection;

namespace AppPrivy.WebApiDoacaoMais
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Log.Logger = new LoggerConfiguration()
                             .Enrich.FromLogContext()
                             .MinimumLevel.Information()
                             .WriteTo.Console()
                             .WriteTo.File($"Logs\\{Assembly.GetCallingAssembly().GetName().Name}-.txt", rollingInterval: RollingInterval.Day)
                             .CreateLogger();

            try
            {

                Log.Information($"Starting up {DateTime.Now.ToString("yyyyMMddHHmmss")}");

                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, $"Application start-up failed :{ DateTime.Now.ToString("yyyyMMddHHmmss")}");
             
            }
            finally
            {
                Log.CloseAndFlush();
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}