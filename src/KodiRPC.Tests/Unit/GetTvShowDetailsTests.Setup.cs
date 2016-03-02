using KodiRPC.Responses.VideoLibrary;
using KodiRPC.Services;
using Moq;

namespace KodiRPC.Tests.Unit
{
    public partial class GetTvShowDetailsTests
    {
        public Mock<IKodiService> GetKodiServiceMock(int tvShowId)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetTvShowDetails(tvShowId, null, null)).Returns(
                (int id, object properties, string requestId) => MakeFauxRequest<GetTvShowDetailsResponse>($"tvshow.{tvShowId}.json"));

            return mock;
        }
    }
}