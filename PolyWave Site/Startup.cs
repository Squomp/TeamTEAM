using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PolyWave_Site.Startup))]
namespace PolyWave_Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
