using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties;
using KodiRPC.Tests.Unit.Common;
using KodiRPC.Tests.Unit.Common.ExpectedResults;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class GetTvShowsTests : BaseTest
    {
        [Test]
        public void GivenAJsonString_WhenGettingAllTvShows_ItShouldReturnAListOfShows()
        {
            var parameters = new GetTvShowsParams
            {
                Properties = new [] { TvShowProperties.Title }
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;
            var actual = service.GetTvShows(parameters, "UnitTests");
            var expected = TvShows.GetList();

            Assert.IsInstanceOf<JsonRpcResponse<GetTvShowsResponse>>(actual);
            Assert.That(actual.Result.TvShows.Count, Is.EqualTo(expected.TvShows.Count));
            AssertThatPropertyValuesAreEquals(actual, expected);
        }
    }
}