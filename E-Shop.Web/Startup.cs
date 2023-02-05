using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Shop.Web.Startup))]
namespace E_Shop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
