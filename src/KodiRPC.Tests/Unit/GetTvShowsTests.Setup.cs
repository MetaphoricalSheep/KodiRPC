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
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.Services;
using Moq;

namespace KodiRPC.Tests.Unit
{
    public partial class GetTvShowsTests
    {
        public Mock<IKodiService> GetKodiServiceMock(GetTvShowsParams parameters)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetTvShows(parameters, "UnitTests"))
                .Returns(() => MakeFauxRequest<GetTvShowsResponse>("tvshows.json"));

            return mock;
        }
    }
}