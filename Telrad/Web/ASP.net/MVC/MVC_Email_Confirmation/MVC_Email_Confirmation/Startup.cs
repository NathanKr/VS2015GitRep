using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Email_Confirmation.Startup))]
namespace MVC_Email_Confirmation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
