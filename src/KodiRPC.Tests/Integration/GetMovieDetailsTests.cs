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
    public class GetMovieDetailsTests
    {
        [Test]
        public void WhenGettingMovieDetails_WithAMovieIdOfOne_ItShouldReturnAMovie()
        {
            var service = new KodiService();

            var parameters = new GetMovieDetailsParams
            {
                MovieId = 1,
                Properties = new[] {MovieProperties.Title, MovieProperties.Year}
            };

            var details = service.GetMovieDetails(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.AreEqual(1, details.Result.MovieDetails.MovieId);
        }

        [Test]
        public void WhenGettingMovieDetails_WithAnInvalidMovieId_ItShouldThrowException()
        {
            var service = new KodiService();

            var parameters = new GetMovieDetailsParams
            {
                MovieId = (int)Movies.TestSet.InvalidId,
            };

            Assert.That(() => service.GetMovieDetails(parameters, "UnitTests"), Throws.Exception.TypeOf<Exception>());
        }
    }
}
