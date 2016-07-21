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

using KodiRPC.RPC.RequestResponse.Params.Filters;
using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params
{
    public class Filter
    {
        [JsonProperty("field", Required = Required.Always)]
        public string Field { get; set; }

        [JsonProperty("operator", Required = Required.Always)]
        public string Operator { get; set; } = Operators.Contains;

        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; } = "";

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }
    }
}
