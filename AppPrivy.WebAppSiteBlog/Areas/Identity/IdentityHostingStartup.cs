using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(AppPrivy.WebAppSiteBlog.Areas.Identity.IdentityHostingStartup))]
namespace AppPrivy.WebAppSiteBlog.Areas.Identity
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