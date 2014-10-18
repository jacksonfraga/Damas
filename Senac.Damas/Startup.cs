using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Senac.Damas.Startup))]
namespace Senac.Damas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
