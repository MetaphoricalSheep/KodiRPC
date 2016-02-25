using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Details
{
    public class Movie : File
    {
        [JsonProperty(PropertyName = "plotoutline")]
        public string PlotOutline { get; set; } = "";

        [JsonProperty(PropertyName = "sorttitle")]
        public string SortTitle { get; set; } = "";

        [JsonProperty(PropertyName = "movieid")]
        public int MovieId { get; set; }

        [JsonProperty(PropertyName = "cast")]
        public Cast[] Cast { get; set; }

        [JsonProperty(PropertyName = "votes")]
        public string Votes { get; set; } = "";

        [JsonProperty(PropertyName = "showlink")]
        public string[] ShowLink { get; set; }

        [JsonProperty(PropertyName = "top250")]
        public int Top250 { get; set; } = 0;

        [JsonProperty(PropertyName = "trailer")]
        public string Trailer { get; set; } = "";

        [JsonProperty(PropertyName = "year")]
        public int Year { get; set; } = 0;

        [JsonProperty(PropertyName = "country")]
        public string[] Country { get; set; }

        [JsonProperty(PropertyName = "studio")]
        public string[] Studio { get; set; }

        [JsonProperty(PropertyName = "set")]
        public string Set { get; set; } = "";

        [JsonProperty(PropertyName = "genre")]
        public string[] Genre { get; set; }

        [JsonProperty(PropertyName = "mpaa")]
        public string MPAA { get; set; } = "";

        [JsonProperty(PropertyName = "setid")]
        public int SetId { get; set; } = -1;

        [JsonProperty(PropertyName = "rating")]
        public int Rating { get; set; } = 0;

        [JsonProperty(PropertyName = "tag")]
        public string[] Tag { get; set; }

        [JsonProperty(PropertyName = "tagline")]
        public string Tagline { get; set; } = "";

        [JsonProperty(PropertyName = "writer")]
        public string[] Writer { get; set; }

        [JsonProperty(PropertyName = "originaltitle")]
        public string OriginalTitle { get; set; } = "";

        [JsonProperty(PropertyName = "imdbnumber")]
        public string ImdbNumber { get; set; } = "";
    }
}
