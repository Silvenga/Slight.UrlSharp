namespace Slight.UrlSharp.Server
{
    using System;
    using System.Net.Http;

    using Microsoft.Owin.Hosting;

    using Slight.UrlSharp.Server.Actors;

    static class Program
    {
        static void Main(string[] args)
        {
            const string baseAddress = "http://localhost:9001/";

            using (WebApp.Start<Startup>(baseAddress))
            {
                Console.WriteLine("Ready for requests.");
                Console.ReadLine();
            }
        }
    }
}
