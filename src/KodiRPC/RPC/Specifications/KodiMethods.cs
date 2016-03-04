namespace KodiRPC.RPC.Specifications
{
    public static class KodiMethods
    {
        #region JSONRPC

        public const string Ping = "JSONRPC.Ping";

        #endregion

        #region VideoLibrary

        #region Shows
        public const string GetTvShows = "VideoLibrary.GetTVShows";
        public const string GetTvShowDetails = "VideoLibrary.GetTVShowDetails";
        public const string GetSeasons = "VideoLibrary.GetSeasons";
        public const string GetEpisodes = "VideoLibrary.GetEpisodes";
        public const string GetEpisodeDetails = "VideoLibrary.GetEpisodeDetails";
        public const string GetRecentlyAddedEpisodes = "VideoLibrary.GetRecentlyAddedEpisodes";
        #endregion

        #region Movies
        public const string GetMovies = "VideoLibrary.GetMovies";
        public const string GetMovieDetails = "VideoLibrary.GetMovieDetails";
        public const string GetRecentlyAddedMovies = "VideoLibrary.GetRecentlyAddedMovies";
        #endregion

        #endregion
    }
}
