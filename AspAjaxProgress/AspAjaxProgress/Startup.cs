using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspAjaxProgress.Startup))]
namespace AspAjaxProgress
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
