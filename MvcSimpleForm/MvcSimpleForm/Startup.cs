using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSimpleForm.Startup))]
namespace MvcSimpleForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
