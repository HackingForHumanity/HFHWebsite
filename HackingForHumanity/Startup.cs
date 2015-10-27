using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackingForHumanity.Startup))]
namespace HackingForHumanity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
