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
            const Movies.TestSet movieId = Movies.TestSet.Spy;
            var mock = GetKodiServiceMock((int)movieId);
            var service = mock.Object;
            var movie = service.GetMovieDetails((int)movieId, null, null);
            var testCase = Movies.GetMovie(movieId);

            Assert.IsInstanceOf<GetMovieDetailsResponse>(movie);
            Assert.That(movie.Result.MovieId, Is.EqualTo(testCase.Result.MovieId));
            AssertThatPropertyValuesAreEquals(movie.Result, testCase.Result);
        }

        [Test]
        public void GivenAJsonString_WhenGettingAMovieByMovieId_WithAnInvalidMovieId_ItShouldThrowRpcInternalServerErrorException()
        {
            const Movies.TestSet movieId = Movies.TestSet.InvalidId;
            var mock = GetKodiServiceMock((int)movieId);
            var service = mock.Object;

            Assert.That(() => service.GetMovieDetails((int) movieId, null, null), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}
