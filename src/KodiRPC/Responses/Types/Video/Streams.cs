using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video
{
    public class Streams
    {
        [JsonProperty(PropertyName = "video")]
        public object[] Video { get; set; }

        [JsonProperty(PropertyName = "audio")]
        public object[] Audio { get; set; }

        [JsonProperty(PropertyName = "subtitle")]
        public object[] Subtitle { get; set; }
    }
}
