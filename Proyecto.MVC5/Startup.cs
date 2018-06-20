using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proyecto.MVC5.Startup))]
namespace Proyecto.MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
