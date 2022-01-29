using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LegacyMVCApp.Startup))]
namespace LegacyMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
