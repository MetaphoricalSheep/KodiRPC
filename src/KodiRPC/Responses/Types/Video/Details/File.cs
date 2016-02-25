using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Details
{
    public class File : Item
    {
        [JsonProperty(PropertyName = "streamdetails")]
        public Streams StreamDetails { get; set; }

        [JsonProperty(PropertyName = "director")]
        public string[] Director { get; set; }

        [JsonProperty(PropertyName = "resume")]
        public Resume Resume { get; set; }

        [JsonProperty(PropertyName = "runtime")]
        public int Runtime { get; set; } = 0;
    }
}
