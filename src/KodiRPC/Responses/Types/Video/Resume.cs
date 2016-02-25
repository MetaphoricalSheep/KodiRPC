using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video
{
    public class Resume
    {
        [JsonProperty(PropertyName = "position")]
        public int Position { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }
    }
}
