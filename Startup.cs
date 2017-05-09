using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleC29CrudApp.Startup))]
namespace GoogleC29CrudApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
