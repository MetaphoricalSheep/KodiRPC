using System.Diagnostics.CodeAnalysis;
using KodiRPC.RPC.Specifications.Properties.Video.Details;
using KodiRPC.Services;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetEpisodeDetailsTest
    {
        [Test]
        public void ValidateEpisodeObjectReturnedByService()
        {
            var service = new KodiService();
            var properties = new[] { EpisodeProperties.Title, EpisodeProperties.UniqueId};
            var details = service.GetEpisodeDetails(1, properties);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.AreEqual(1, details.Result.EpisodeId);
        }
    }
}
