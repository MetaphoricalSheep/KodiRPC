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
    public class GetTvShowDetailsTests
    {
        [Test]
        public void WhenGettingTvShowDetails_WithATvShowIdOfOne_ItShouldReturnATvShow()
        {
            var service = new KodiService();

            var parameters = new GetTvShowDetailsParams
            {
                TvShowId = 1,
                Properties = new[] {TvShowProperties.Title, TvShowProperties.Year}
            };

            var details = service.GetTvShowDetails(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.AreEqual(1, details.Result.TvShowDetails.TvShowId);
        }

        [Test]
        public void WhenGettingTvShowDetails_WithAnInvalidTvShowId_ItShouldThrowException()
        {
            var service = new KodiService();

            var parameters = new GetTvShowDetailsParams
            {
                TvShowId = (int)TvShows.TestSet.InvalidId,
            };

            Assert.That(() => service.GetTvShowDetails(parameters, "UnitTests"), Throws.Exception.TypeOf<Exception>());
        }
    }
}
