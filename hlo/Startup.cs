using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hlo.Startup))]
namespace hlo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
