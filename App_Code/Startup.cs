using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teste_git.Startup))]
namespace teste_git
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
