using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gamma.IisLayer.Startup))]
namespace Gamma.IisLayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
