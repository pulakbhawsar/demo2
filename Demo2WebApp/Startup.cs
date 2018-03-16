using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo2WebApp.Startup))]
namespace Demo2WebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
