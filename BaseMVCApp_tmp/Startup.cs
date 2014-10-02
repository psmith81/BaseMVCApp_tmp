using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseMVCApp_tmp.Startup))]
namespace BaseMVCApp_tmp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
