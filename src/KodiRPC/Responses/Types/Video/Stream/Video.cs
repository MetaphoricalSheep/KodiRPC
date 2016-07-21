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