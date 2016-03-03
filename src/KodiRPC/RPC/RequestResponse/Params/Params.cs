using KodiRPC.RPC.RequestResponse.Params;
using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse
{
    public class Parameters
    {
        [JsonProperty("filter")]
        public Filter Filter { get; set; }

        [JsonProperty("limits")]
        public Limits Limits { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }
    }
}
