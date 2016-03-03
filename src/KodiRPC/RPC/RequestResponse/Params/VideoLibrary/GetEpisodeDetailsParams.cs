using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params.VideoLibrary
{
    public class GetEpisodeDetailsParams : Parameters
    {
        [JsonProperty("episodeid", Required = Required.Always)]
        public int EpisodeId;
    }
}