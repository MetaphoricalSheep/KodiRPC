using System.Configuration;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.Connector;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.Specifications;

namespace KodiRPC.Services
{
    public class KodiService
    {
        private readonly RpcConnector _rpcConnector;
        public readonly string ApiVersion = "v6";
        public readonly string Host = ConfigurationManager.AppSettings["KodiHost"];
        public readonly string Port = ConfigurationManager.AppSettings["KodiPort"];
        public readonly string Username = ConfigurationManager.AppSettings["KodiUsername"];
        public readonly string Password = ConfigurationManager.AppSettings["KodiPassword"];

        public KodiService()
        {
            _rpcConnector = new RpcConnector(this);
        }

        #region JSONRPC

        public string Ping()
        {
            return _rpcConnector.MakeRequest<string>(KodiMethods.Ping, new object());
        }

        #endregion

        #region VideoLibrary

        #region Shows
        public GetTvShowDetailsResponse GetTvShowDetails(Parameters parameters = null, string requestId="GetTvShowDetailsResponse")
        {
            return _rpcConnector.MakeRequest<GetTvShowDetailsResponse>(KodiMethods.GetTvShowDetails, parameters, requestId);
        }

        public GetEpisodeDetailsResponse GetEpisodeDetails(Parameters parameters = null, string requestId="GetTvShowDetailsResponse")
        {
            return _rpcConnector.MakeRequest<GetEpisodeDetailsResponse>(KodiMethods.GetEpisodeDetails, parameters, requestId);
        }
        #endregion

        #region Movies
        public GetMovieDetailsResponse GetMovieDetails(Parameters parameters = null, string requestId="GetMovieDetailsResponse")
        {
            return _rpcConnector.MakeRequest<GetMovieDetailsResponse>(KodiMethods.GetMovieDetails, parameters, requestId);
        }
        #endregion

        #endregion
    }
}
