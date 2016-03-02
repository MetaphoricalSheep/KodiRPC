using System.Diagnostics.CodeAnalysis;
using KodiRPC.RPC.Specifications.Properties.Video.Details;
using KodiRPC.Services;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetMovieDetailsTest
    {
        [Test]
        public void ValidateMovieObjectReturnedByService()
        {
            var service = new KodiService();
            var properties = new[] { MovieProperties.Title, MovieProperties.Runtime, MovieProperties.Year, MovieProperties.Plot };
            var details = service.GetMovieDetails(1, properties);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.AreEqual(1, details.Result.MovieId);
        }
    }
}
