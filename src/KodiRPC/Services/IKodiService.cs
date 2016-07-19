using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;

namespace KodiRPC.Services
{
    public interface IKodiService
    {
        #region JSONRPC

        JsonRpcResponse<string> Ping();

        #endregion

        #region VideoLibrary

        #region Shows
        JsonRpcResponse<GetTvShowsResponse> GetTvShows(GetTvShowsParams parameters = null, string requestId = "GetTvShowsResponse");
        JsonRpcResponse<GetTvShowDetailsResponse> GetTvShowDetails(GetTvShowDetailsParams parameters, string requestId = "GetTvShowDetailsResponse");
        JsonRpcResponse<GetSeasonsResponse> GetSeasons(GetSeasonsParams parameters = null, string requestId = "GetSeasonsResponse");
        JsonRpcResponse<GetEpisodesResponse> GetEpisodes(GetEpisodesParams parameters = null, string requestId = "GetEpisodesResponse");
        JsonRpcResponse<GetEpisodeDetailsResponse> GetEpisodeDetails(GetEpisodeDetailsParams parameters, string requestId = "GetEpisodeDetailsResponse");
        JsonRpcResponse<GetRecentlyAddedEpisodesResponse> GetRecentlyAddedEpisodes(GetRecentlyAddedEpisodesParams parameters = null, string requestId = "GetRecentlyAddedEpisodesResponse");
        #endregion

        #region Movies
        JsonRpcResponse<GetMoviesResponse> GetMovies(GetMoviesParams parameters = null, string requestId = "GetMovieDetailsResponse");
        JsonRpcResponse<GetMovieDetailsResponse> GetMovieDetails(GetMovieDetailsParams parameters, string requestId = "GetMovieDetailsResponse");
        JsonRpcResponse<GetRecentlyAddedMoviesResponse> GetRecentlyAddedMovies(GetRecentlyAddedMoviesParams parameters = null, string requestId = "GetRecentlyAddedMoviesResponse");
        #endregion

        #endregion
    }
}
