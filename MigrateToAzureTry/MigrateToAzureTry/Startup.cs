using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MigrateToAzureTry.Startup))]
namespace MigrateToAzureTry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
