using System;
using KodiRPC.RPC.Specifications.Properties;
using KodiRPC.Services;

namespace DemoClient
{
    internal class Program
    {
        private const string LocalHost = "http://stark-industries.local";
        private const string RemoteHost = "http://localhost";

        private static readonly KodiService Service = new KodiService {Host=LocalHost, Port=8080, Username="kodi", Password="kodi"};

        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Connecting to Kodi JSON-RPC API/{0}.", Service.ApiVersion);
                Console.WriteLine("\tHost...........{0}:{1}", Service.Host, Service.Port);
                Console.WriteLine("\tUsername.......{0}", Service.Username);
                Console.WriteLine("\tPassword.......{0}", Service.Password);
                Console.WriteLine();
                Console.WriteLine("Pinging Kodi.");

                var ping = Service.Ping();
                Console.WriteLine(ping);

                //var properties = new[] { "title", "runtime" };
                var properties = GetMovieDetailsProperties.All();
                var details = Service.GetMovieDetails(12, properties);
                Console.WriteLine(details.Result.Title);

                NEKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception has occured: {0}", e.Message);
                NEKey();
            }
        }

        private static void NEKey()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
