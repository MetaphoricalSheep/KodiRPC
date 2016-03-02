using System.Diagnostics.CodeAnalysis;
using KodiRPC.RPC.Specifications.Properties.Video.Details;
using KodiRPC.Services;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetTvShowDetailsTest
    {
        [Test]
        public void ValidateTvShowObjectReturnedByService()
        {
            var service = new KodiService();
            var properties = new[] { TvShowProperties.Title, TvShowProperties.ImdbNumber, TvShowProperties.Year };
            var details = service.GetTvShowDetails(1, properties);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.AreEqual(1, details.Result.TvShowId);
        }
    }
}
