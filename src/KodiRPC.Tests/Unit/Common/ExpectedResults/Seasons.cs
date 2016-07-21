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
using KodiRPC.Responses.Types.Media;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse.Params;

namespace KodiRPC.Tests.Unit.Common.ExpectedResults
{
    public class Seasons
    {
        public static GetSeasonsResponse GetList()
        {
            return new GetSeasonsResponse
            {
                Limits = new Limits
                {
                    Start = 0,
                    End = 3,
                    Total = 3
                },
                Seasons = new List<Season>
                {
                    new Season
                    {
                        Art = new Artwork
                        {
                            Poster =
                                "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fseason01-poster.jpg/",
                            //Banner = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fbanner.jpg/",
                            //Fanart = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2ffanart.jpg/",
                            //Poster = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fposter.jpg/"
                        },
                        Episode = 13,
                        Fanart = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2ffanart.jpg/",
                        Label = "Season 1",
                        Playcount = 0,
                        SeasonNumber = 1,
                        SeasonId = 380,
                        ShowTitle = "The Americans (2013)",
                        Thumbnail =
                            "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fseason01-poster.jpg/",
                        TvShowId = 62,
                        WatchedEpisodes = 0
                    },
                    new Season
                    {
                        Art = new Artwork
                        {
                            Poster =
                                "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fseason02-poster.jpg/",
                            //Banner = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fbanner.jpg/",
                            //Fanart = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2ffanart.jpg/",
                            //Poster = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fposter.jpg/"
                        },
                        Episode = 13,
                        Fanart = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2ffanart.jpg/",
                        Label = "Season 2",
                        Playcount = 0,
                        SeasonNumber = 2,
                        SeasonId = 381,
                        ShowTitle = "The Americans (2013)",
                        Thumbnail =
                            "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fseason02-poster.jpg/",
                        TvShowId = 62,
                        WatchedEpisodes = 0
                    },
                    new Season
                    {
                        Art = new Artwork
                        {
                            Poster =
                                "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fseason03-poster.jpg/",
                            //Banner = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fbanner.jpg/",
                            //Fanart = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2ffanart.jpg/",
                            //Poster = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fposter.jpg/"
                        },
                        Episode = 13,
                        Fanart = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2ffanart.jpg/",
                        Label = "Season 3",
                        Playcount = 0,
                        SeasonNumber = 3,
                        SeasonId = 382,
                        ShowTitle = "The Americans (2013)",
                        Thumbnail =
                            "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fseason03-poster.jpg/",
                        TvShowId = 62,
                        WatchedEpisodes = 0
                    }
                }
            };
        }
    }
}