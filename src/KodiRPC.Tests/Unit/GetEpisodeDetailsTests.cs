using KodiRPC.ExceptionHandling.RPC;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.Tests.Unit.Common;
using KodiRPC.Tests.Unit.Common.ExpectedResults;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class GetEpisodeDetailsTests : BaseTest
    {
        [Test]
        public void GivenAJsonString_WhenGettingAnEpisodeByEpisodeId_WithAValiEpisodeId_ItShouldReturnAnEpisode()
        {
            const Episodes.TestSet episodeId = Episodes.TestSet.Continuum;
            var mock = GetKodiServiceMock((int)episodeId);
            var service = mock.Object;
            var episode = service.GetEpisodeDetails((int)episodeId, null, null);
            var testCase = Episodes.GetEpisode(episodeId);

            Assert.IsInstanceOf<GetEpisodeDetailsResponse>(episode);
            Assert.That(episode.Result.EpisodeId, Is.EqualTo(testCase.Result.EpisodeId));
            AssertThatPropertyValuesAreEquals(episode.Result, testCase.Result);
        }

        [Test]
        public void GivenAJsonString_WhenGettingAnEpisodeByEpisodeId_WithAnInvalidEpisodeId_ItShouldThrowRpcInternalServerErrorException()
        {
            const Episodes.TestSet episodeId = Episodes.TestSet.InvalidId;
            var mock = GetKodiServiceMock((int)episodeId);
            var service = mock.Object;

            Assert.That(() => service.GetEpisodeDetails((int) episodeId, null, null), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}