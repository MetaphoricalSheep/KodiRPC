/********************************************************************************************************************************************
 * Copyright (C) 2016 Pieter-Uys Fourie
 * This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as 
 * published by the Free Software Foundation, either version 3 of the License, or any later version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty 
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License along with this program. If not, see 
 * http://www.gnu.org/licenses/.
 */

using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Video.Details
{
    public class Episode : File
    {
        [JsonProperty(PropertyName = "cast")]
        public Cast[] Cast { get; set; }

        [JsonProperty(PropertyName = "productioncode")]
        public string ProductionCode { get; set; } = "";

        [JsonProperty(PropertyName = "rating")]
        public double Rating { get; set; } = 0;

        [JsonProperty(PropertyName = "votes")]
        public string Votes { get; set; } = "";

        [JsonProperty(PropertyName = "episode")]
        public int EpisodeNumber { get; set; } = 0;

        [JsonProperty(PropertyName = "showtitle")]
        public string ShowTitle { get; set; } = "";

        [JsonProperty(PropertyName = "episodeid")]
        public int EpisodeId { get; set; }

        [JsonProperty(PropertyName = "tvshowid")]
        public int TvShowId { get; set; } = -1;

        [JsonProperty(PropertyName = "season")]
        public int Season { get; set; } = 0;

        [JsonProperty(PropertyName = "firstaired")]
        public string FirstAired { get; set; } = "";

        [JsonProperty(PropertyName = "uniqueid")]
        public UniqueId UniqueId { get; set; }

        [JsonProperty(PropertyName = "writer")]
        public string[] Writer { get; set; }

        [JsonProperty(PropertyName = "originaltitle")]
        public string OriginalTitle { get; set; } = "";
    }
}
