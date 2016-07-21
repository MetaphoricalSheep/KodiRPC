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
