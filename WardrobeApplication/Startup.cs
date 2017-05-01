using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WardrobeApplication.Startup))]
namespace WardrobeApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
