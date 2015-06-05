using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JibesoftTest.Startup))]
namespace JibesoftTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
