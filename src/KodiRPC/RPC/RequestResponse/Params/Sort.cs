using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params
{
    public class Sort
    {
        [JsonProperty("ignorearticle")]
        public bool IgnoreArticle { get; set; } = false;

        [JsonProperty("method")]
        public string Method { get; set; } = "none";

        [JsonProperty("order")]
        public string Order { get; set; } = "ascending";
    }
}