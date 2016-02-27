using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video
{
    public class Streams
    {
        [JsonProperty(PropertyName = "video")]
        public string[] Video { get; set; }

        [JsonProperty(PropertyName = "audio")]
        public string[] Audio { get; set; }

        [JsonProperty(PropertyName = "subtitle")]
        public string[] Subtitle { get; set; }
    }
}
