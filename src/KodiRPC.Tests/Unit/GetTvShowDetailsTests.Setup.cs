using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.Services;
using Moq;

namespace KodiRPC.Tests.Unit
{
    public partial class GetTvShowDetailsTests
    {
        public Mock<IKodiService> GetKodiServiceMock(GetTvShowDetailsParams parameters)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetTvShowDetails(parameters, "UnitTests"))
                .Returns(() => MakeFauxRequest<GetTvShowDetailsResponse>($"tvshow.{parameters.TvShowId}.json"));

            return mock;
        }
    }
}