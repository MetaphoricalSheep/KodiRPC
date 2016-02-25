using KodiRPC.Responses.Types.Video.Details;
using Newtonsoft.Json;

namespace KodiRPC.Responses.VideoLibrary
{
    public class GetMovieDetailsResponse
    {
        [JsonProperty(PropertyName = "moviedetails")]
        public Movie Result { get; set; }
    }
}
