using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Media.Details
{
    public class Base : Item.Details.Base
    {
        [JsonProperty(PropertyName = "fanart")]
        public string Fanart { get; set; } = "";

        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; set; } = "";
    }
}
