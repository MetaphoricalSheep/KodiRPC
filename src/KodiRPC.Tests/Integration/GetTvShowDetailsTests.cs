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
    public class GetTvShowDetailsTests
    {
        [Test]
        public void WhenGettingTvShowDetails_WithATvShowIdOfOne_ItShouldReturnATvShow()
        {
            var service = new KodiService();

            var parameters = new GetTvShowDetailsParams
            {
                TvShowId = 1,
                Properties = new[] {TvShowProperties.Title, TvShowProperties.Year}
            };

            var details = service.GetTvShowDetails(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.AreEqual(1, details.Result.TvShowId);
        }

        [Test]
        public void WhenGettingTvShowDetails_WithAnInvalidTvShowId_ItShouldThrowException()
        {
            var service = new KodiService();

            var parameters = new GetTvShowDetailsParams
            {
                TvShowId = (int)TvShows.TestSet.InvalidId,
            };

            Assert.That(() => service.GetTvShowDetails(parameters, "UnitTests"), Throws.Exception.TypeOf<Exception>());
        }
    }
}
