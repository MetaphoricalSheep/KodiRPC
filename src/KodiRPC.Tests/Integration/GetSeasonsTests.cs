using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.RPC.RequestResponse.Params;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties.Video.Details;
using KodiRPC.Services;
using KodiRPC.Tests.Unit.Common;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetSeasonsTests
    {
        [Test]
        public void WhenGettingAllSeasons_ItShouldReturnAListOfSeasons()
        {
            var service = new KodiService();

            var parameters = new GetSeasonsParams
            {
                TvShowId = 1,
                Properties = new[] {SeasonProperties.ShowTitle, SeasonProperties.SeasonNumber}
            };

            var details = service.GetSeasons(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.Greater(details.Result.Count, 0);
            Assert.IsInstanceOf<List<Season>>(details.Result);
        }

        [Test]
        public void WhenGettingAllSeasons_WithALimitOf0And1_ItShouldReturnAListWithOneSeason()
        {
            var service = new KodiService();

            var parameters = new GetSeasonsParams
            {
                TvShowId = 1,
                Properties = new[] {SeasonProperties.ShowTitle},
                Limits = new Limits
                {
                    Start = 0,
                    End = 1
                }
            };

            var details = service.GetSeasons(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.That(details.Result.Count, Is.EqualTo(1));
            Assert.IsInstanceOf<List<Season>>(details.Result);
        }
    }
}
