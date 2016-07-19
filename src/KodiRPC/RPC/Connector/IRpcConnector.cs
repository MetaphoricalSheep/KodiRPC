using KodiRPC.RPC.RequestResponse;

namespace KodiRPC.RPC.Connector
{
    public interface IRpcConnector
    {
        JsonRpcResponse<T> MakeRequest<T>(string rpcMethod, object parameters, string id = "KodiJSON-RPC");
    }
}
