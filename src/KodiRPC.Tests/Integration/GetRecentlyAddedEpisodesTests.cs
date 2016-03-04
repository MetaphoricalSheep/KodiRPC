using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties.Video.Details;
using KodiRPC.Services;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetRecentlyAddedEpisodesTests
    {
        [Test]
        public void WhenGettingAllRecentlyAddedEpisodes_ItShouldReturnAListOfEpisodes()
        {
            var service = new KodiService();

            var parameters = new GetRecentlyAddedEpisodesParams
            {
                Properties = new[] {EpisodeProperties.Title, EpisodeProperties.DateAdded}
            };

            var details = service.GetRecentlyAddedEpisodes(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.Greater(details.Result.Count, 0);
            Assert.IsInstanceOf<List<Episode>>(details.Result);
        }
    }
}
