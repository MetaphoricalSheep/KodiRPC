using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.RPC.RequestResponse.Params;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties.Video.Details;
using KodiRPC.Services;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetTvShowsTests
    {
        [Test]
        public void WhenGettingAllTvShows_ItShouldReturnAListOfTvShows()
        {
            var service = new KodiService();

            var parameters = new GetTvShowsParams
            {
                Properties = new[] {TvShowProperties.Title, TvShowProperties.Year}
            };

            var details = service.GetTvShows(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.Greater(details.Result.Count, 0);
            Assert.IsInstanceOf<List<TvShow>>(details.Result);
        }

        [Test]
        public void WhenGettingAllTvShows_WithALimitOf0And1_ItShouldReturnAListWithOneTvShow()
        {
            var service = new KodiService();

            var parameters = new GetTvShowsParams
            {
                Properties = new[] {TvShowProperties.Title},
                Limits = new Limits
                {
                    Start = 0,
                    End = 1
                }
            };

            var details = service.GetTvShows(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.That(details.Result.Count, Is.EqualTo(1));
            Assert.IsInstanceOf<List<TvShow>>(details.Result);
        }
    }
}
