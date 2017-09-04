using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_With_EF.Startup))]
namespace MVC_With_EF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
