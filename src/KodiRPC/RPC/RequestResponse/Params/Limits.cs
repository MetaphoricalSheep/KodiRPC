using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params
{
    public class Limits
    {
        [JsonProperty("start", Required = Required.Always)]
        public int Start { get; set; } = -1;

        [JsonProperty("end", Required = Required.Always)]
        public int End { get; set; } = 0;

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; } = null;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }
    }
}
