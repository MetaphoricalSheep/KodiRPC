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

using System;
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
    public partial class GetEpisodeDetailsTests : BaseTest
    {
        [Test]
        public void GivenAJsonString_WhenGettingAnEpisodeByEpisodeId_WithAValidEpisodeId_ItShouldReturnAnEpisode()
        {
            const Episodes.TestSet id = Episodes.TestSet.Continuum;

            var parameters = new GetEpisodeDetailsParams
            {
                EpisodeId = (int)id
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;
            var actual = service.GetEpisodeDetails(parameters, "UnitTests");
            var expected = Episodes.GetEpisode(id);

            Assert.IsInstanceOf<JsonRpcResponse<GetEpisodeDetailsResponse>>(actual);
            Assert.That(actual.Result.EpisodeDetails.EpisodeId, Is.EqualTo(expected.EpisodeDetails.EpisodeId));
            AssertThatPropertyValuesAreEquals(actual.Result.EpisodeDetails, expected.EpisodeDetails);
        }

        [Test]
        public void GivenAJsonString_WhenGettingAnEpisodeByEpisodeId_WithAnInvalidEpisodeId_ItShouldThrowRpcInternalServerErrorException()
        {
            const Episodes.TestSet id = Episodes.TestSet.InvalidId;

            var parameters = new GetEpisodeDetailsParams
            {
                EpisodeId = (int)id,
                Properties = EpisodeProperties.All()
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;

            Assert.That(() => service.GetEpisodeDetails(parameters, "UnitTests"), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}