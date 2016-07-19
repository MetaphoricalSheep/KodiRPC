using KodiRPC.ExceptionHandling.RPC;
using KodiRPC.Responses.VideoLibrary;
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

            Assert.IsInstanceOf<GetEpisodeDetailsResponse>(actual);
            Assert.That(actual.Result.EpisodeDetails.EpisodeId, Is.EqualTo(expected.EpisodeDetails.EpisodeId));
            AssertThatPropertyValuesAreEquals(actual.Result, expected.EpisodeDetails);
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