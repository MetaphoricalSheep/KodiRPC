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
