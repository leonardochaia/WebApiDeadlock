using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApi1.Startup))]

namespace WebApi1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWebApi(WebApiConfig.Register());
        }
    }
}
