using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params.VideoLibrary
{
    public class GetTvShowDetailsParams : Parameters
    {
        [JsonProperty("tvshowid", Required = Required.Always)]
        public int TvShowId;
    }
}