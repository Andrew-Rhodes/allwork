using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TinyMCETest.Startup))]
namespace TinyMCETest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
