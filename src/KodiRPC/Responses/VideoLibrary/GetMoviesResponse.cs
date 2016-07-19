using System.Collections.Generic;
using KodiRPC.Responses.Types.Video.Details;
using Newtonsoft.Json;
using KodiRPC.RPC.RequestResponse.Params;

namespace KodiRPC.Responses.VideoLibrary
{
    public class GetMoviesResponse
    {
        [JsonProperty(PropertyName = "movies")]
        public List<Movie> Movies { get; set; }

        [JsonProperty(PropertyName = "limits")]
        public Limits Limits { get; set; }
    }
}