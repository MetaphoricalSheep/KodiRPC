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
        GetTvShowsResponse GetTvShows(string[] properties = null, string[] limits = null,
            string sort = null, string filter = null, string requestId = "GetTvShowsResponse");

        GetTvShowDetailsResponse GetTvShowDetails(int tvShowId, string[] properties = null,
            string requestId = "GetTvShowDetailsResponse");

        GetEpisodesResponse GetEpisodes(int tvShowId = -1, int seasonNumber = -1, string[] properties = null,
            string[] limits = null, string[] sort = null, string[] filter = null, string requestId = "GetEpisodesResponse");

        GetEpisodeDetailsResponse GetEpisodeDetails(int epidodeId, string[] properties = null,
            string requestId = "GetEpisodeDetailsResponse");
        #endregion

        #region Movies
        GetMoviesResponse GetMovies(string[] properties = null, string[] limits = null, 
            string[] sort = null, string[] filter = null, string requestId = "GetMovieDetailsResponse");

        GetMovieDetailsResponse GetMovieDetails(int movieId, string[] properties = null,
            string requestId = "GetMovieDetailsResponse");
        #endregion

        #endregion
    }
}
