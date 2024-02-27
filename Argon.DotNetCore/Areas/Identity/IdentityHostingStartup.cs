using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(AUTO.Argon.DotNetCore.Free.Areas.Identity.IdentityHostingStartup))]
namespace AUTO.Argon.DotNetCore.Free.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}