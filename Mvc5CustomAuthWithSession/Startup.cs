using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5CustomAuthWithSession.Startup))]
namespace Mvc5CustomAuthWithSession
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
