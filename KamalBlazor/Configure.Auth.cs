using ServiceStack.Auth;
using KamalBlazor.Data;

[assembly: HostingStartup(typeof(KamalBlazor.ConfigureAuth))]

namespace KamalBlazor;

public class ConfigureAuth : IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services =>
        {
            services.AddPlugin(new AuthFeature(IdentityAuth.For<ApplicationUser>(options => {
                options.SessionFactory = () => new CustomUserSession();
                options.CredentialsAuth();
                options.AdminUsersFeature();
            })));
        });
}
