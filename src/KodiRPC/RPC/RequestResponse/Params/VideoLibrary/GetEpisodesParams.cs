using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params.VideoLibrary
{
    public class GetEpisodesParams : Parameters
    {
        [JsonProperty("tvshowid", NullValueHandling = NullValueHandling.Ignore)]
        public int? TvShowId { get; set; } = null;

        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public int? SeasonNumber { get; set; } = null;

        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Filter Filter { get; set; }

        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public Limits Limits { get; set; }

        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public Sort Sort { get; set; }
    }
}