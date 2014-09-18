using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SVNManager.Startup))]
namespace SVNManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
