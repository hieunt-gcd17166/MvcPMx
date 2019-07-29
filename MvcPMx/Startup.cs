using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPMx.Startup))]
namespace MvcPMx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
