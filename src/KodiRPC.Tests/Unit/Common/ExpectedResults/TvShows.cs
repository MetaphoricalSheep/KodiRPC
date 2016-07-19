using System.Collections.Generic;
using System.Linq;
using KodiRPC.Responses.Types.Media;
using KodiRPC.Responses.Types.Video;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.Responses.VideoLibrary;

namespace KodiRPC.Tests.Unit.Common.ExpectedResults
{
    public class TvShows
    {
        public enum TestSet
        {
            MrRobot = 12,
            RickAndMorty = 40,
            TheAmericans = 62,
            InvalidId = int.MaxValue
        }

        public static List<GetTvShowDetailsResponse> GetTvShows()
        {
            var tvShows = new List<GetTvShowDetailsResponse>
            {
                new GetTvShowDetailsResponse
                {
                    TvShowDetails = new TvShow
                    {
                        Art = new Artwork
                        {
                            Banner = "image://http%3a%2f%2fthetvdb.com%2fbanners%2fgraphical%2f289590-g7.jpg/",
                            Fanart = "image://http%3a%2f%2fthetvdb.com%2fbanners%2ffanart%2foriginal%2f289590-2.jpg/",
                            Poster = "image://http%3a%2f%2fthetvdb.com%2fbanners%2fposters%2f289590-3.jpg/"
                        },
                        Cast = new[]
                        {
                            new Cast
                            {
                              Name = "Rami Malek",
                              Order = 0,
                              Role = "Elliot Alderson",
                              Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f341347.jpg/"
                            },
                            new Cast
                            {
                              Name = "Christian Slater",
                              Order = 1,
                              Role = "Mr. Robot",
                              Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f341348.jpg/"
                            },
                            new Cast
                            {
                              Name = "Portia Doubleday",
                              Order = 2,
                              Role = "Angela Moss",
                              Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f341349.jpg/"
                            }
                        },
                        DateAdded = "2015-09-03 05:15:41",
                        Episode = 10,
                        EpisodeGuide = "<episodeguide><url cache=\"289590-en.xml\">http://thetvdb.com/api/1D62F2F90030C444/series/289590/all/en.zip</url></episodeguide>",
                        Fanart = "image://http%3a%2f%2fthetvdb.com%2fbanners%2ffanart%2foriginal%2f289590-2.jpg/",
                        File = "/media/gotham/series/Mr. Robot/",
                        Genre = new[] { "Crime", "Drama", "Thriller" },
                        ImdbNumber = "289590",
                        Label = "Mr. Robot",
                        LastPlayed = "",
                        MPAA = "TV-14",
                        OriginalTitle = "",
                        Playcount = 0,
                        Plot = "The show follows Elliot, who is a cyber-security tech by day and vigilante hacker by night. He has used his hacking skills for justice and to protect those he cares about, but has problems connecting to people in the real world due to social anxiety. He strongly believes that the world is being ruled by the 1% of the 1% and, that using money and debt, they have enslaved mankind and he wishes desperately to change this. He is recruited by the head of a highly secret hacking group to take down the corporation he is being paid to protect with the hope of erasing 70% of all the debt in the world. He has had delusions in the past and sees a therapist who tries to help him and takes medication for it, but in the end he is unsure what is real and what is not, and so are we as we experience everything from his perspective.",
                        Premiered = "2015-06-24",
                        Rating = 8.800000190734863,
                        Season = 1,
                        SortTitle = "",
                        Studio = new[] { "USA Network" },
                        Tag = new string[] {},
                        Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2fposters%2f289590-3.jpg/",
                        Title = "Mr. Robot",
                        TvShowId = 12,
                        Votes = "64",
                        WatchedEpisodes = 0,
                        Year = 2015,
                    }
                },
                new GetTvShowDetailsResponse
                {
                    TvShowDetails = new TvShow
                    {
                        Art = new Artwork
                        {
                            Banner = "image://%2fmedia%2fgotham%2fseries%2fRick%20and%20Morty%2fbanner.jpg/",
                            Fanart = "image://%2fmedia%2fgotham%2fseries%2fRick%20and%20Morty%2ffanart.jpg/",
                            Poster = "image://%2fmedia%2fgotham%2fseries%2fRick%20and%20Morty%2fposter.jpg/"
                        },
                        Cast = new[]
                        {
                            new Cast
                            {
                                Name = "Justin Roiland",
                                Order = 0,
                                Role = "Rick|Morty",
                                Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f325163.jpg/"
                            },
                            new Cast
                            {
                              Name = "Chris Parnell",
                              Order = 1,
                              Role = "Jerry",
                              Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f325164.jpg/"
                            },
                            new Cast
                            {
                                Name = "Spencer Grammer",
                                Order = 2,
                                Role = "Summer",
                                Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f325165.jpg/"
                            }
                        },
                        DateAdded = "2015-10-23 00:48:00",
                        Episode = 21,
                        EpisodeGuide = "<episodeguide><url>http://thetvdb.com/api/9DAF49C96CBF8DAC/series/275274/all/en.zip</url></episodeguide>",
                        Fanart = "image://%2fmedia%2fgotham%2fseries%2fRick%20and%20Morty%2ffanart.jpg/",
                        File = "/media/gotham/series/Rick and Morty/",
                        Genre = new [] { "Animation", "Comedy", "Science-Fiction" },
                        ImdbNumber = "275274",
                        Label = "Rick and Morty",
                        LastPlayed = "",
                        MPAA = "TV-14",
                        OriginalTitle = "",
                        Playcount = 0,
                        Plot = "A sociopathic scientist drags his unintelligent grandson on insanely dangerous adventures across the universe.",
                        Premiered = "2013-12-02",
                        Rating = 8.899999618530273,
                        Season = 2,
                        SortTitle = "",
                        Studio = new[] { "Adult Swim" },
                        Tag = new string[] {},
                        Thumbnail = "image://%2fmedia%2fgotham%2fseries%2fRick%20and%20Morty%2fposter.jpg/",
                        Title = "Rick and Morty",
                        TvShowId = 40,
                        Votes = "",
                        WatchedEpisodes = 0,
                        Year = 2013
                    }
                },
                new GetTvShowDetailsResponse
                {
                    TvShowDetails = new TvShow
                    {
                        Art = new Artwork
                        {
                            Banner = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fbanner.jpg/",
                            Fanart = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2ffanart.jpg/",
                            Poster = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fposter.jpg/"
                        },
                        Cast = new[]
                        {
                            new Cast
                            {
                              Name = "Matthew Rhys",
                              Order = 0,
                              Role = "Phillip Jennings",
                              Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f305162.jpg/"
                            },
                            new Cast
                            {
                                Name = "Keri Russell",
                                Order = 1,
                                Role = "Elizabeth Jennings",
                                Thumbnail = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fx6TpFaS6p1v4o2gN2KWW24Osl9m.jpg/"
                            },
                            new Cast
                            {
                                Name = "Holly Taylor",
                                Order = 2,
                                Role = "Paige Jennings",
                                Thumbnail = "image://http%3a%2f%2fthetvdb.com%2fbanners%2factors%2f307203.jpg/"
                            }
                          },
                          DateAdded = "2015-04-23 05:12:07",
                          Episode = 39,
                          EpisodeGuide = "<episodeguide><url>http://thetvdb.com/api/9DAF49C96CBF8DAC/series/261690/all/en.zip</url></episodeguide>",
                          Fanart = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2ffanart.jpg/",
                          File = "/media/gotham/series/The Americans (2013)/",
                          Genre = new[] { "Crime", "Drama", "Mystery" },
                          ImdbNumber = "261690",
                          Label = "The Americans (2013)",
                          LastPlayed = "",
                          MPAA = "TV-MA",
                          OriginalTitle = "",
                          Playcount = 0,
                          Plot = "The Americans is a period drama about the complex marriage of two KGB spies posing as Americans in suburban Washington D.C. shortly after Ronald Reagan is elected President. The arranged marriage of Philip and Elizabeth Jennings, who have two children - 13-year-old Paige and 10-year-old Henry, who know nothing about their parents' true identity - grows more passionate and genuine by the day, but is constantly tested by the escalation of the Cold War and the intimate, dangerous and darkly funny relationships they must maintain with a network of spies and informants under their control.",
                          Premiered = "2013-01-30",
                          Rating = 8.300000190734863,
                          Season = 3,
                          SortTitle = "",
                          Studio = new[] { "FX" },
                          Tag = new string[] {},
                          Thumbnail = "image://%2fmedia%2fgotham%2fseries%2fThe%20Americans%20(2013)%2fposter.jpg/",
                          Title = "The Americans (2013)",
                          TvShowId = 62,
                          Votes = "",
                          WatchedEpisodes = 0,
                          Year = 2013
                    }
                }
            };

            return tvShows;
        }

        public static GetTvShowDetailsResponse GetTvShow(TestSet tvShowId)
        {
            var tvShows = GetTvShows();

            return tvShows.First(s => s.TvShowDetails.TvShowId == (int)tvShowId);
        }

        public static GetTvShowsResponse GetList()
        {
            return new GetTvShowsResponse
            {
                TvShows = new List<TvShow>
                {
                    new TvShow
                    {
                        Label = "Better Call Saul",
                        Title = "Better Call Saul",
                        TvShowId = 48,
                        Year = 2014
                    },
                    new TvShow
                    {
                        Label = "Doctor Who (2005)",
                        Title = "Doctor Who (2005)",
                        TvShowId = 49,
                        Year = 2005
                    },
                    new TvShow
                    {
                        Label = "DC's Legends of Tomorrow",
                        Title = "DC's Legends of Tomorrow",
                        TvShowId = 50,
                        Year = 0
                    }
                }
            };
        }
    }
}