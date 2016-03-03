using System.Collections.Generic;
using KodiRPC.Responses.Types.Video.Details;
using Newtonsoft.Json;

namespace KodiRPC.Responses.VideoLibrary
{
    public class GetEpisodesResponse
    {
        [JsonProperty(PropertyName = "episodes")]
        public List<Episode> Result { get; set; }
    }
}