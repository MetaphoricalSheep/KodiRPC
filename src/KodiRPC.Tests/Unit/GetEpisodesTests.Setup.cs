using System.Collections.Generic;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.Services;
using Moq;

namespace KodiRPC.Tests.Unit
{
    public partial class GetEpisodesTests
    {
        public Mock<IKodiService> GetKodiServiceMock(GetEpisodesParams parameters)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetEpisodes(parameters, "UnitTests"))
                .Returns(() => MakeFauxRequest<GetEpisodesResponse>("episodes.json"));

            return mock;
        }
    }
}