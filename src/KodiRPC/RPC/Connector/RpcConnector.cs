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

using System;
using System.Configuration;
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

        public JsonRpcResponse<T> MakeRequest<T>(string rpcMethod, object parameters, string id = "KodiJSON-RPC", int timeout = 50000)
        {
            var jsonRpcRequest = new JsonRpcRequest
            {
                Id = id,
                Method = rpcMethod,
                Parameters = parameters
            };

            if (Convert.ToBoolean(ConfigurationManager.AppSettings["Debug"]))
            {
                Console.WriteLine(jsonRpcRequest.ToString());
            }

            var uri = $"{_service.Host}:{_service.Port}/jsonrpc";

            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.ContentType = "application/json-rpc";
            webRequest.KeepAlive = false;
            webRequest.Method = "POST";
            webRequest.Timeout = timeout;
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
                    return rpcResponse;
                }

                var internalServerErrorException = new RpcInternalServerErrorException(rpcResponse.Error)
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
