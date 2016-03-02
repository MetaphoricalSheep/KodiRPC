using KodiRPC.ExceptionHandling.RPC;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.Tests.Unit.Common;
using KodiRPC.Tests.Unit.Common.ExpectedResults;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class GetMovieDetailsTests : BaseTest
    {
        [Test]
        public void GivenAJsonString_WhenGettingAMovieByMovieId_WithAValidMovieId_ItShouldReturnAMovie()
        {
            const Movies.TestSet id = Movies.TestSet.Spy;
            var mock = GetKodiServiceMock((int)id);
            var service = mock.Object;
            var actual = service.GetMovieDetails((int)id, null, null);
            var expected = Movies.GetMovie(id);

            Assert.IsInstanceOf<GetMovieDetailsResponse>(actual);
            Assert.That(actual.Result.MovieId, Is.EqualTo(expected.Result.MovieId));
            AssertThatPropertyValuesAreEquals(actual.Result, expected.Result);
        }

        [Test]
        public void GivenAJsonString_WhenGettingAMovieByMovieId_WithAnInvalidMovieId_ItShouldThrowRpcInternalServerErrorException()
        {
            const Movies.TestSet id = Movies.TestSet.InvalidId;
            var mock = GetKodiServiceMock((int)id);
            var service = mock.Object;

            Assert.That(() => service.GetMovieDetails((int) id, null, null), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}
