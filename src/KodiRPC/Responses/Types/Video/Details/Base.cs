using KodiRPC.Responses.Types.Media;
using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Details
{
    public class Base : Types.Media.Details.Base
    {
        [JsonProperty(PropertyName = "art")]
        public Artwork Art { get; set; }

        [JsonProperty(PropertyName = "playcount")]
        public int Playcount { get; set; } = 0;
    }
}
