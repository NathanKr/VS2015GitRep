using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureMvcAuthSqlDB.Startup))]
namespace AzureMvcAuthSqlDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
