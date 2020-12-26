using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Reflection;

namespace AppPrivy.WebAppApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                             .Enrich.FromLogContext()
                             .MinimumLevel.Verbose()
                             .WriteTo.Console()
                             .WriteTo.File($"Logs\\{Assembly.GetCallingAssembly().GetName().Name}.txt", rollingInterval: RollingInterval.Day)
                             .CreateLogger();

            try
            {

                Log.Information("Starting up");

                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application start-up failed");
            }
            finally
            {
                Log.CloseAndFlush();
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                .UseDotNurseInjector()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
