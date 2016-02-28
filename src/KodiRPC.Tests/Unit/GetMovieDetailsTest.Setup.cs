using System;
using KodiRPC.ExceptionHandling.RPC;
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
                    string json;

                    try
                    {
                        json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"/../../App_Data/movie." + movieId + ".json");
                    }
                    catch (Exception)
                    {
                        json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"/../../App_Data/movie.error.json");
                    }

                    var response = JsonConvert.DeserializeObject<JsonRpcResponse<GetMovieDetailsResponse>>(json);

                    if (response.Error == null)
                    {
                        return response.Result;
                    }

                    var internalServerErrorException = new RpcInternalServerErrorException(response.Error.Message)
                    {
                        RpcErrorCode = response.Error.Code
                    };

                    throw internalServerErrorException;
                }
            );

            return mock;
        }
    }
}
