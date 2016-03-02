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
        public void GivenAJsonString_WhenGettingAnEpisodeByEpisodeId_WithAValidEpisodeId_ItShouldReturnAnEpisode()
        {
            const Episodes.TestSet id = Episodes.TestSet.Continuum;
            var mock = GetKodiServiceMock((int)id);
            var service = mock.Object;
            var actual = service.GetEpisodeDetails((int)id, null, null);
            var expected = Episodes.GetEpisode(id);

            Assert.IsInstanceOf<GetEpisodeDetailsResponse>(actual);
            Assert.That(actual.Result.EpisodeId, Is.EqualTo(expected.Result.EpisodeId));
            AssertThatPropertyValuesAreEquals(actual.Result, expected.Result);
        }

        [Test]
        public void GivenAJsonString_WhenGettingAnEpisodeByEpisodeId_WithAnInvalidEpisodeId_ItShouldThrowRpcInternalServerErrorException()
        {
            const Episodes.TestSet id = Episodes.TestSet.InvalidId;
            var mock = GetKodiServiceMock((int)id);
            var service = mock.Object;

            Assert.That(() => service.GetEpisodeDetails((int) id, null, null), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}