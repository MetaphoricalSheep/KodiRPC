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

using System.Collections.Generic;
using KodiRPC.Responses.Files;
using KodiRPC.Responses.Types.List;
using KodiRPC.Responses.Types.List.Item;

namespace KodiRPC.TesTs.Unit.Common.ExpectedResults
{
    public static class Directories
    {
        public enum TestSet
        {
        }

        public static GetDirectoryResponse GetDirectory()
        {
            return new GetDirectoryResponse
            {
                Files = new List<File>
                {
                    new File
                    {
                        FilePath = "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E04 - Episode Four.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E04 - Episode Four.mkv",
                        LastModified = "2015-07-04 12:37:24",
                        MimeType = "video/x-matroska",
                        Size = 1410543207,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath =
                            "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E11 - Episode Eleven.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E11 - Episode Eleven.mkv",
                        LastModified = "2015-08-22 05:12:15",
                        MimeType = "video/x-matroska",
                        Size = 907988214,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath =
                            "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E13 - Episode Thirteen.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E13 - Episode Thirteen.mkv",
                        LastModified = "2015-08-29 05:02:46",
                        MimeType = "video/x-matroska",
                        Size = 955547153,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath = "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E01 - Episode One.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E01 - Episode One.mkv",
                        LastModified = "2015-06-14 17:30:15",
                        MimeType = "video/x-matroska",
                        Size = 1439978796,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath = "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E08 - Episode Eight.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E08 - Episode Eight.mkv",
                        LastModified = "2015-08-01 05:04:49",
                        MimeType = "video/x-matroska",
                        Size = 895492511,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath =
                            "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E12 - Episode Twelve.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E12 - Episode Twelve.mkv",
                        LastModified = "2015-08-29 04:03:18",
                        MimeType = "video/x-matroska",
                        Size = 990706825,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath = "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E03 - Episode Three.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E03 - Episode Three.mkv",
                        LastModified = "2015-06-27 12:51:26",
                        MimeType = "video/x-matroska",
                        Size = 1410542601,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath = "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E10 - Episode Ten.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E10 - Episode Ten.mkv",
                        LastModified = "2015-08-15 05:03:23",
                        MimeType = "video/x-matroska",
                        Size = 957523849,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath = "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E09 - Episode Nine.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E09 - Episode Nine.mkv",
                        LastModified = "2015-08-08 05:01:31",
                        MimeType = "video/x-matroska",
                        Size = 1001177194,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath = "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E07 - Episode Seven.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E07 - Episode Seven.mkv",
                        LastModified = "2015-07-25 05:01:44",
                        MimeType = "video/x-matroska",
                        Size = 986002435,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath = "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E06 - Episode Six.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E06 - Episode Six.mkv",
                        LastModified = "2015-07-18 05:02:57",
                        MimeType = "video/x-matroska",
                        Size = 858212167,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath = "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E02 - Episode Two.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E02 - Episode Two.mkv",
                        LastModified = "2015-06-20 11:31:52",
                        MimeType = "video/x-matroska",
                        Size = 1421835721,
                        Type = "unknown"
                    },
                    new File
                    {
                        FilePath = "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E05 - Episode Five.mkv",
                        FileType = "file",
                        Label = "Dark Matter - S01E05 - Episode Five.mkv",
                        LastModified = "2015-07-11 16:54:24",
                        MimeType = "video/x-matroska",
                        Size = 1426445056,
                        Type = "unknown"
                    }
                },
                Limits = new LimitsReturned
                {
                    Limits = 13,
                    Start = 0,
                    Total = 13
                }
            };
        }
    }
}
