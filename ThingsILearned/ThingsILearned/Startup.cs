using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThingsILearned.Startup))]
namespace ThingsILearned
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
