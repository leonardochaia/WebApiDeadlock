using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi2.Controllers
{
    [RoutePrefix("")]
    public class WebApi2Controller : ApiController
    {
        static HttpClient httpClient = new HttpClient();

        [Route(""), HttpGet]
        public Task<HttpResponseMessage> Get()
        {
            return httpClient.GetAsync("http://localhost/test/webapi3");
        }

        //[Route(""), HttpGet]
        //public string Get()
        //{
        //    // Create a request for the URL. 
        //    var request = WebRequest.CreateHttp("http://localhost/test/webapi3");
        //    // If required by the server, set the credentials.
        //    request.Credentials = CredentialCache.DefaultCredentials;
        //    // Get the response.
        //    WebResponse response = request.GetResponse();
        //    // Display the status.
        //    Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        //    // Get the stream containing content returned by the server.
        //    Stream dataStream = response.GetResponseStream();
        //    // Open the stream using a StreamReader for easy access.
        //    StreamReader reader = new StreamReader(dataStream);
        //    // Read the content.
        //    string responseFromServer = reader.ReadToEnd();
        //    // Display the content.
        //    Console.WriteLine(responseFromServer);
        //    // Clean up the streams and the response.
        //    reader.Close();
        //    response.Close();
        //    return responseFromServer;
        //}
    }
}
