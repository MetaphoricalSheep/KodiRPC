using KodiRPC.RPC.Connector;
using KodiRPC.RPC.Specifications;

namespace KodiRPC.Services
{
    public class KodiService
    {
        private readonly RpcConnector _rpcConnector;
        public string ApiVersion => "v6";
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public KodiService()
        {
            _rpcConnector = new RpcConnector(this);
        }

        #region JSONRPC

        public string Ping()
        {
            return _rpcConnector.MakeRequest<string>(KodiMethods.Ping);
        }

        #endregion
    }
}
