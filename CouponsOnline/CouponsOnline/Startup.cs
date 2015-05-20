using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CouponsOnline.Startup))]
namespace CouponsOnline
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
