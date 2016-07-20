using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties;
using KodiRPC.Tests.Unit.Common;
using KodiRPC.Tests.Unit.Common.ExpectedResults;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class GetMoviesTests : BaseTest
    {
        [Test]
        public void GivenAJsonString_WhenGettingAllMovies_ItShouldReturnAListOfMovies()
        {
            var parameters = new GetMoviesParams
            {
                Properties = new [] { MovieProperties.Title }
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;
            var actual = service.GetMovies(parameters, "UnitTests");
            var expected = Movies.GetList();

            Assert.IsInstanceOf<JsonRpcResponse<GetMoviesResponse>>(actual);
            Assert.That(actual.Result.Movies.Count, Is.EqualTo(expected.Movies.Count));
            AssertThatPropertyValuesAreEquals(actual.Result, expected);
        }
    }
}