using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LifeChurchWeb.Startup))]
namespace LifeChurchWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
