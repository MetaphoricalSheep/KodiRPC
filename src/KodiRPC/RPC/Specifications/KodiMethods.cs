namespace KodiRPC.RPC.Specifications
{
    public static class KodiMethods
    {
        #region JSONRPC

        public static string Ping => "JSONRPC.Ping";

        #endregion

        #region VideoLibrary

        public static string GetTvShowDetails => "VideoLibrary.GetTVShowDetails";
        public static string GetMovieDetails => "VideoLibrary.GetMovieDetails";

        #endregion
    }
}
