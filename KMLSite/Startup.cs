using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KMLSite.Startup))]
namespace KMLSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
