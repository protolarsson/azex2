using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(azex2.Startup))]
namespace azex2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
