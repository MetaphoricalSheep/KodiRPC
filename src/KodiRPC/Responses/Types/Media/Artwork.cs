using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Media
{
    public class Artwork
    {
        [JsonProperty(PropertyName = "banner")]
        public string Banner { get; set; } = "";

        [JsonProperty(PropertyName = "poster")]
        public string Poster { get; set; } = "";

        [JsonProperty(PropertyName = "fanart")]
        public string Fanart { get; set; } = "";

        [JsonProperty(PropertyName = "thumb")]
        public string Thumb { get; set; } = "";
    }
}
