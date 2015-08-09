using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(michalaresSite.Startup))]
namespace michalaresSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
