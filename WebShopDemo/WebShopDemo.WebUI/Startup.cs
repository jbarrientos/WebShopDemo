using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShopDemo.WebUI.Startup))]
namespace WebShopDemo.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
