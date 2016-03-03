using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;

namespace KodiRPC.Services
{
    public interface IKodiService
    {
        #region JSONRPC

        string Ping();

        #endregion

        #region VideoLibrary

        #region Shows
        GetTvShowsResponse GetTvShows(GetTvShowsParams parameters = null, string requestId = "GetTvShowsResponse");
        GetTvShowDetailsResponse GetTvShowDetails(GetTvShowDetailsParams parameters, string requestId = "GetTvShowDetailsResponse");
        GetEpisodesResponse GetEpisodes(GetEpisodesParams parameters = null, string requestId = "GetEpisodesResponse");
        GetEpisodeDetailsResponse GetEpisodeDetails(GetEpisodeDetailsParams parameters, string requestId = "GetEpisodeDetailsResponse");
        #endregion

        #region Movies
        GetMoviesResponse GetMovies(GetMoviesParams parameters = null, string requestId = "GetMovieDetailsResponse");
        GetMovieDetailsResponse GetMovieDetails(GetMovieDetailsParams parameters, string requestId = "GetMovieDetailsResponse");
        #endregion

        #endregion
    }
}
