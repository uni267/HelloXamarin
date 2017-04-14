using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HallowXamarinWorld.MobileAppService.Startup))]

namespace HallowXamarinWorld.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}