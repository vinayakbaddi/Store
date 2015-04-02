using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Store.FruitWeb.Startup))]
namespace Store.FruitWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
