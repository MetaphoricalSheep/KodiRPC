using System.Collections.Generic;
using KodiRPC.Responses.Types.Video.Details;
using Newtonsoft.Json;

namespace KodiRPC.Responses.VideoLibrary
{
    public class GetMoviesResponse
    {
        [JsonProperty(PropertyName = "movies")]
        public List<Movie> Result { get; set; }
    }
}