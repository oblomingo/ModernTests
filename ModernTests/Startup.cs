using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModernTests.Startup))]
namespace ModernTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
