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

using System.Configuration;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.Connector;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications;

namespace KodiRPC.Services
{
    public class KodiService : IKodiService
    {
        private readonly RpcConnector _rpcConnector;
        public readonly string ApiVersion = "v6";
        public readonly string Host = ConfigurationManager.AppSettings["KodiHost"];
        public readonly string Port = ConfigurationManager.AppSettings["KodiPort"];
        public readonly string Username = ConfigurationManager.AppSettings["KodiUsername"];
        public readonly string Password = ConfigurationManager.AppSettings["KodiPassword"];

        public KodiService()
        {
            _rpcConnector = new RpcConnector(this);
        }

        #region JSONRPC

        public JsonRpcResponse<string> Ping()
        {
            return _rpcConnector.MakeRequest<string>(KodiMethods.Ping, new object(), timeout:2000);
        }

        #endregion

        #region VideoLibrary

        #region Shows
        public JsonRpcResponse<string> Clean(CleanParams parameters, string requestId = "VideoLibrary.Clean")
        {
            return _rpcConnector.MakeRequest<string>(KodiMethods.Clean, parameters, requestId);
        }

        public JsonRpcResponse<string> Scan(ScanParams parameters, string requestId = "VideoLibrary.Scan")
        {
            return _rpcConnector.MakeRequest<string>(KodiMethods.Scan, parameters, requestId);
        }

        public JsonRpcResponse<GetTvShowsResponse> GetTvShows(GetTvShowsParams parameters, string requestId = "GetTvShowsResponse")
        {
            return _rpcConnector.MakeRequest<GetTvShowsResponse>(KodiMethods.GetTvShows, parameters, requestId);
        }

        public JsonRpcResponse<GetTvShowDetailsResponse> GetTvShowDetails(GetTvShowDetailsParams parameters, string requestId="GetTvShowDetailsResponse")
        {
            return _rpcConnector.MakeRequest<GetTvShowDetailsResponse>(KodiMethods.GetTvShowDetails, parameters, requestId);
        }

        public JsonRpcResponse<GetSeasonsResponse> GetSeasons(GetSeasonsParams parameters = null, string requestId = "GetSeasonsResponse")
        {
            return _rpcConnector.MakeRequest<GetSeasonsResponse>(KodiMethods.GetSeasons, parameters, requestId);
        }

        public JsonRpcResponse<GetEpisodesResponse> GetEpisodes(GetEpisodesParams parameters, string requestId = "GetEpisodesResponse")
        {
            return _rpcConnector.MakeRequest<GetEpisodesResponse>(KodiMethods.GetEpisodes, parameters, requestId);
        }

        public JsonRpcResponse<GetEpisodeDetailsResponse> GetEpisodeDetails(GetEpisodeDetailsParams parameters, string requestId="GetTvShowDetailsResponse")
        {
            return _rpcConnector.MakeRequest<GetEpisodeDetailsResponse>(KodiMethods.GetEpisodeDetails, parameters, requestId);
        }

        public JsonRpcResponse<GetRecentlyAddedEpisodesResponse> GetRecentlyAddedEpisodes(GetRecentlyAddedEpisodesParams parameters = null,
            string requestId = "GetRecentlyAddedEpisodesResponse")
        {
            return _rpcConnector.MakeRequest<GetRecentlyAddedEpisodesResponse>(KodiMethods.GetRecentlyAddedEpisodes, parameters, requestId);
        }
        #endregion

        #region Movies
        public JsonRpcResponse<GetMoviesResponse> GetMovies(GetMoviesParams parameters, string requestId = "GetMoviesResponse")
        {
            return _rpcConnector.MakeRequest<GetMoviesResponse>(KodiMethods.GetMovies, parameters, requestId);
        }

        public JsonRpcResponse<GetMovieDetailsResponse> GetMovieDetails(GetMovieDetailsParams parameters, string requestId="GetMovieDetailsResponse")
        {
            return _rpcConnector.MakeRequest<GetMovieDetailsResponse>(KodiMethods.GetMovieDetails, parameters, requestId);
        }

        public JsonRpcResponse<GetRecentlyAddedMoviesResponse> GetRecentlyAddedMovies(GetRecentlyAddedMoviesParams parameters = null,
            string requestId = "GetRecentlyAddedMoviesResponse")
        {
            return _rpcConnector.MakeRequest<GetRecentlyAddedMoviesResponse>(KodiMethods.GetRecentlyAddedMovies, parameters, requestId);
        }
        #endregion

        #endregion
    }
}
