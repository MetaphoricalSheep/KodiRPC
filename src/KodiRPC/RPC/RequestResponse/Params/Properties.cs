using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params
{
    public class Properties
    {
        [JsonProperty("properties", Required = Required.Always)]
        public string[] Props { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }
         
    }
}