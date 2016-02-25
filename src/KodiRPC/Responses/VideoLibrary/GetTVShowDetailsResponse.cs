using KodiRPC.Responses.Types.Video.Details;
using Newtonsoft.Json;

namespace KodiRPC.Responses.VideoLibrary
{
    public class GetTvShowDetailsResponse
    {
        [JsonProperty(PropertyName = "tvshowdetails")]
        public TvShow Result { get; set; }
    }
}
