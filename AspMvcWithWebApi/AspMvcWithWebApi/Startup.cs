using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspMvcWithWebApi.Startup))]
namespace AspMvcWithWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
