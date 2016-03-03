using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse;

namespace KodiRPC.Services
{
    public interface IKodiService
    {
        #region JSONRPC

        string Ping();

        #endregion

        #region VideoLibrary

        #region Shows
        GetTvShowsResponse GetTvShows(Parameters parameters = null, string requestId = "GetTvShowsResponse");
        GetTvShowDetailsResponse GetTvShowDetails(Parameters parameters, string requestId = "GetTvShowDetailsResponse");
        GetEpisodesResponse GetEpisodes(Parameters parameters = null, string requestId = "GetEpisodesResponse");
        GetEpisodeDetailsResponse GetEpisodeDetails(Parameters parameters, string requestId = "GetEpisodeDetailsResponse");
        #endregion

        #region Movies
        GetMoviesResponse GetMovies(Parameters parameters = null, string requestId = "GetMovieDetailsResponse");
        GetMovieDetailsResponse GetMovieDetails(Parameters parameters, string requestId = "GetMovieDetailsResponse");
        #endregion

        #endregion
    }
}
