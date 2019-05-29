using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200398762CarRental.Startup))]
namespace _200398762CarRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
