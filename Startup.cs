using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mis4200_SD.Startup))]
namespace Mis4200_SD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
