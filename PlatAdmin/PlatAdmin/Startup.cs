using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlatAdmin.Startup))]
namespace PlatAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
