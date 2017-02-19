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

namespace KodiRPC.RPC.Specifications
{
    public enum RpcErrorCode
    {
        //! Standard JSON-RPC 2.0 errors
        RPC_INVALID_REQUEST = -32600,
        RPC_METHOD_NOT_FOUND = -32601,
        RPC_INVALID_PARAMS = -32602,
        RPC_INTERNAL_ERROR = -32603,
        RPC_PARSE_ERROR = -32700
    }
}
