using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(examenenreddearealocal.Startup))]
namespace examenenreddearealocal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
