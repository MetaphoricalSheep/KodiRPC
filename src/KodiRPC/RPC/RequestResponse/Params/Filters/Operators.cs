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

namespace KodiRPC.RPC.RequestResponse.Params.Filters
{
    public class Operators
    {
        public const string Contains = "contains";
        public const string DoesNotContain = "doesnotcontain";
        public const string Is = "is";
        public const string IsNot = "isnot";
        public const string StartsWith = "startswith";
        public const string EndsWith = "endswith";
        public const string GreaterThan = "greaterthan";
        public const string LessThan = "lessthan";
        public const string After = "after";
        public const string Before = "before";
        public const string InTheLast = "inthelast";
        public const string Notinthelast = "notinthelast";
        public const string True = "true";
        public const string False = "false";
        public const string Between = "between";
    }
}
