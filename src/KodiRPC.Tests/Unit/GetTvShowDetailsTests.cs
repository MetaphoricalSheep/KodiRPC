using KodiRPC.ExceptionHandling.RPC;
using KodiRPC.Responses.VideoLibrary;
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
            var mock = GetKodiServiceMock((int)id);
            var service = mock.Object;
            var actual = service.GetTvShowDetails((int)id, null, null);
            var expected = TvShows.GetTvShow(id);

            Assert.IsInstanceOf<GetTvShowDetailsResponse>(actual);
            Assert.That(actual.Result.TvShowId, Is.EqualTo(expected.Result.TvShowId));
            AssertThatPropertyValuesAreEquals(actual.Result, expected.Result);
        }

        [Test]
        public void GivenAJsonString_WhenGettingATvShowByTvShowId_WithAnInvalidTvShowId_ItShouldThrowRpcInternalServerErrorException()
        {
            const TvShows.TestSet id = TvShows.TestSet.InvalidId;
            var mock = GetKodiServiceMock((int)id);
            var service = mock.Object;

            Assert.That(() => service.GetTvShowDetails((int) id, null, null), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}