using System;

namespace KodiRPC.ExceptionHandling.RPC
{
    public class RpcResponseDeserializationException : Exception
    {
        public RpcResponseDeserializationException()
        {
        }

        public RpcResponseDeserializationException(string message) : base(message)
        {
        }

        public RpcResponseDeserializationException(string message, Exception e) : base(message, e)
        {
        }

    }
}
