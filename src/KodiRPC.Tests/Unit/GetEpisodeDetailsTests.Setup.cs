using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.Services;
using Moq;

namespace KodiRPC.Tests.Unit
{
    public partial class GetEpisodeDetailsTests
    {
        public Mock<IKodiService> GetKodiServiceMock(GetEpisodeDetailsParams parameters)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetEpisodeDetails(parameters, "UnitTests"))
                .Returns(() => MakeFauxRequest<GetEpisodeDetailsResponse>($"episode.{parameters.EpisodeId}.json"));

            return mock;
        }
    }
}