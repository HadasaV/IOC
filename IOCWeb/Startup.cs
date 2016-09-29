using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IOCWeb.Startup))]
namespace IOCWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
