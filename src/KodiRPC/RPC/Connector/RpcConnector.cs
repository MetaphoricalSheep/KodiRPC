using System;
using System.IO;
using System.Net;
using System.Text;
using KodiRPC.ExceptionHandling.RPC;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.Services;
using Newtonsoft.Json;

namespace KodiRPC.RPC.Connector
{
    public class RpcConnector : IRpcConnector
    {
        private readonly KodiService _service;

        public RpcConnector(KodiService service)
        {
            _service = service;
        }

        public T MakeRequest<T>(string rpcMethod, object parameters, string id = "KodiJSON-RPC")
        {
            var jsonRpcRequest = new JsonRpcRequest
            {
                Id = id,
                Method = rpcMethod,
                Parameters = parameters
            };

            Console.WriteLine(jsonRpcRequest.ToString());

            var uri = $"{_service.Host}:{_service.Port}/jsonrpc";

            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.ContentType = "application/json-rpc";
            webRequest.KeepAlive = false;
            webRequest.Method = "POST";
            webRequest.Timeout = 50000;
            webRequest.Credentials = new NetworkCredential(_service.Username, _service.Password);

            try
            {
                using (var requestStream = webRequest.GetRequestStream())
                {
                    using (var requestWriter = new StreamWriter(requestStream, Encoding.ASCII))
                    {
                        requestWriter.Write(jsonRpcRequest.ToString());
                        requestWriter.Dispose();
                    }
                }
            }
            catch (Exception e)
            {
                throw new RpcException("There was a problem sending the request to Kodi.", e);
            }

            try
            {
                string json;

                using (var webResponse = webRequest.GetResponse())
                {
                    using (var responseStream = webResponse.GetResponseStream())
                    {
                        if (responseStream == null)
                        {
                            throw new RpcException("Response stream is empty.");
                        }

                        using (var responseReader = new StreamReader(responseStream, Encoding.UTF8))
                        {
                            json = responseReader.ReadToEnd();
                            responseReader.Dispose();
                        }
                    }
                }

                var rpcResponse = JsonConvert.DeserializeObject<JsonRpcResponse<T>>(json);

                if (rpcResponse.Error == null)
                {
                    return rpcResponse.Result;
                }

                var internalServerErrorException = new RpcInternalServerErrorException(rpcResponse.Error.Message)
                {
                    RpcErrorCode = rpcResponse.Error.Code
                };

                throw internalServerErrorException;
            }
            catch (WebException e)
            {
                var webResponse = e.Response as HttpWebResponse;

                if (webResponse != null)
                {
                    switch (webResponse.StatusCode)
                    {
                        case HttpStatusCode.InternalServerError:
                            {
                                using (var stream = webResponse.GetResponseStream())
                                {
                                    if (stream == null)
                                    {
                                        throw new RpcException("The RPC request was either not understood by the server or there was a problem executing the request", e);
                                    }

                                    using (var reader = new StreamReader(stream))
                                    {
                                        var result = reader.ReadToEnd();
                                        reader.Dispose();

                                        try
                                        {
                                            var jsonRpcResponseObject = JsonConvert.DeserializeObject<JsonRpcResponse<object>>(result);

                                            var internalServerErrorException = new RpcInternalServerErrorException(jsonRpcResponseObject.Error.Message, e)
                                            {
                                                RpcErrorCode = jsonRpcResponseObject.Error.Code
                                            };

                                            throw internalServerErrorException;
                                        }
                                        catch (JsonException)
                                        {
                                            throw new RpcException(result, e);
                                        }
                                    }
                                }
                            }

                        default:
                            throw new RpcException("The RPC request was either not understood by the server or there was a problem executing the request", e);
                    }
                }

                if (e.Message == "The operation has timed out")
                {
                    throw new RpcRequestTimeoutException(e.Message);
                }

                throw new RpcException("An unknown web exception occured while trying to read the JSON response", e);
            }
            catch (JsonException e)
            {
                throw new RpcResponseDeserializationException(
                    "There was a problem deserializing the response from Kodi.", e);
            }
            catch (ProtocolViolationException e)
            {
                throw new RpcException("Unable to connecto to the server.", e);
            }
            catch (Exception e)
            {
                throw new Exception($"A problem was encountered while calling MakeRpcRequest() for: {jsonRpcRequest.Method} \nException: {e.Message}"); // with parameters: {qryParams}. \nException: {e.Message}");
            }
        }
    }
}
