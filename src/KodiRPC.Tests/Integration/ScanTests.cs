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

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties.Video.Details;
using KodiRPC.Services;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class ScanTests
    {
        [Test]
        public void WhenScanningKodi_ItShouldReturnAStringResult()
        {
            var service = new KodiService();
            var scan = service.Scan(new ScanParams());

            Assert.IsNotNull(scan);
            StringAssert.IsMatch(scan.Result, "OK");
            Assert.IsInstanceOf<JsonRpcResponse<string>>(scan);
        }
    }
}
