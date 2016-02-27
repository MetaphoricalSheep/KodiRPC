using System.Diagnostics.CodeAnalysis;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.Services;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetMovieDetailsTest
    {
        private const string LocalHost = "http://stark-industries.local";
        private const string RemoteHost = "http://localhost";

        [Test]
        public void ValidateMovieObjectReturnedByService()
        {
            var service = new KodiService {Host=LocalHost, Port=8080, Username="kodi", Password="kodi"};

            var testCase = new Movie
            {
                MovieId = 12,
                Title = "Big Hero 6",
                Label = "Big Hero 6",
                OriginalTitle = "Big Hero 6",
                MPAA = "Rated PG",
                PlotOutline = "",
                Set = "",
                Year = 2014,
            };

            var properties = new[] { "title", "runtime", "mpaa", "originaltitle", "plotoutline", "set", "year", "plot" };
            var details = service.GetMovieDetails(testCase.MovieId, properties);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.AreEqual(testCase.MovieId, details.Result.MovieId);
            Assert.AreEqual(testCase.Title, details.Result.Title);
            Assert.AreEqual(testCase.Label, details.Result.Label);
            Assert.AreEqual(testCase.MPAA, details.Result.MPAA);
            Assert.AreEqual(testCase.OriginalTitle, details.Result.OriginalTitle);
            Assert.AreEqual(testCase.PlotOutline, details.Result.PlotOutline);
            Assert.AreEqual(testCase.Set, details.Result.Set);
            Assert.AreEqual(testCase.Year, details.Result.Year);
        }
    }
}
