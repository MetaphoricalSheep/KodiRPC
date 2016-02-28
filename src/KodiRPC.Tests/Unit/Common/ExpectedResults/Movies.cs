using System.Collections.Generic;
using System.Linq;
using KodiRPC.Responses.Types.Media;
using KodiRPC.Responses.Types.Video;
using Stream = KodiRPC.Responses.Types.Video.Stream;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.Responses.VideoLibrary;

namespace KodiRPC.Tests.Unit.Common.ExpectedResults
{
    public static class Movies
    {
        public enum TestSet
        {
            BigHero6 = 12,
            WolfOfWallStreet = 100,
            Spy = 77
        }

        public static List<GetMovieDetailsResponse> GetMovies()
        {
            var movies = new List<GetMovieDetailsResponse>
            {
                new GetMovieDetailsResponse
                {
                    Result = new Movie
                    {
                        ImdbNumber = "tt2245084",
                        MovieId = 12,
                        Title = "Big Hero 6",
                        Cast = new[]
                        {
                            new Cast
                            {
                                Name = "Scott Adsit",
                                Order = 0,
                                Role = "Baymax (voice)",
                                Thumbnail =
                                    "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2f8VTCE0c8RSLYsgRqA8UDPRbBvYm.jpg/"
                            },
                            new Cast
                            {
                                Name = "Ryan Potter",
                                Order = 1,
                                Role = "Hiro Hamada (voice)",
                                Thumbnail =
                                    "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2flKC6fdpcLaYJpDEQxitByUJQQZq.jpg/"
                            },
                            new Cast
                            {
                                Name = "Daniel Henney",
                                Order = 2,
                                Role = "Tadashi Hamada (voice)",
                                Thumbnail =
                                    "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fkR4h7S7ny30HaqJpe5rv88RrKYA.jpg/"
                            }
                        },
                        SortTitle = "",
                        OriginalTitle = "Big Hero 6",
                        Art = new Artwork
                        {
                            Fanart =
                                "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2f2BXd0t9JdVqCp9sKf6kzMkr7QjB.jpg/",
                            Poster =
                                "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fhGRfWcy1HRGbsjK6jF7NILmqmFT.jpg/",
                        },
                        Fanart =
                            "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2f2BXd0t9JdVqCp9sKf6kzMkr7QjB.jpg/",
                        Country = new[] {"United States of America"},
                        DateAdded = "2015-02-10 13:42:44",
                        Director = new[] {"Don Hall", "Chris Williams"},
                        File = "/media/gotham/movies/Big Hero 6 (2014)/Big Hero 6.mkv",
                        Genre = new[] {"Adventure", "Family", "Animation", "Action", "Comedy"},
                        Label = "Big Hero 6",
                        LastPlayed = "",
                        MPAA = "Rated PG",
                        Playcount = 0,
                        Plot =
                            "The special bond that develops between plus-sized inflatable robot Baymax, and prodigy Hiro Hamada, who team up with a group of friends to form a band of high-tech heroes.",
                        PlotOutline = "",
                        Rating = 7.900000095367432,
                        Resume = new Resume
                        {
                            Position = 0.0,
                            Total = 0.0
                        },
                        Runtime = 6120,
                        Set = "",
                        SetId = 0,
                        Studio = new[] {"Walt Disney Pictures"},
                        Tagline = "Balalalala",
                        Thumbnail =
                            "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fhGRfWcy1HRGbsjK6jF7NILmqmFT.jpg/",
                        Top250 = 0,
                        Trailer = "plugin://plugin.video.youtube/?action=play_video&videoid=z3biFxZIJOQ",
                        Votes = "2490",
                        Writer = new[] {"Dan Gerson", "Jordan Roberts", "Robert L. Baird"},
                        Year = 2014,
                        ShowLink = new string[] {},
                        Tag = new string[] {},
                        StreamDetails = new Streams
                        {
                            Audio = new Stream.Audio[] {},
                            Video = new Stream.Video[] {},
                            Subtitle = new Stream.Subtitle[] {}
                        }
                    }
                },
                new GetMovieDetailsResponse
                {
                    Result = new Movie
                    {
                        Art = new Artwork
                        {
                            Fanart =
                                "image://%2fmedia%2fgotham%2fmovies%2fWolf%20of%20Wall%20Street%2c%20The%20(2013)1080Pdtsbluray%2fThe%20Wolf%20of%20Wall%20Street-fanart.jpg/",
                            Poster =
                                "image://%2fmedia%2fgotham%2fmovies%2fWolf%20of%20Wall%20Street%2c%20The%20(2013)1080Pdtsbluray%2fThe%20Wolf%20of%20Wall%20Street.tbn/"
                        },
                        Cast = new[]
                        {
                            new Cast
                            {
                                Name = "Matthew McConaughey",
                                Order = 0,
                                Role = "Mark Hanna",
                                Thumbnail =
                                    "image://https%3a%2f%2fimage.tmdb.org%2ft%2fp%2fw185%2fjdRmHrG0TWXGhs4tO6TJNSoL25T.jpg/"
                            },
                            new Cast
                            {
                                Name = "Leonardo DiCaprio",
                                Order = 1,
                                Role = "Jordan Belfort",
                                Thumbnail =
                                    "image://https%3a%2f%2fimage.tmdb.org%2ft%2fp%2fw185%2fmNRMgj7K5ztvkSqrcdwEYNZIS1M.jpg/"
                            },
                            new Cast
                            {
                                Name = "Rob Reiner",
                                Order = 2,
                                Role = "Max Belfort",
                                Thumbnail =
                                    "image://https%3a%2f%2fimage.tmdb.org%2ft%2fp%2fw185%2f2zw9Iq9uo4vZiTQNQWdNFwbA1TA.jpg/"
                            }
                        },
                        Country = new string[] {},
                        DateAdded = "2015-01-01 15:03:32",
                        Director = new[] {"Martin Scorsese"},
                        Fanart =
                            "image://%2fmedia%2fgotham%2fmovies%2fWolf%20of%20Wall%20Street%2c%20The%20(2013)1080Pdtsbluray%2fThe%20Wolf%20of%20Wall%20Street-fanart.jpg/",
                        File =
                            "/media/gotham/movies/Wolf of Wall Street, The (2013)1080Pdtsbluray/The Wolf of Wall Street.mkv",
                        Genre = new[] { "Comedy", "Crime", "Drama", "Biography" },
                        ImdbNumber = "tt0993846",
                        Label = "The Wolf of Wall Street",
                        LastPlayed = "",
                        MovieId = 100,
                        MPAA = "R",
                        OriginalTitle = "The Wolf of Wall Street",
                        Playcount = 0,
                        Plot =
                            "A New York stockbroker refuses to cooperate in a large securities fraud case involving corruption on Wall Street, corporate banking world and mob infiltration. Based on Jordan Belfort's autobiography.",
                        PlotOutline = "",
                        Rating = 8.399999618530273,
                        Resume = new Resume
                        {
                            Position = 0.0,
                            Total = 0.0
                        },
                        Runtime = 10800,
                        Set = "",
                        SetId = 0,
                        ShowLink = new string[] {},
                        SortTitle = "",
                        StreamDetails = new Streams
                        {
                            Audio = new[]
                            {
                                new Stream.Audio
                                {
                                    Channels = 5,
                                    Codec = "dts",
                                    Language = ""
                                }
                            },
                            Subtitle = new Stream.Subtitle[] {},
                            Video = new[]
                            {
                                new Stream.Video
                                {
                                    Aspect = 2.4000000953674316,
                                    Codec = "h264",
                                    Duration = 0,
                                    Height = 800,
                                    StereoMode = "",
                                    Width = 1920
                                }
                            }
                        },
                        Studio = new string[] {},
                        Tag = new string[] {},
                        Tagline = "EARN. SPEND. PARTY.",
                        Thumbnail =
                            "image://%2fmedia%2fgotham%2fmovies%2fWolf%20of%20Wall%20Street%2c%20The%20(2013)1080Pdtsbluray%2fThe%20Wolf%20of%20Wall%20Street.tbn/",
                        Title = "The Wolf of Wall Street",
                        Top250 = 0,
                        Trailer = "",
                        Votes = "299447",
                        Writer = new[]
                        {
                            "Terence Winter (screenplay)",
                            "Jordan Belfort (book)"
                        },
                        Year = 2013
                    }
                },
                new GetMovieDetailsResponse
                {
                    Result = new Movie
                    {
                        Art = new Artwork
                        {
                            Fanart = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fAoYGqtWxcNmQjQIpRCMtzpFfL1T.jpg/",
                            Poster = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fgCBw0AQDhlo0bNetkjsSRWzrxpW.jpg/"
                        },
                        Cast = new[]
                        {
                            new Cast
                            {
                                Name = "Melissa McCarthy",
                                Order = 0,
                                Role = "Susan Cooper",
                                Thumbnail = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fjSLdOktZHZOPEE4DzSShxuEeXPy.jpg/"
                            },
                            new Cast
                            { 
                                Name = "Jude Law",
                                Order = 1,
                                Role = "Bradley Fine",
                                Thumbnail = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2f4077Cyuo1mw53u1gNjLyQkqeZN0.jpg/"
                            },
                            new Cast
                            {
                                Name = "Jason Statham",
                                Order = 2,
                                Role = "Rick Ford",
                                Thumbnail = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fPhWiWgasncGWD9LdbsGcmxkV4r.jpg/"
                            }
                        },
                        Country = new[] { "United States of America" },
                        DateAdded = "2015-09-05 10:51:35",
                        Director = new[] { "Paul Feig" },
                        Fanart = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fAoYGqtWxcNmQjQIpRCMtzpFfL1T.jpg/",
                        File = "/media/gotham/movies/Spy (2015)/Spy.mkv",
                        Genre = new[] { "Crime", "Action", "Comedy" },
                        ImdbNumber = "tt3079380",
                        Label = "Spy",
                        LastPlayed = "",
                        MovieId = 77,
                        MPAA = "Rated R",
                        OriginalTitle = "Spy",
                        Playcount = 0,
                        Plot = "A desk-bound CIA analyst volunteers to go undercover to infiltrate the world of a deadly arms dealer, and prevent diabolical global disaster.",
                        PlotOutline = "",
                        Rating = 7.099999904632568,
                        Resume = new Resume
                        {
                            Position = 0.0,
                            Total = 0.0
                        },
                        Runtime = 7850,
                        Set = "",
                        SetId = 0,
                        ShowLink = new string[] {},
                        SortTitle = "",
                        StreamDetails = new Streams
                        {
                            Audio = new[]
                            {
                                new Stream.Audio
                                {
                                    Channels = 6,
                                    Codec = "ac3",
                                    Language = "rus"
                                },
                                new Stream.Audio
                                {
                                    Channels = 2,
                                    Codec = "aac",
                                    Language = "ukr"
                                },
                                new Stream.Audio
                                {
                                    Channels = 2,
                                    Codec = "aac",
                                    Language = "eng"
                                }
                            },
                            Subtitle = new[]
                            {
                                new Stream.Subtitle { Language = "rus" },
                                new Stream.Subtitle { Language = "rus" },
                                new Stream.Subtitle { Language = "ukr" },
                                new Stream.Subtitle { Language = "eng" },
                                new Stream.Subtitle { Language = "eng" }
                            },
                            Video = new[]
                            {
                                new Stream.Video
                                {
                                    Aspect = 2.3970038890838623,
                                    Codec = "h264",
                                    Duration = 7850,
                                    Height = 534,
                                    StereoMode = "",
                                    Width = 1280
                                }
                            }
                        },
                        Studio = new[] { "Chernin Entertainment" },
                        Tag = new string[] {},
                        Tagline = "One of the guys. One of the Spies.",
                        Thumbnail = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fgCBw0AQDhlo0bNetkjsSRWzrxpW.jpg/",
                        Title = "Spy",
                        Top250 = 0,
                        Trailer = "plugin://plugin.video.youtube/?action=play_video&videoid=YrY3v1eDmQY",
                        Votes = "866",
                        Writer = new[] { "Paul Feig" },
                        Year = 2015
                    }
                }
            };

            return movies;
        }

        public static GetMovieDetailsResponse GetMovie(TestSet movieId)
        {
            var movies = GetMovies();

            return movies.First(m => m.Result.MovieId == (int)movieId);
        }
    }
}
