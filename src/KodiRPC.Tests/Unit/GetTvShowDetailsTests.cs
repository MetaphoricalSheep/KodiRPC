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

using KodiRPC.ExceptionHandling.RPC;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties;
using KodiRPC.Tests.Unit.Common;
using KodiRPC.Tests.Unit.Common.ExpectedResults;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class GetTvShowDetailsTests : BaseTest
    {
        [Test]
        public void GivenAJsonString_WhenGettingATvShowByTvShowId_WithAValidTvShowId_ItShouldReturnATvShow()
        {
            const TvShows.TestSet id = TvShows.TestSet.TheAmericans;

            var parameters = new GetTvShowDetailsParams
            {
                TvShowId = (int)id,
                Properties = TvShowProperties.All()
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;

            var actual = service.GetTvShowDetails(parameters, "UnitTests");
            var expected = TvShows.GetTvShow(id);

            Assert.IsInstanceOf<JsonRpcResponse<GetTvShowDetailsResponse>>(actual);
            Assert.That(actual.Result.TvShowDetails.TvShowId, Is.EqualTo(expected.TvShowDetails.TvShowId));
            AssertThatPropertyValuesAreEquals(actual.Result.TvShowDetails, expected.TvShowDetails);
        }

        [Test]
        public void GivenAJsonString_WhenGettingATvShowByTvShowId_WithAnInvalidTvShowId_ItShouldThrowRpcInternalServerErrorException()
        {
            const TvShows.TestSet id = TvShows.TestSet.InvalidId;

            var parameters = new GetTvShowDetailsParams
            {
                TvShowId = (int)id
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;

            Assert.That(() => service.GetTvShowDetails(parameters, "UnitTests"), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}