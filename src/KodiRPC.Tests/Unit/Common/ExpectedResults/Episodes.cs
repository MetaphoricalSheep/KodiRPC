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
using System.Linq;
using KodiRPC.Responses.Types.Media;
using KodiRPC.Responses.Types.Video;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.Responses.Types.Video.Stream;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse.Params;

namespace KodiRPC.Tests.Unit.Common.ExpectedResults
{
    public class Episodes
    {
        public enum TestSet
        {
            OrphanBlack = 486,
            Dexter = 864,
            Continuum = 1010,
            InvalidId = int.MaxValue
        }

        public static List<GetEpisodeDetailsResponse> GetEpisodes()
        {
            var episodes = new List<GetEpisodeDetailsResponse>
            {
                new GetEpisodeDetailsResponse
                {
                    EpisodeDetails = new Episode
                    {
                        Art = new Artwork
                        {
                            //Banner = "image://http%3a%2f%2fthetvdb.com%2fbanners%2fgraphical%2f79349-g28.jpg/",
                            //Fanart = "image://http%3a%2f%2fthetvdb.com%2fbanners%2ffanart%2foriginal%2f79349-63.jpg/",
                            //Poster = "image://http%3a%2f%2fthetvdb.com%2fbanners%2fposters%2f79349-24.jpg/",
                            Thumb = "image://http%3a%2f%2fthetvdb.com%2fbanners%2fepisodes%2f79349%2f2755231.jpg/"
                        },
                        Cast = new[]
                        {
                            new Cast
                            {
                                Name = "Peter Weller",
                                Order = 0,
                                Role = ""
                            },
                            new Cast
                            {
                                Name = "Maria Doyle Kennedy",
                                Order = 1,
                                Role = "",
                                Thumbnail =
                                    "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2ft7wdC2MGTXEmvJ2LL42j6u6EIcG.jpg/"
                            },
                            new Cast
                            {
                                Name = "April L. Hernandez",
                                Order = 2,
                                Role = ""
                            },
                        },
                        DateAdded = "2015-03-03 03:40:10",
                        Director = new[] {"Steve Shill"},
                        EpisodeNumber = 6,
                        EpisodeId = 864,
                        Fanart = "image://http%3a%2f%2fthetvdb.com%2fbanners%2ffanart%2foriginal%2f79349-63.jpg/",
                        File = "/media/gotham/series/Dexter/Season 05/Dexter - S05E06 - Everything Is Illumenated.mkv",
                        FirstAired = "2010-10-31",
                        Label = "Everything Is Illumenated",
                        LastPlayed = "",
                        OriginalTitle = "",
                        Playcount = 0,
                        Plot =
                            "Dexter is drawn into a precarious situation; Batista discovers an interesting lead; Quinn gets information about Dexter from a questionable source.",
                        ProductionCode = "",
                        Rating = 8.0,
                        Resume = new Resume
                        {
                            Position = 0.0,
                            Total = 0.0
                        },
                        Runtime = 3600,
                        Season = 5,
                        ShowTitle = "Dexter",
                        StreamDetails = new Streams
                        {
                            Audio = new Audio[] {},
                            Subtitle = new Subtitle[] {},
                            Video = new Video[] {}
                        },
                        Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2fepisodes%2f79349%2f2755231.jpg/",
                        Title = "Everything Is Illumenated",
                        TvShowId = 30,
                        UniqueId = new UniqueId
                        {
                            Unknown = "2755231"
                        },
                        Votes = "290",
                        Writer = new[] {"Wendy West"}
                    }
                },
                new GetEpisodeDetailsResponse
                {
                    EpisodeDetails = new Episode
                    {
                        Art = new Artwork
                        {
                            //Banner = "image://%2fmedia%2fgotham%2fseries%2fOrphan%20Black%2fbanner.jpg/",
                            //Fanart = "image://%2fmedia%2fgotham%2fseries%2fOrphan%20Black%2ffanart.jpg/",
                            //Poster = "image://%2fmedia%2fgotham%2fseries%2fOrphan%20Black%2fposter.jpg/"
                            Thumb = "image://http%3a%2f%2fthetvdb.com%2fbanners%2fepisodes%2f260315%2f5147778.jpg/",
                        },
                        Cast = new[]
                        {
                            new Cast
                            {
                                Name = "Tatiana Maslany",
                                Order = 0,
                                Role = "Sarah Manning/Alison Hendrix/Cosima Niehaus/Helena/Rachel Duncan",
                                Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f310607.jpg/"
                            },
                            new Cast
                            {
                                Name = "Jordan Gavaris",
                                Order = 1,
                                Role = "Felix",
                                Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f308820.jpg/"
                            },
                            new Cast
                            {
                                Name = "Dylan Bruce",
                                Order = 2,
                                Role = "Paul Dierden",
                                Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f310600.jpg/"
                            }
                        },
                        DateAdded = "2015-04-26 14:56:37",
                        Director = new[] {"John Fawcett"},
                        EpisodeNumber = 2,
                        EpisodeId = 486,
                        Fanart = "image://%2fmedia%2fgotham%2fseries%2fOrphan%20Black%2ffanart.jpg/",
                        File =
                            "/media/gotham/series/Orphan Black/Season 03/Orphan Black - S03E02 - Transitory Sacrifices of Crisis.mkv",
                        FirstAired = "2015-04-25",
                        Label = "Transitory Sacrifices of Crisis",
                        LastPlayed = "",
                        OriginalTitle = "",
                        Playcount = 0,
                        Plot =
                            "Castor pursues the Leda clones for original tissue samples. Helena, who is pregnant and imprisoned, is examined by a mysterious new villain. The Castor boys are also out to play, toying with a frightened young woman, Patty, in a sexy switcheroo that ultimately sets Sarah \u2013 and Art \u2013 hot on the Castor trail. But it\u2019s not all fun and games for the Castor boys, as Sarah gleans they may have a mysterious defect that puts their lives in peril.",
                        ProductionCode = "",
                        Rating = 7.400000095367432,
                        Resume = new Resume
                        {
                            Position = 0.0,
                            Total = 0.0
                        },
                        Runtime = 2700,
                        Season = 3,
                        ShowTitle = "Orphan Black",
                        StreamDetails = new Streams
                        {
                            Audio = new Audio[] {},
                            Subtitle = new Subtitle[] {},
                            Video = new Video[] {}
                        },
                        Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2fepisodes%2f260315%2f5147778.jpg/",
                        Title = "Transitory Sacrifices of Crisis",
                        TvShowId = 17,
                        UniqueId = new UniqueId
                        {
                            Unknown = "5147778"
                        },
                        Votes = "14",
                        Writer = new[] {"Aubrey Nealon"},
                    }
                },
                new GetEpisodeDetailsResponse
                {
                    EpisodeDetails = new Episode
                    {
                        Art = new Artwork
                        {
                            //Banner = "image://%2fmedia%2fgotham%2fseries%2fContinuum%2fbanner.jpg/",
                            //Fanart = "image://%2fmedia%2fgotham%2fseries%2fContinuum%2ffanart.jpg/",
                            //Poster = "image://%2fmedia%2fgotham%2fseries%2fContinuum%2fposter.jpg/"
                            Thumb = "image://http%3a%2f%2fthetvdb.com%2fbanners%2fepisodes%2f258171%2f4307624.jpg/",
                        },
                        Cast = new[]
                        {
                            new Cast
                            {
                                Name = "Rachel Nichols",
                                Order = 0,
                                Role = "Kiera Cameron",
                                Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f297610.jpg/"
                            },
                            new Cast
                            {
                                Name = "Victor Webster",
                                Order = 1,
                                Role = "Carlos Fonnegra",
                                Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f297612.jpg/"
                            },
                            new Cast
                            {
                                Name = "Erik Knudsen",
                                Order = 2,
                                Role = "Alec Sadler",
                                Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f297611.jpg/"
                            }
                        },
                        DateAdded = "2015-03-25 10:49:32",
                        Director = new[] {"Paul Shapiro"},
                        EpisodeNumber = 8,
                        EpisodeId = 1010,
                        Fanart = "image://%2fmedia%2fgotham%2fseries%2fContinuum%2ffanart.jpg/",
                        File = "/media/gotham/series/Continuum/Season 01/Continuum - S01E08 - Playtime.mkv",
                        FirstAired = "2012-07-22",
                        Label = "Playtime",
                        LastPlayed = "",
                        OriginalTitle = "",
                        Playcount = 0,
                        Plot =
                            "When Kiera and Carlos investigate two mysterious murder-suicides, they quickly realize that both may be the result of a lethal computer program turning video game programmers into killers.",
                        ProductionCode = "",
                        Rating = 7.800000190734863,
                        Resume = new Resume
                        {
                            Position = 0.0,
                            Total = 0.0
                        },
                        Runtime = 2700,
                        Season = 1,
                        ShowTitle = "Continuum",
                        StreamDetails = new Streams
                        {
                            Audio = new Audio[] {},
                            Subtitle = new Subtitle[] {},
                            Video = new Video[] {}
                        },
                        Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2fepisodes%2f258171%2f4307624.jpg/",
                        Title = "Playtime",
                        TvShowId = 35,
                        UniqueId = new UniqueId
                        {
                            Unknown = "4307624"
                        },
                        Votes = "136",
                        Writer = new[] {"Andrea Stevens"}
                    }
                }
            };

            return episodes;
        }

