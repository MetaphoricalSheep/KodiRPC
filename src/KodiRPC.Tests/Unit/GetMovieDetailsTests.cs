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
    public partial class GetMovieDetailsTests : BaseTest
    {
        [Test]
        public void GivenAJsonString_WhenGettingAMovieByMovieId_WithAValidMovieId_ItShouldReturnAMovie()
        {
            const Movies.TestSet id = Movies.TestSet.Spy;

            var parameters = new GetMovieDetailsParams
            {
                MovieId = (int) id,
                Properties = MovieProperties.All()
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;

            var actual = service.GetMovieDetails(parameters, "UnitTests");
            var expected = Movies.GetMovie(id);

            Assert.IsInstanceOf<JsonRpcResponse<GetMovieDetailsResponse>>(actual);
            Assert.That(actual.Result.MovieDetails.MovieId, Is.EqualTo(expected.MovieDetails.MovieId));
            AssertThatPropertyValuesAreEquals(actual.Result.MovieDetails, expected.MovieDetails);
        }

        [Test]
        public void GivenAJsonString_WhenGettingAMovieByMovieId_WithAnInvalidMovieId_ItShouldThrowRpcInternalServerErrorException()
        {
            const Movies.TestSet id = Movies.TestSet.InvalidId;

            var parameters = new GetMovieDetailsParams
            {
                MovieId = (int) id
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;

            Assert.That(() => service.GetMovieDetails(parameters, "UnitTests"), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}
