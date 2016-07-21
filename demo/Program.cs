/********************************************************************************************************************************************
 * Copyright (C) 2016 Pieter-Uys Fourie
 * This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as 
 * published by the Free Software Foundation, either version 3 of the License, or any later version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty 
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License along with this program. If not, see 
 * http://www.gnu.org/licenses/.
 */

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
                Console.WriteLine(ping.Result);

                var parameters = new GetTvShowsParams()
                {
                    Properties = new string[]
                    {
                        TvShowProperties.Title,
                        TvShowProperties.Year
                    }
                };

                Console.WriteLine("Running VideoLibrary.GetTvShowDetails");

                var details = Service.GetTvShows(parameters);

                Console.WriteLine("ID.................{0}", details.Id);
                Console.WriteLine("JsonRPC............{0}", details.JsonRpc);
                Console.WriteLine("First.ShowTitle....{0}", details.Result.TvShows.First().Title);
                Console.WriteLine("First.Studio.......{0}", details.Result.TvShows.First().Premiered);
                Console.WriteLine("First.Premiered....{0}", details.Result.TvShows.First().Year);

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
