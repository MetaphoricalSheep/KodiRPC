using System;

namespace KodiRPC.ExceptionHandling.RPC
{
    [Serializable]
    public class RpcException : Exception
    {
        public RpcException()
        {
        }

        public RpcException(string message) : base(message)
        {
        }

        public RpcException(string message, Exception e) : base(message, e)
        {
        }
    }
}
