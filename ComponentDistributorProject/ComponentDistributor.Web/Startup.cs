using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComponentDistributor.Web.Startup))]
namespace ComponentDistributor.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
