using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlixView.Startup))]
namespace FlixView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
