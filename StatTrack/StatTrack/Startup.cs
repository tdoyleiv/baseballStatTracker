using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StatTrack.Startup))]
namespace StatTrack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
