using Newtonsoft.Json;
using KodiRPC.Responses.Types.Video.Details;

namespace KodiRPC.Responses.VideoLibrary
{
    public class GetEpisodeDetailsResponse
    {
        [JsonProperty(PropertyName = "episodedetails")]
        public Episode EpisodeDetails { get; set; }
    }
}
