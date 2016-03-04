using System.Collections.Generic;
using KodiRPC.Responses.Types.Video.Details;
using Newtonsoft.Json;

namespace KodiRPC.Responses.VideoLibrary
{
    public class GetSeasonsResponse
    {
        [JsonProperty(PropertyName = "seasons")]
        public List<Season> Result { get; set; }
    }
}