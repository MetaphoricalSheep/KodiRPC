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
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties;
using KodiRPC.Tests.Unit.Common;
using KodiRPC.Tests.Unit.Common.ExpectedResults;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class GetTvShowsTests : BaseTest
    {
        [Test]
        public void GivenAJsonString_WhenGettingAllTvShows_ItShouldReturnAListOfShows()
        {
            var parameters = new GetTvShowsParams
            {
                Properties = new [] { TvShowProperties.Title }
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;
            var actual = service.GetTvShows(parameters, "UnitTests");
            var expected = TvShows.GetList();

            Assert.IsInstanceOf<JsonRpcResponse<GetTvShowsResponse>>(actual);
            Assert.That(actual.Result.TvShows.Count, Is.EqualTo(expected.TvShows.Count));
            AssertThatPropertyValuesAreEquals(actual.Result, expected);
        }
    }
}