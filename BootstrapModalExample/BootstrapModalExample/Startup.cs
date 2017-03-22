using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapModalExample.Startup))]
namespace BootstrapModalExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
