using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Stream
{
    public class Subtitle
    {
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; } = "";
    }
}
