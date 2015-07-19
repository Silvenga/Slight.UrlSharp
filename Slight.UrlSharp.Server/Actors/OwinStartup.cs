namespace Slight.UrlSharp.Server.Actors
{
    using System.Diagnostics.CodeAnalysis;
    using System.Web.Http;

    using Owin;

    public class Startup
    {
        [SuppressMessage("ReSharper", "UnusedMember.Global")]
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            appBuilder.UseWebApi(config);
        }
    }
}
