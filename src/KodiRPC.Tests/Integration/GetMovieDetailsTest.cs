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

            var properties = new[] { "title", "runtime", "year", "plot" };
            var details = service.GetMovieDetails(1, properties);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.AreEqual(1, details.Result.MovieId);
        }
    }
}
