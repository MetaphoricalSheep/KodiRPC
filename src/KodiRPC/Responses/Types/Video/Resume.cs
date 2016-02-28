using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video
{
    public class Resume
    {
        [JsonProperty(PropertyName = "position")]
        public double Position { get; set; }

        [JsonProperty(PropertyName = "total")]
        public double Total { get; set; }
    }
}
