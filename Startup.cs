using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gym_Management_Website.Startup))]
namespace Gym_Management_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
