using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params.VideoLibrary
{
    public class GetSeasonsParams : Parameters
    {
        [JsonProperty("tvshowid", NullValueHandling = NullValueHandling.Ignore)]
        public int TvShowId { get; set; }

        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public Limits Limits { get; set; }

        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public Sort Sort { get; set; }
    }
}