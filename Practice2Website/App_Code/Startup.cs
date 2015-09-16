using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practice2Website.Startup))]
namespace Practice2Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
