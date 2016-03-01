using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video
{
    public class UniqueId
    {
        [JsonProperty(PropertyName = "unknown")]
        public string Unknown { get; set; } = "";
    }
}
