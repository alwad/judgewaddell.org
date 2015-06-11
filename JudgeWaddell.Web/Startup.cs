using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(judgewaddell.org.Startup))]
namespace judgewaddell.org
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
