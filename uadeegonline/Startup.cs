using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(uadeegonline.Startup))]
namespace uadeegonline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
