using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Softtek.MVC.Startup))]
namespace Softtek.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
