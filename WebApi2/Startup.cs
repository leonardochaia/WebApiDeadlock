using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApi2.Startup))]

namespace WebApi2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWebApi(WebApiConfig.Register());
        }
    }
}
