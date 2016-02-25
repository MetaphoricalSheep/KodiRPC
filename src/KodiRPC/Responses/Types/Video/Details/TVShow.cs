using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Details
{
    public class TvShow : Item
    {
        [JsonProperty(PropertyName = "sorttitle")]
        public string SortTitle { get; set; } = "";

        [JsonProperty(PropertyName = "mpaa")]
        public string MPAA { get; set; } = "";

        [JsonProperty(PropertyName = "premiered")]
        public string Premiered { get; set; } = "";

        [JsonProperty(PropertyName = "year")]
        public int Year { get; set; } = 0;

        [JsonProperty(PropertyName = "episode")]
        public int Episode { get; set; } = 0;

        [JsonProperty(PropertyName = "watchedepisodes")]
        public int WatchedEpisodes { get; set; } = 0;

        [JsonProperty(PropertyName = "votes")]
        public string Votes { get; set; } = "";

        [JsonProperty(PropertyName = "rating")]
        public int Rating { get; set; } = 0;

        [JsonProperty(PropertyName = "tvshowid")]
        public int TvShowId { get; set; }

        [JsonProperty(PropertyName = "studio")]
        public string[] Studio { get; set; }

        [JsonProperty(PropertyName = "season")]
        public int Season { get; set; } = 0;

        [JsonProperty(PropertyName = "genre")]
        public string[] Genre { get; set; }

        [JsonProperty(PropertyName = "cast")]
        public Cast[] Cast { get; set; }

        [JsonProperty(PropertyName = "episodeguide")]
        public string EpisodeGuide { get; set; } = "";

        [JsonProperty(PropertyName = "tag")]
        public string[] Tag { get; set; }

        [JsonProperty(PropertyName = "originaltitle")]
        public string OriginalTitle { get; set; } = "";

        [JsonProperty(PropertyName = "imdbnumber")]
        public string ImdbNumber { get; set; } = "";

        public string TvDbId => ImdbNumber;
    }
}
