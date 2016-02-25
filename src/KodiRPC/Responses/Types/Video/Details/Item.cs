using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Details
{
    public class Item : Media
    {
        [JsonProperty(PropertyName = "dateadded")]
        public string DateAdded { get; set; } = "";

        [JsonProperty(PropertyName = "file")]
        public string File { get; set; } = "";

        [JsonProperty(PropertyName = "lastplayed")]
        public string LastPlayed { get; set; } = "";

        [JsonProperty(PropertyName = "plot")]
        public string Plot { get; set; } = "";
    }
}
