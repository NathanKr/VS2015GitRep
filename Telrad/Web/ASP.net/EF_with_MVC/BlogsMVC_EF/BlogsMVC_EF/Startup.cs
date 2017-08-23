using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogsMVC_EF.Startup))]
namespace BlogsMVC_EF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
