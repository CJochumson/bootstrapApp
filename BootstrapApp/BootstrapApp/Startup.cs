using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapApp.Startup))]
namespace BootstrapApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
