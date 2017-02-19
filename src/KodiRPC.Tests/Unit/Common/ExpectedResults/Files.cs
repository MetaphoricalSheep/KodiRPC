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

using KodiRPC.Responses.Files;
using KodiRPC.Responses.Types.List.Item;

namespace KodiRPC.Tests.Unit.Common.ExpectedResults
{
    public static class Files
    {
        public enum TestSet
        {
            BigHero6 = 12,
            WolfOfWallStreet = 100,
            Spy = 77,
            InvalidId = int.MaxValue
        }

        public static GetFileDetailsResponse GetFileDetails()
        {
            var file = new GetFileDetailsResponse
            {
                FileDetails = new File()
                {
                    FilePath = "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E01 - Episode One.mkv",
                    Label = "Dark Matter - S01E01 - Episode One.mkv",
                    LastModified = "2015-06-14 17:30:15",
                    MimeType = "video/x-matroska",
                    Size = 1439978796,
                    FileType = "unknown"
                }
            };

            return file;
        }
    }
}
