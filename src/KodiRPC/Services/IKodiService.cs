using KodiRPC.Responses.VideoLibrary;
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
        GetSeasonsResponse GetSeasons(GetSeasonsParams parameters = null, string requestId = "GetSeasonsResponse");
        GetEpisodesResponse GetEpisodes(GetEpisodesParams parameters = null, string requestId = "GetEpisodesResponse");
        GetEpisodeDetailsResponse GetEpisodeDetails(GetEpisodeDetailsParams parameters, string requestId = "GetEpisodeDetailsResponse");
        GetRecentlyAddedEpisodesResponse GetRecentlyAddedEpisodes(GetEpisodesParams parameters = null, string requestId = "GetRecentlyAddedEpisodesResponse");
        #endregion

        #region Movies
        GetMoviesResponse GetMovies(GetMoviesParams parameters = null, string requestId = "GetMovieDetailsResponse");
        GetMovieDetailsResponse GetMovieDetails(GetMovieDetailsParams parameters, string requestId = "GetMovieDetailsResponse");
        GetRecentlyAddedMoviesResponse GetRecentlyAddedMovies(GetMoviesParams parameters = null, string requestId = "GetRecentlyAddedMoviesResponse");
        #endregion

        #endregion
    }
}
