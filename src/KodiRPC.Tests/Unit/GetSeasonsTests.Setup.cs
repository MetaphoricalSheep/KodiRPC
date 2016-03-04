using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.Services;
using Moq;

namespace KodiRPC.Tests.Unit
{
    public partial class GetSeasonsTests
    {
        public Mock<IKodiService> GetKodiServiceMock(GetSeasonsParams parameters)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetSeasons(parameters, "UnitTests"))
                .Returns(() => MakeFauxRequest<GetSeasonsResponse>("seasons.json"));

            return mock;
        }
    }
}