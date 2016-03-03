using System;
using System.Diagnostics.CodeAnalysis;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties.Video.Details;
using KodiRPC.Services;
using KodiRPC.Tests.Unit.Common.ExpectedResults;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetEpisodeDetailsTests
    {
        [Test]
        public void WhenGettingAnEpisode_WithAnEpisodeIdOfOne_ItShouldReturnAnEpisode()
        {
            var service = new KodiService();

            var parameters = new GetEpisodeDetailsParams
            {
                EpisodeId = 1,
                Properties = new[] {EpisodeProperties.Title, EpisodeProperties.UniqueId}
            };

            var details = service.GetEpisodeDetails(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.AreEqual(1, details.Result.EpisodeId);
        }

        [Test]
        public void WhenGettingEpisodeDetails_WithAnInvalidEpisodeId_ItShouldThrowException()
        {
            var service = new KodiService();

            var parameters = new GetEpisodeDetailsParams
            {
                EpisodeId = (int)Episodes.TestSet.InvalidId,
            };

            Assert.That(() => service.GetEpisodeDetails(parameters, "UnitTests"), Throws.Exception.TypeOf<Exception>());
        }
    }
}
