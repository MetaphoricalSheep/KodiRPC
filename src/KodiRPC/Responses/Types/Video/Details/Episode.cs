using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Details
{
    public class Episode : File
    {
        [JsonProperty(PropertyName = "cast")]
        public Cast[] Cast { get; set; }

        [JsonProperty(PropertyName = "productioncode")]
        public string ProductionCode { get; set; } = "";

        [JsonProperty(PropertyName = "rating")]
        public double Rating { get; set; } = 0;

        [JsonProperty(PropertyName = "votes")]
        public string Votes { get; set; } = "";

        [JsonProperty(PropertyName = "episode")]
        public int EpisodeNumber { get; set; } = 0;

        [JsonProperty(PropertyName = "showtitle")]
        public string ShowTitle { get; set; } = "";

        [JsonProperty(PropertyName = "episodeid")]
        public int EpisodeId { get; set; }

        [JsonProperty(PropertyName = "tvshowid")]
        public int TvShowId { get; set; } = -1;

        [JsonProperty(PropertyName = "season")]
        public int Season { get; set; } = 0;

        [JsonProperty(PropertyName = "firstaired")]
        public string FirstAired { get; set; } = "";

        [JsonProperty(PropertyName = "uniqueid")]
        public UniqueId UniqueId { get; set; }

        [JsonProperty(PropertyName = "writer")]
        public string[] Writer { get; set; }

        [JsonProperty(PropertyName = "originaltitle")]
        public string OriginalTitle { get; set; } = "";
    }
}
