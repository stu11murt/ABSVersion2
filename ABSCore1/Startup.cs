using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ABSCore1.Startup))]
namespace ABSCore1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
