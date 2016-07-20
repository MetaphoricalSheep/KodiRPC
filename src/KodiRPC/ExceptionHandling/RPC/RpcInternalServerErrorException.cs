using System;
using System.Runtime.Serialization;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.Specifications;

namespace KodiRPC.ExceptionHandling.RPC
{
    [Serializable]
    public class RpcInternalServerErrorException : Exception
    {
        public RpcErrorCode? RpcErrorCode { get; set; }

        public RpcInternalServerErrorException()
        {
        }

        public RpcInternalServerErrorException(string message) : base(message)
        {
        }

        public RpcInternalServerErrorException(string message, Exception e) : base(message, e)
        {
        }

        public RpcInternalServerErrorException(JsonRpcError error) : base(error.ToString())
        {
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            info.AddValue("RpcErrorCode", RpcErrorCode, typeof(RpcErrorCode));
            base.GetObjectData(info, context);
        }
    }
}
