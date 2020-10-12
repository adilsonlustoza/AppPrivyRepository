using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(AppPrivy.WebAppMvc.Areas.Identity.IdentityHostingStartup))]
namespace AppPrivy.WebAppMvc.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}