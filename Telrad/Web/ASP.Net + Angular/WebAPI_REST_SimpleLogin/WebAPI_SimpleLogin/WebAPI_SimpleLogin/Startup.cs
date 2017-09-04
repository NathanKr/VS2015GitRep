using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAPI_SimpleLogin.Startup))]
namespace WebAPI_SimpleLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
