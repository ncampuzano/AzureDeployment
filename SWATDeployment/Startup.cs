using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SWATDeployment.Startup))]
namespace SWATDeployment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
