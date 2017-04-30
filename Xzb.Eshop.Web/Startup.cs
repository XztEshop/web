using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Xzb.Eshop.Web.Startup))]
namespace Xzb.Eshop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
