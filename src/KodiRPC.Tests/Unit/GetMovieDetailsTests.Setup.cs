using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.Services;
using Moq;

namespace KodiRPC.Tests.Unit
{
    public partial class GetMovieDetailsTests
    {
        public Mock<IKodiService> GetKodiServiceMock(GetMovieDetailsParams parameters)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetMovieDetails(parameters, "UnitTests"))
                .Returns(() => MakeFauxRequest<GetMovieDetailsResponse>($"movie.{parameters.MovieId}.json"));

            return mock;
        }
    }
}