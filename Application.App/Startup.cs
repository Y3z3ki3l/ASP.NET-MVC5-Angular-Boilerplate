using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Application.App.Startup))]
namespace Application.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
