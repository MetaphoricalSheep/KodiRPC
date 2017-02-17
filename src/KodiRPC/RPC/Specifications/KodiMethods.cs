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

namespace KodiRPC.RPC.Specifications
{
    public static class KodiMethods
    {
        #region JSONRPC

        public const string Ping = "JSONRPC.Ping";

        #endregion

        #region VideoLibrary

        #region Shows
        public const string Clean = "VideoLibrary.Clean";
        public const string Scan = "VideoLibrary.Scan";
        public const string GetTvShows = "VideoLibrary.GetTVShows";
        public const string GetTvShowDetails = "VideoLibrary.GetTVShowDetails";
        public const string GetSeasons = "VideoLibrary.GetSeasons";
        public const string GetEpisodes = "VideoLibrary.GetEpisodes";
        public const string GetEpisodeDetails = "VideoLibrary.GetEpisodeDetails";
        public const string GetRecentlyAddedEpisodes = "VideoLibrary.GetRecentlyAddedEpisodes";
        #endregion

        #region Movies
        public const string GetMovies = "VideoLibrary.GetMovies";
        public const string GetMovieDetails = "VideoLibrary.GetMovieDetails";
        public const string GetRecentlyAddedMovies = "VideoLibrary.GetRecentlyAddedMovies";
        #endregion

        #endregion

        #region Files
        public const string GetFileDetails = "Files.GetFileDetails";
        public const string GetDirectory = "Files.GetDirectory";
        public const string PrepareDownload = "Files.PrepareDownload";
        public const string Download = "Files.Download";
        #endregion

    }
}