        public static GetEpisodeDetailsResponse GetEpisode(TestSet episodeId)
        {
            var episodes = GetEpisodes();

            return episodes.First(e => e.EpisodeDetails.EpisodeId == (int)episodeId);
        }

        public static GetEpisodesResponse GetList()
        {
            return new GetEpisodesResponse
            {
                Limits = new Limits
                {
                    Start = 0,
                    End = 13,
                    Total = 13
                },
                Episodes = new List<Episode>
                {
                    new Episode
                    {
                        EpisodeId = 683,
                        Label = "1x01. Into the Ring",
                        Title = "Into the Ring"
                    },
                    new Episode
                    {
                        EpisodeId = 684,
                        Label = "1x02. Cut Man",
                        Title = "Cut Man"
                    },
                    new Episode
                    {
                        EpisodeId = 685,
                        Label = "1x03. Rabbit in a Snow Storm",
                        Title = "Rabbit in a Snow Storm"
                    },
                    new Episode
                    {
                        EpisodeId = 686,
                        Label = "1x04. In the Blood",
                        Title = "In the Blood"
                    },
                    new Episode
                    {
                        EpisodeId = 687,
                        Label = "1x05. World on Fire",
                        Title = "World on Fire"
                    },
                    new Episode
                    {
                        EpisodeId = 688,
                        Label = "1x06. Condemned",
                        Title = "Condemned"
                    },
                    new Episode
                    {
                        EpisodeId = 689,
                        Label = "1x07. Stick",
                        Title = "Stick"
                    },
                    new Episode
                    {
                        EpisodeId = 690,
                        Label = "1x08. Shadows in the Glass",
                        Title = "Shadows in the Glass"
                    },
                    new Episode
                    {
                        EpisodeId = 691,
                        Label = "1x09. Speak of the Devil",
                        Title = "Speak of the Devil"
                    },
                    new Episode
                    {
                        EpisodeId = 692,
                        Label = "1x10. Nelson v. Murdock",
                        Title = "Nelson v. Murdock"
                    },
                    new Episode
                    {
                        EpisodeId = 693,
                        Label = "1x11. The Path of the Righteous",
                        Title = "The Path of the Righteous"
                    },
                    new Episode
                    {
                        EpisodeId = 694,
                        Label = "1x12. The Ones We Leave Behind",
                        Title = "The Ones We Leave Behind"
                    },
                    new Episode
                    {
                        EpisodeId = 695,
                        Label = "1x13. Daredevil",
                        Title = "Daredevil"
                    }
                }
            };
        }
    }
}