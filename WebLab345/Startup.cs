using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebLab345.Startup))]
namespace WebLab345
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
