namespace KodiRPC.RPC.Connector
{
    public interface IRpcConnector
    {
        T MakeRequest<T>(string rpcMethod, object parameters, string id = "KodiJSON-RPC");
    }
}
