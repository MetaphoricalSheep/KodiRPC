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