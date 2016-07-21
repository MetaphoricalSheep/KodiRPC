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

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.RPC.RequestResponse.Params;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties.Video.Details;
using KodiRPC.Services;
using KodiRPC.Tests.Unit.Common;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetSeasonsTests
    {
        [Test]
        public void WhenGettingAllSeasons_ItShouldReturnAListOfSeasons()
        {
            var service = new KodiService();

            var parameters = new GetSeasonsParams
            {
                TvShowId = 1,
                Properties = new[] {SeasonProperties.ShowTitle, SeasonProperties.SeasonNumber}
            };

            var details = service.GetSeasons(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.Greater(details.Result.Seasons.Count, 0);
            Assert.IsInstanceOf<List<Season>>(details.Result.Seasons);
        }

        [Test]
        public void WhenGettingAllSeasons_WithALimitOf0And1_ItShouldReturnAListWithOneSeason()
        {
            var service = new KodiService();

            var parameters = new GetSeasonsParams
            {
                TvShowId = 1,
                Properties = new[] {SeasonProperties.ShowTitle},
                Limits = new Limits
                {
                    Start = 0,
                    End = 1
                }
            };

            var details = service.GetSeasons(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.That(details.Result.Seasons.Count, Is.EqualTo(1));
            Assert.IsInstanceOf<List<Season>>(details.Result.Seasons);
        }
    }
}
