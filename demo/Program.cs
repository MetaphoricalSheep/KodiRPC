using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodiRPC.Services;

namespace DemoClient
{
    internal class Program
    {
        private static KodiService Service = new KodiService {Host="http://stark-industries.local", Port=8080, Username="kodi", Password="kodi"};

        static void Main(string[] args)
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

                var v = Service.Version();
                Console.WriteLine($"Version {v.Major}.{v.Minor}.{v.Patch}");

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
