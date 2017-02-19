using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Azuretry.Startup))]
namespace Azuretry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
