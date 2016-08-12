using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalWebPortfolio.Startup))]
namespace PersonalWebPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
