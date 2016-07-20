using KodiRPC.RPC.Specifications;
using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Error
{
    public class Stack
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
