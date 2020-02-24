using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L5R_DBH_MVC.Startup))]
namespace L5R_DBH_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
