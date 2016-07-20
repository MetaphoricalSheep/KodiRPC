using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties;
using KodiRPC.Tests.Unit.Common;
using KodiRPC.Tests.Unit.Common.ExpectedResults;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class GetSeasonsTests : BaseTest
    {
        [Test]
        public void GivenAJsonString_WhenGettingAllSeasons_ItShouldReturnAListOfSeasons()
        {
            var parameters = new GetSeasonsParams
            {
                TvShowId = 1,
                Properties = new [] { SeasonProperties.ShowTitle }
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;
            var actual = service.GetSeasons(parameters, "UnitTests");
            var expected = Seasons.GetList();

            Assert.IsInstanceOf<JsonRpcResponse<GetSeasonsResponse>>(actual);
            Assert.That(actual.Result.Seasons.Count, Is.EqualTo(expected.Seasons.Count));
            AssertThatPropertyValuesAreEquals(actual.Result, expected);
        }
    }
}