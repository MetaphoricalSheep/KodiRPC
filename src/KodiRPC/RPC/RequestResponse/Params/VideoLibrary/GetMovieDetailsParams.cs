using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params.VideoLibrary
{
    public class GetMovieDetailsParams : Parameters
    {
        [JsonProperty("movieid", Required = Required.Always)]
        public int MovieId;
    }
}