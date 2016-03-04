using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Details
{
    public class Season : Base
    {
        [JsonProperty(PropertyName = "showtitle")]
        public string ShowTitle { get; set; } = "";

        [JsonProperty(PropertyName = "watchedepisodes")]
        public int WatchedEpisodes { get; set; } = 0;

        [JsonProperty(PropertyName = "tvshowid")]
        public int TvShowId { get; set; } = -1;

        [JsonProperty(PropertyName = "episode")]
        public int Episode { get; set; } = 0;

        [JsonProperty(PropertyName = "season")]
        public int SeasonNumber { get; set; }

        [JsonProperty(PropertyName = "seasonid")]
        public int SeasonId { get; set; }
    }
}