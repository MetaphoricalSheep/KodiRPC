using KodiRPC.Responses.VideoLibrary;

namespace KodiRPC.Services
{
    public interface IKodiService
    {
        string Ping();

        GetTvShowDetailsResponse GetTvShowDetails(int tvShowId, string[] properties = null,
            string requestId = "GetTvShowDetailsResponse");

        GetMovieDetailsResponse GetMovieDetails(int movieId, string[] properties = null,
            string requestId = "GetMovieDetailsResponse");
    }
}
