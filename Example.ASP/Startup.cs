using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Example.ASP.Startup))]
namespace Example.ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
