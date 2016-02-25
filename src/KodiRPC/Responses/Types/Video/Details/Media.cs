using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Details
{
    public class Media : Base
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; } = "";
    }
}
