using System;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.Services;
using Moq;
using Newtonsoft.Json;

namespace KodiRPC.Tests.Unit
{
    public partial class GetMovieDetailsTests
    {
        public Mock<IKodiService> GetKodiServiceMock(int movieId)
        {
            var mock = new Mock<IKodiService>();

            mock.Setup(s => s.GetMovieDetails(movieId, null, null)).Returns(
                (int id, object properties, string requestId)  =>
                {
                    var json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"/../../App_Data/movie." + movieId + ".json");
                    var response = JsonConvert.DeserializeObject<JsonRpcResponse<GetMovieDetailsResponse>>(json);

                    return response.Result;
                }
            );

            return mock;
        }
    }
}
