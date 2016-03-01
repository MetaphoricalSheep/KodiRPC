using KodiRPC.Responses.VideoLibrary;
using KodiRPC.Services;
using Moq;

namespace KodiRPC.Tests.Unit
{
    public partial class GetMovieDetailsTests
    {
        public Mock<IKodiService> GetKodiServiceMock(int movieId)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetMovieDetails(movieId, null, null)).Returns(
                (int id, object properties, string requestId) =>
                    MakeFauxRequest<GetMovieDetailsResponse>($"movie.{movieId}.json"));

            return mock;
        }
    }
}