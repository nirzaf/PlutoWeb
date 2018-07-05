using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlutoWeb.Startup))]
namespace PlutoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
