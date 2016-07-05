using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git2.Startup))]
namespace Git2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
