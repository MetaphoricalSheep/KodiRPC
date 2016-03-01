using KodiRPC.Responses.VideoLibrary;

namespace KodiRPC.Services
{
    public interface IKodiService
    {
        #region JSONRPC

        string Ping();

        #endregion

        #region VideoLibrary

        #region Shows
        GetTvShowDetailsResponse GetTvShowDetails(int tvShowId, string[] properties = null,
            string requestId = "GetTvShowDetailsResponse");

        GetEpisodeDetailsResponse GetEpisodeDetails(int epidodeId, string[] properties = null,
            string requestId = "GetEpisodeDetailsResponse");
        #endregion

        #region Movies
        GetMovieDetailsResponse GetMovieDetails(int movieId, string[] properties = null,
            string requestId = "GetMovieDetailsResponse");
        #endregion

        #endregion
    }
}
