using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Stream
{
    public class Audio
    {
        [JsonProperty(PropertyName = "channels")]
        public int Channels { get; set; } = 0;

        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; } = "";

        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; } = "";
    }
}
