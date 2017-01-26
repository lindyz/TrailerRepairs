using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrailerRepairs.Startup))]
namespace TrailerRepairs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
