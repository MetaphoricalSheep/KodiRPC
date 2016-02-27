using KodiRPC.Responses.Types.Media;
using KodiRPC.Responses.Types.Video;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.Tests.Unit.Common;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class GetMovieDetailsTests : BaseTest
    {
        public GetMovieDetailsResponse MovieTestCase()
        {
            return new GetMovieDetailsResponse
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
                            Thumbnail = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2f8VTCE0c8RSLYsgRqA8UDPRbBvYm.jpg/"
                        },
                        new Cast
                        {
                            Name = "Ryan Potter",
                            Order = 1,
                            Role = "Hiro Hamada (voice)",
                            Thumbnail = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2flKC6fdpcLaYJpDEQxitByUJQQZq.jpg/"
                        },
                        new Cast
                        {
                            Name = "Daniel Henney",
                            Order = 2,
                            Role = "Tadashi Hamada (voice)",
                            Thumbnail = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fkR4h7S7ny30HaqJpe5rv88RrKYA.jpg/"
                        }
                    },
                    SortTitle = "",
                    OriginalTitle = "Big Hero 6",
                    Art = new Artwork
                    {
                        Fanart = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2f2BXd0t9JdVqCp9sKf6kzMkr7QjB.jpg/",
                        Poster = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fhGRfWcy1HRGbsjK6jF7NILmqmFT.jpg/",
                    },
                    Fanart = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2f2BXd0t9JdVqCp9sKf6kzMkr7QjB.jpg/",
                    Country = new[] { "United States of America" },
                    DateAdded = "2015-02-10 13:42:44",
                    Director = new[] { "Don Hall", "Chris Williams" },
                    File = "/media/gotham/movies/Big Hero 6 (2014)/Big Hero 6.mkv",
                    Genre = new[] { "Adventure", "Family", "Animation", "Action", "Comedy" },
                    Label = "Big Hero 6",
                    LastPlayed = "",
                    MPAA = "Rated PG",
                    Playcount = 0,
                    Plot = "The special bond that develops between plus-sized inflatable robot Baymax, and prodigy Hiro Hamada, who team up with a group of friends to form a band of high-tech heroes.",
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
                    Studio = new[] { "Walt Disney Pictures" },
                    Tagline = "Balalalala",
                    Thumbnail = "image://http%3a%2f%2fimage.tmdb.org%2ft%2fp%2foriginal%2fhGRfWcy1HRGbsjK6jF7NILmqmFT.jpg/",
                    Top250 = 0,
                    Trailer = "plugin://plugin.video.youtube/?action=play_video&videoid=z3biFxZIJOQ",
                    Votes = "2490",
                    Writer = new[] { "Dan Gerson", "Jordan Roberts", "Robert L. Baird" },
                    Year = 2014 ,
                    ShowLink = new string[] {},
                    Tag = new string[] {},
                    StreamDetails = new Streams
                    {
                        Audio = new string[] {}, 
                        Video = new string[] {}, 
                        Subtitle = new string[] {}
                    }
                }
            };
        }
        
        [Test]
        public void GivenAJsonString_WhenGettingAMovieByMovieId_WithAValidMovieId_ItShouldReturnAMovie()
        {
            var mock = GetKodiServiceMock(12);
            var service = mock.Object;
            var movie = service.GetMovieDetails(12, null, null);
            var testCase = MovieTestCase();

            Assert.IsInstanceOf<GetMovieDetailsResponse>(movie);
            Assert.That(movie.Result.MovieId, Is.EqualTo(testCase.Result.MovieId));
            AssertThatPropertyValuesAreEquals(movie.Result, testCase.Result);
        }
    }
}
