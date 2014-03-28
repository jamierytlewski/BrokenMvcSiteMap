using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrokenMvcSiteMap.Startup))]
namespace BrokenMvcSiteMap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
