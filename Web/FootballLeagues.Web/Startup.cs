using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballLeagues.Web.Startup))]
namespace FootballLeagues.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
