using System;

namespace KodiRPC.ExceptionHandling.RPC
{
    [Serializable]
    public class RpcRequestTimeoutException : Exception
    {
        public RpcRequestTimeoutException()
        {
        }

        public RpcRequestTimeoutException(string message) : base(message)
        {
        }

        public RpcRequestTimeoutException(string message, Exception e) : base(message, e)
        {
        }
    }
}
