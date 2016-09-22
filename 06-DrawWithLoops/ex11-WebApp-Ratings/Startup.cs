using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ex11_WebApp_Ratings.Startup))]
namespace ex11_WebApp_Ratings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
