using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PayPalMvcExample.Startup))]
namespace PayPalMvcExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
