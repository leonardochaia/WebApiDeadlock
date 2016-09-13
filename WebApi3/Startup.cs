using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApi3.Startup))]

namespace WebApi3
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWebApi(WebApiConfig.Register());
        }
    }
}
