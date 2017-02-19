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

namespace KodiRPC.Responses.Types.List.Item
{
    public class Base
    {
        [JsonProperty(PropertyName = "sorttitle")]
        public string SortTitle { get; set; }

        [JsonProperty(PropertyName = "productioncode")]
        public string ProductionCode { get; set; }

        [JsonProperty(PropertyName = "cast")]
        public Video.Cast[] Cast { get; set; }

        [JsonProperty(PropertyName = "votes")]
        public string Votes { get; set; }

        [JsonProperty(PropertyName = "duration")]
        public int Duration { get; set; }

        [JsonProperty(PropertyName = "trailer")]
        public string Trailer { get; set; }

        [JsonProperty(PropertyName = "albumid")]
        public int AlbumId { get; set; }

        [JsonProperty(PropertyName = "musicbrainzartistid")]
        public string MusicbrainzArtistId { get; set; }

        [JsonProperty(PropertyName = "mpaa")]
        public string Mpaa { get; set; }

        [JsonProperty(PropertyName = "albumlabel")]
        public string AlbumLabel { get; set; }

        [JsonProperty(PropertyName = "originaltitle")]
        public string OriginalTitle { get; set; }

        [JsonProperty(PropertyName = "writer")]
        public string[] Writer { get; set; }

        [JsonProperty(PropertyName = "albumartistid")]
        public int[] AlbumArtistId { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "episode")]
        public int Episode { get; set; }

        [JsonProperty(PropertyName = "firstaired")]
        public string FirstAired { get; set; }

        [JsonProperty(PropertyName = "showtitle")]
        public string ShowTitle { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string[] Country { get; set; }

        [JsonProperty(PropertyName = "mood")]
        public string[] Mood { get; set; }

        [JsonProperty(PropertyName = "set")]
        public string Set { get; set; }

        [JsonProperty(PropertyName = "musicbrainztrackid")]
        public string MusicbrainzTrackId { get; set; }

        [JsonProperty(PropertyName = "tag")]
        public string[] Tag { get; set; }

        [JsonProperty(PropertyName = "lyrics")]
        public string Lyrics { get; set; }

        [JsonProperty(PropertyName = "top250")]
        public int Top250 { get; set; }

        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        [JsonProperty(PropertyName = "premiered")]
        public string Premiered { get; set; }

        [JsonProperty(PropertyName = "showlink")]
        public string[] ShowLink { get; set; }

        [JsonProperty(PropertyName = "style")]
        public string[] Style { get; set; }

        [JsonProperty(PropertyName = "album")]
        public string Album { get; set; }

        [JsonProperty(PropertyName = "tvshowid")]
        public int TvShowId { get; set; }

        [JsonProperty(PropertyName = "season")]
        public int Season { get; set; }

        [JsonProperty(PropertyName = "theme")]
        public string[] Theme { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "setid")]
        public int SetId { get; set; }

        [JsonProperty(PropertyName = "track")]
        public int Track { get; set; }

        [JsonProperty(PropertyName = "tagline")]
        public string Tagline { get; set; }

        [JsonProperty(PropertyName = "plotoutline")]
        public string PlotOutline { get; set; }

        [JsonProperty(PropertyName = "watchedepisodes")]
        public int WatchedEpisodes { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "disc")]
        public int Disc { get; set; }

        [JsonProperty(PropertyName = "albumartist")]
        public string[] AlbumArtist { get; set; }

        [JsonProperty(PropertyName = "studio")]
        public string[] Studio { get; set; }

        [JsonProperty(PropertyName = "uniqueid")]
        public object UniqueId { get; set; }

        [JsonProperty(PropertyName = "episodeguide")]
        public string EpisodeGuide { get; set; }

        [JsonProperty(PropertyName = "imdbnumber")]
        public string ImdbNumber { get; set; }

    }
}