namespace KodiRPC.RPC.Specifications
{
    public static class KodiMethods
    {
        #region JSONRPC

        public const string Ping = "JSONRPC.Ping";

        #endregion

        #region VideoLibrary

        #region Shows
        public const string GetTvShowDetails = "VideoLibrary.GetTVShowDetails";
        public const string GetEpisodeDetails = "VideoLibrary.GetEpisodeDetails";
        #endregion

        #region Movies
        public const string GetMovieDetails = "VideoLibrary.GetMovieDetails";
        #endregion

        #endregion
    }
}
