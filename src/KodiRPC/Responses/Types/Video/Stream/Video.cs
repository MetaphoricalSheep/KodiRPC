using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Stream
{
    public class Video
    {
        [JsonProperty(PropertyName = "aspect")]
        public double Aspect { get; set; } = 0;

        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; } = "";

        [JsonProperty(PropertyName = "duration")]
        public int Duration { get; set; } = 0;
        
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; } = 0;
        
        [JsonProperty(PropertyName = "stereomode")]
        public string StereoMode { get; set; } = "";

        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; } = 0;
    }
}