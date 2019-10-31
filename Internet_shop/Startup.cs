using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Internet_shop.Startup))]
namespace Internet_shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
