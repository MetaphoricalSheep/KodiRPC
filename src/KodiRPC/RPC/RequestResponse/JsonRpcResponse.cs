using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse
{
    public class JsonRpcResponse<T>
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "jsonrpc")]
        public string JsonRpc { get; set; }

        [JsonProperty(PropertyName = "result")]
        public T Result { get; set; }

        [JsonProperty(PropertyName = "error")]
        public JsonRpcError Error { get; set; }
    }
}
