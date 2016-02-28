namespace KodiRPC.RPC.Specifications
{
    public static class KodiMethods
    {
        #region JSONRPC

        public const string Ping = "JSONRPC.Ping";

        #endregion

        #region VideoLibrary

        public const string GetTvShowDetails = "VideoLibrary.GetTVShowDetails";
        public const string GetMovieDetails = "VideoLibrary.GetMovieDetails";

        #endregion
    }
}
