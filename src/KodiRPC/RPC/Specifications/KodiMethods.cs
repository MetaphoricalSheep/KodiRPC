namespace KodiRPC.RPC.Specifications
{
    public static class KodiMethods
    {
        #region JSONRPC

        public static string Ping => "JSONRPC.Ping";

        #endregion

        #region VideLibrary

        public static string GetTvShowDetails => "VideoLibrary.GetTVShowDetails";

        #endregion
    }
}
