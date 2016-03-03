using KodiRPC.RPC.RequestResponse.Params.Filters;
using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params
{
    public class Filter
    {
        [JsonProperty("field", Required = Required.Always)]
        public string Field { get; set; }

        [JsonProperty("operator", Required = Required.Always)]
        public string Operator { get; set; } = Operators.Contains;

        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; } = "";

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }
    }
}
