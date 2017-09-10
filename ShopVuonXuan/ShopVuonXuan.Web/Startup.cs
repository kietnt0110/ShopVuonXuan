using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopVuonXuan.Web.Startup))]
namespace ShopVuonXuan.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
