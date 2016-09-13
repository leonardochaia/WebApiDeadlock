using System.Web.Http;

namespace WebApi3.Controllers
{
    [RoutePrefix("")]
    public class WebApi3Controller : ApiController
    {
        [Route(""), HttpGet]
        public string Get()
        {
            return "Web Api 3 Response";
        }
    }
}
