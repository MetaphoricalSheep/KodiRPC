using KodiRPC.ExceptionHandling.RPC;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties;
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

            var parameters = new GetMovieDetailsParams
            {
                MovieId = (int) id,
                Properties = MovieProperties.All()
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;

            var actual = service.GetMovieDetails(parameters, "UnitTests");
            var expected = Movies.GetMovie(id);

            Assert.IsInstanceOf<JsonRpcResponse<GetMovieDetailsResponse>>(actual);
            Assert.That(actual.Result.MovieDetails.MovieId, Is.EqualTo(expected.MovieDetails.MovieId));
            AssertThatPropertyValuesAreEquals(actual.Result.MovieDetails, expected.MovieDetails);
        }

        [Test]
        public void GivenAJsonString_WhenGettingAMovieByMovieId_WithAnInvalidMovieId_ItShouldThrowRpcInternalServerErrorException()
        {
            const Movies.TestSet id = Movies.TestSet.InvalidId;

            var parameters = new GetMovieDetailsParams
            {
                MovieId = (int) id
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;

            Assert.That(() => service.GetMovieDetails(parameters, "UnitTests"), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}
