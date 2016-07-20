using KodiRPC.RPC.Specifications;
using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Error
{
    public class Data
    {
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        [JsonProperty(PropertyName = "stack")]
        public Stack Stack { get; set; }
    }
}
