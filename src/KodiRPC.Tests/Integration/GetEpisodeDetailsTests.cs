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
using System.Diagnostics.CodeAnalysis;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties.Video.Details;
using KodiRPC.Services;
using KodiRPC.Tests.Unit.Common.ExpectedResults;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetEpisodeDetailsTests
    {
        [Test]
        public void WhenGettingAnEpisode_WithAnEpisodeIdOfOne_ItShouldReturnAnEpisode()
        {
            var service = new KodiService();

            var parameters = new GetEpisodeDetailsParams
            {
                EpisodeId = 1,
                Properties = new[] {EpisodeProperties.Title, EpisodeProperties.UniqueId}
            };

            var details = service.GetEpisodeDetails(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.AreEqual(1, details.Result.EpisodeDetails.EpisodeId);
        }

        [Test]
        public void WhenGettingEpisodeDetails_WithAnInvalidEpisodeId_ItShouldThrowException()
        {
            var service = new KodiService();

            var parameters = new GetEpisodeDetailsParams
            {
                EpisodeId = (int)Episodes.TestSet.InvalidId,
            };

            Assert.That(() => service.GetEpisodeDetails(parameters, "UnitTests"), Throws.Exception.TypeOf<Exception>());
        }
    }
}
