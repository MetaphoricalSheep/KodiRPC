using System.Collections.Generic;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.Services;
using Moq;

namespace KodiRPC.Tests.Unit
{
    public partial class GetMoviesTests
    {
        public Mock<IKodiService> GetKodiServiceMock(GetMoviesParams parameters)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetMovies(parameters, "UnitTests"))
                .Returns(() => MakeFauxRequest<GetMoviesResponse>("movies.json"));

            return mock;
        }
    }
}