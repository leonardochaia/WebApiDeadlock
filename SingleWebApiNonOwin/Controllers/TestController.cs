using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SingleWebApiNonOwin.Controllers
{
    [RoutePrefix("")]
    public class TestController : ApiController
    {
        static HttpClient httpClient = new HttpClient();

        [HttpGet, Route("")]
        public async Task<dynamic> Test()
        {
            return await httpClient.GetAsync("http://localhost/SingleWebApiNonOwin/test2");
        }

        [HttpGet, Route("test2")]
        public async Task<dynamic> Test2()
        {
            return await httpClient.GetAsync("http://localhost/SingleWebApiNonOwin/test3");
        }

        [HttpGet, Route("test3")]
        public IEnumerable<string> Test3()
        {
            return new string[] { "value1", "value2" };
        }

    }
}
