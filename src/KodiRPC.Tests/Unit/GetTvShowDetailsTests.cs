using KodiRPC.ExceptionHandling.RPC;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.Tests.Unit.Common;
using KodiRPC.Tests.Unit.Common.ExpectedResults;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class GetTvShowDetailsTests : BaseTest
    {
        [Test]
        public void GivenAJsonString_WhenGettingATvShowByTvShowId_WithAValidTvShowId_ItShouldReturnATvShow()
        {
            const TvShows.TestSet id = TvShows.TestSet.TheAmericans;

            var parameters = new GetTvShowDetailsParams
            {
                TvShowId = (int)id
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;

            var actual = service.GetTvShowDetails(parameters, "UnitTests");
            var expected = TvShows.GetTvShow(id);

            Assert.IsInstanceOf<GetTvShowDetailsResponse>(actual);
            Assert.That(actual.Result.TvShowId, Is.EqualTo(expected.Result.TvShowId));
            AssertThatPropertyValuesAreEquals(actual.Result, expected.Result);
        }

        [Test]
        public void GivenAJsonString_WhenGettingATvShowByTvShowId_WithAnInvalidTvShowId_ItShouldThrowRpcInternalServerErrorException()
        {
            const TvShows.TestSet id = TvShows.TestSet.InvalidId;

            var parameters = new GetTvShowDetailsParams
            {
                TvShowId = (int)id
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;

            Assert.That(() => service.GetTvShowDetails(parameters, "UnitTests"), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}