using System.Collections.Generic;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.Services;
using Moq;

namespace KodiRPC.Tests.Unit
{
    public partial class GetTvShowsTests
    {
        public Mock<IKodiService> GetKodiServiceMock(GetTvShowsParams parameters)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetTvShows(parameters, "UnitTests"))
                .Returns(() => MakeFauxRequest<GetTvShowsResponse>("tvshows.json"));

            return mock;
        }
    }
}