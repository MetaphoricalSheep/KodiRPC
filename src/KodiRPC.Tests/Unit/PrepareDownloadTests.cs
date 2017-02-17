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

using KodiRPC.Responses.Files;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.Files;
using KodiRPC.Tests.Unit.Common;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class PrepareDownloadTests : BaseTest
    {
        [Test]
        public void GivenAString_WhenPreparingDownload_WithAValidPath_ItShouldReturnDownloadMethod()
        {
            var parameters = new PrepareDownloadParams()
            {
                Path = "dexter"
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;
            var actual = service.PrepareDownload(parameters, "UnitTests");
            var expected = "{}";

            Assert.IsInstanceOf<JsonRpcResponse<PrepareDownloadResponse>>(actual);
            AssertThatPropertyValuesAreEquals(actual.Result, expected);
        }
    }
}
