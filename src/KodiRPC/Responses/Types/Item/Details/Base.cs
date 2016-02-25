using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Item.Details
{
    public class Base
    {
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
    }
}
