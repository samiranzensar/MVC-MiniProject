using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BethanyPieShop.Startup))]
namespace BethanyPieShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
