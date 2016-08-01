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

using KodiRPC.Responses.VideoLibrary;
using KodiRPC.Responses.Files;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.RequestResponse.Params.Files;

namespace KodiRPC.Services
{
    public interface IKodiService
    {
        #region JSONRPC

        JsonRpcResponse<string> Ping();

        #endregion

        #region VideoLibrary

        #region Shows
        JsonRpcResponse<string> Clean(CleanParams parameters = null, string requestId = "VideoLibrary.Clean");
        JsonRpcResponse<string> Scan(ScanParams parameters = null, string requestId = "VideoLibrary.Scan");
        JsonRpcResponse<GetTvShowsResponse> GetTvShows(GetTvShowsParams parameters = null, string requestId = "GetTvShowsResponse");
        JsonRpcResponse<GetTvShowDetailsResponse> GetTvShowDetails(GetTvShowDetailsParams parameters, string requestId = "GetTvShowDetailsResponse");
        JsonRpcResponse<GetSeasonsResponse> GetSeasons(GetSeasonsParams parameters = null, string requestId = "GetSeasonsResponse");
        JsonRpcResponse<GetEpisodesResponse> GetEpisodes(GetEpisodesParams parameters = null, string requestId = "GetEpisodesResponse");
        JsonRpcResponse<GetEpisodeDetailsResponse> GetEpisodeDetails(GetEpisodeDetailsParams parameters, string requestId = "GetEpisodeDetailsResponse");
        JsonRpcResponse<GetRecentlyAddedEpisodesResponse> GetRecentlyAddedEpisodes(GetRecentlyAddedEpisodesParams parameters = null, string requestId = "GetRecentlyAddedEpisodesResponse");
        #endregion

        #region Movies
        JsonRpcResponse<GetMoviesResponse> GetMovies(GetMoviesParams parameters = null, string requestId = "GetMovieDetailsResponse");
        JsonRpcResponse<GetMovieDetailsResponse> GetMovieDetails(GetMovieDetailsParams parameters, string requestId = "GetMovieDetailsResponse");
        JsonRpcResponse<GetRecentlyAddedMoviesResponse> GetRecentlyAddedMovies(GetRecentlyAddedMoviesParams parameters = null, string requestId = "GetRecentlyAddedMoviesResponse");
        #endregion

        #endregion

        #region Files
        JsonRpcResponse<GetFileDetailsResponse> GetFileDetails(GetFileDetailsParams parameters, string requestId = "GetFileDetails");
        #endregion
    }
}
