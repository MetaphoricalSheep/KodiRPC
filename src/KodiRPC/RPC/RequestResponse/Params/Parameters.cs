using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params
{
    public class Parameters
    {
        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }
    }
}
