using System;
using System.Linq;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties;
using KodiRPC.Services;

namespace DemoClient
{
    internal class Program
    {
        private static readonly KodiService Service = new KodiService();

        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Connecting to Kodi JSON-RPC API/{0}.", Service.ApiVersion);
                Console.WriteLine("\tHost...........{0}:{1}", Service.Host, Service.Port);
                Console.WriteLine("\tUsername.......{0}", Service.Username);
                Console.WriteLine("\tPassword.......{0}", Service.Password);
                Console.WriteLine();
                Console.Write("Pinging Kodi....");

                var ping = Service.Ping();
                Console.WriteLine(ping);

                var parameters = new GetRecentlyAddedMoviesParams()
                {
                    Properties = MovieProperties.All()
                };

                Console.WriteLine("Running VideoLibrary.GetEpisodes");

                var details = Service.GetRecentlyAddedMovies(parameters);

                Console.WriteLine("First.ShowTitle....{0}", details.Result.First().Title);
                Console.WriteLine("First.Studio.......{0}", details.Result.First().Studio.First());

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
