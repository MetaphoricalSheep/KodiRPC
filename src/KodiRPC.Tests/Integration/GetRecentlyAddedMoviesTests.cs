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
    public class GetRecentlyAddedMoviesTests
    {
        [Test]
        public void WhenGettingAllRecentlyAddedMovies_ItShouldReturnAListOfMovies()
        {
            var service = new KodiService();

            var parameters = new GetRecentlyAddedMoviesParams
            {
                Properties = new[] {MovieProperties.Title, MovieProperties.Year}
            };

            var details = service.GetRecentlyAddedMovies(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.Greater(details.Result.Count, 0);
            Assert.IsInstanceOf<List<Movie>>(details.Result);
        }
    }
}
