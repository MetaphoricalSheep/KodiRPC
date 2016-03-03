using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params
{
    public class Limits
    {
        [JsonProperty("start", Required = Required.Always)]
        public int Start { get; set; } = -1;

        [JsonProperty("end", Required = Required.Always)]
        public int End { get; set; } = 0;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }
    }
}
