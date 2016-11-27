using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModelViewControllerExample.Startup))]
namespace ModelViewControllerExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
