using System.Collections.Generic;
using KodiRPC.Responses.Types.Media;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.Responses.VideoLibrary;

namespace KodiRPC.Tests.Unit.Common.ExpectedResults
{
    public class Seasons
    {
        public static GetSeasonsResponse GetList()
        {
            return new GetSeasonsResponse
            {
                Result = new List<Season>
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