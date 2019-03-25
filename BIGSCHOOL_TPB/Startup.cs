using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BIGSCHOOL_TPB.Startup))]
namespace BIGSCHOOL_TPB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
