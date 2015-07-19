namespace Slight.UrlSharp.Server.Actors.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    [RoutePrefix("url")]
    public class UrlController : ApiController
    {
        [HttpGet, Route("stats")]
        public string Get()
        {
            return "";
        }
    }
}
