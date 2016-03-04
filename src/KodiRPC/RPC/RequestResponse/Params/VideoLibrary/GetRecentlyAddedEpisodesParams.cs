using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params.VideoLibrary
{
    public class GetRecentlyAddedEpisodesParams : Parameters
    {
        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public Limits Limits { get; set; }

        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public Sort Sort { get; set; }
    }
}
