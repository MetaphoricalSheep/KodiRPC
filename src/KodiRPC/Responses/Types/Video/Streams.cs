using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video
{
    public class Streams
    {
        [JsonProperty(PropertyName = "video")]
        public Stream.Video[] Video { get; set; }

        [JsonProperty(PropertyName = "audio")]
        public Stream.Audio[] Audio { get; set; }

        [JsonProperty(PropertyName = "subtitle")]
        public Stream.Subtitle[] Subtitle { get; set; }
    }
}
