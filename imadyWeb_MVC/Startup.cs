using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(imadyWeb_MVC.Startup))]
namespace imadyWeb_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
