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
    public class Season : Base
    {
        [JsonProperty(PropertyName = "showtitle")]
        public string ShowTitle { get; set; } = "";

        [JsonProperty(PropertyName = "watchedepisodes")]
        public int WatchedEpisodes { get; set; } = 0;

        [JsonProperty(PropertyName = "tvshowid")]
        public int TvShowId { get; set; } = -1;

        [JsonProperty(PropertyName = "episode")]
        public int Episode { get; set; } = 0;

        [JsonProperty(PropertyName = "season")]
        public int SeasonNumber { get; set; }

        [JsonProperty(PropertyName = "seasonid")]
        public int SeasonId { get; set; }
    }
}