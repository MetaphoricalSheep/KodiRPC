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
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetMoviesTests
    {
        [Test]
        public void WhenGettingAllMovies_ItShouldReturnAListOfMovies()
        {
            var service = new KodiService();

            var parameters = new GetMoviesParams
            {
                Properties = new[] {MovieProperties.Title, MovieProperties.Year}
            };

            var details = service.GetMovies(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.Greater(details.Result.Movies.Count, 0);
            Assert.IsInstanceOf<List<Movie>>(details.Result.Movies);
        }

        [Test]
        public void WhenGettingAllMovies_WithALimitOf0And1_ItShouldReturnAListWithOneMovie()
        {
            var service = new KodiService();

            var parameters = new GetMoviesParams
            {
                Properties = new[] {MovieProperties.Title},
                Limits = new Limits
                {
                    Start = 0,
                    End = 1
                }
            };

            var details = service.GetMovies(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.That(details.Result.Movies.Count, Is.EqualTo(1));
            Assert.IsInstanceOf<List<Movie>>(details.Result.Movies);
        }
    }
}