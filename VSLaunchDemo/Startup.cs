using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSLaunchDemo.Startup))]
namespace VSLaunchDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
