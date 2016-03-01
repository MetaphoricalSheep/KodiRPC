using KodiRPC.Responses.VideoLibrary;
using KodiRPC.Services;
using Moq;

namespace KodiRPC.Tests.Unit
{
    public partial class GetEpisodeDetailsTests
    {
        public Mock<IKodiService> GetKodiServiceMock(int episodeId)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetEpisodeDetails(episodeId, null, null)).Returns(
                (int id, object properties, string requestId) => MakeFauxRequest<GetEpisodeDetailsResponse>($"episode.{episodeId}.json"));

            return mock;
        }
    }
}