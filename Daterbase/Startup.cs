using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Daterbase.Startup))]
namespace Daterbase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
