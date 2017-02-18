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
using Params = KodiRPC.RPC.RequestResponse.Params;
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

                var parameters = new Params.VideoLibrary.GetTvShowDetailsParams()
                {
                    TvShowId = 1,
                    //Properties = new[] {TvShowProperties.Title, TvShowProperties.Premiered, TvShowProperties.Year}
                    Properties = TvShowProperties.All()
                };

                Console.WriteLine();
                Console.WriteLine("Running VideoLibrary.GetTvShowDetails");

                var details = Service.GetTvShowDetails(parameters);

                Console.WriteLine("ID.................{0}", details.Id);
                Console.WriteLine("JsonRPC............{0}", details.JsonRpc);
                Console.WriteLine("ShowTitle..........{0}", details.Result.TvShowDetails.Title);
                Console.WriteLine("Studio.............{0}", details.Result.TvShowDetails.Premiered);
                Console.WriteLine("Premiered..........{0}", details.Result.TvShowDetails.Year);
                Console.WriteLine("Fanart.............{0}", details.Result.TvShowDetails.Fanart);
                Console.WriteLine("File...............{0}", details.Result.TvShowDetails.File);
                Console.WriteLine();

                Console.WriteLine();
                Console.Write("Scanning for new content...");
                var scan = Service.Scan(new Params.VideoLibrary.ScanParams());
                Console.WriteLine(scan.Result);

                Console.WriteLine();
                Console.Write("Cleaning...");
                var clean = Service.Clean(new Params.VideoLibrary.CleanParams());
                Console.WriteLine(clean.Result);

                Console.WriteLine();
                Console.WriteLine("Getting File details");

                var fileDetailParams = new Params.Files.GetFileDetailsParams()
                {
                    File = "/media/gotham/series/Dark Matter/Season 02/Dark Matter - S02E03 - I’ve Seen the Other Side of You.mkv",
                    Properties = FileProperties.All()
                };

                Console.WriteLine();
                var fileDetails = Service.GetFileDetails(fileDetailParams);

                Console.WriteLine("File..............{0}", fileDetails.Result.FileDetails.FilePath);
                Console.WriteLine("FileName..........{0}", fileDetails.Result.FileDetails.Label);
                Console.WriteLine("MimeType..........{0}", fileDetails.Result.FileDetails.MimeType);
                Console.WriteLine("Size..............{0}", fileDetails.Result.FileDetails.Size);

                Console.WriteLine();
                Console.WriteLine("Preparing file for download");
                var prepareDownloadParam = new Params.Files.PrepareDownloadParams()
                {
                    Path = details.Result.TvShowDetails.Fanart
                    //Path = fileDetails.Result.FileDetails.FilePath
                };
                var prepareDownload = Service.PrepareDownload(prepareDownloadParam);
                Console.WriteLine("Details...........{0}", prepareDownload.Result.Details.Path);
                Console.WriteLine("Protocol..........{0}", prepareDownload.Result.Protocol);
                Console.WriteLine("Mode..............{0}", prepareDownload.Result.Mode);

                Console.WriteLine();
                Console.WriteLine("Download");
                var downloadParam = new Params.Files.DownloadParams()
                {
                    Path = details.Result.TvShowDetails.Fanart
                    //Path = fileDetails.Result.FileDetails.FilePath
                };
                var download = Service.Download(downloadParam);
                Console.WriteLine("Details...........{0}", download.Result);

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
