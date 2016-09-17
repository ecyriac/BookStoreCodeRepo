using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJSASPNETMVCApp.Startup))]
namespace AngularJSASPNETMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
