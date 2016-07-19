using System.Collections.Generic;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.RPC.RequestResponse.Params;
using Newtonsoft.Json;

namespace KodiRPC.Responses.VideoLibrary
{
    public class GetTvShowsResponse
    {
        [JsonProperty(PropertyName = "tvshows")]
        public List<TvShow> TvShows { get; set; }

        [JsonProperty(PropertyName = "limits")]
        public Limits Limits { get; set; }
    }
}
