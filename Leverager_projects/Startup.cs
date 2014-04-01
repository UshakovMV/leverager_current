using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Leverager_projects.Startup))]
namespace Leverager_projects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
