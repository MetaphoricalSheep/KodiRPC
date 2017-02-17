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

using System.Diagnostics.CodeAnalysis;
using KodiRPC.ExceptionHandling.RPC;
using KodiRPC.Responses.Files;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.Files;
using KodiRPC.Services;
using KodiRPC.Tests.Unit.Common;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class GetDirectoryTests : BaseTest
    {
        [Test]
        public void GivenAString_WhenGettingDirectory_WithAValidPath_ItshouldReturnAListOfFiles()
        {
            var parameters = new GetDirectoryParams()
            {
                Directory = "dexter"
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;
            var actual = service.GetDirectory(parameters, "UnitTests");
            string expected;
            expected = "{}";
            //var expected = Episodes.GetEpisode(id);

            Assert.IsInstanceOf<JsonRpcResponse<GetDirectoryResponse>>(actual);
            Assert.That(actual.Result, Is.EqualTo(expected));
        }

        public void GivenAString_WhenGettingDirectory_WithAnInvalidPath_ItShouldThrowRpcInternalServerErrorException()
        {
            var parameters = new GetDirectoryParams()
            {
                Directory = "notdexter"
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;

            Assert.That(() => service.GetDirectory(parameters, "UnitTests"), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}
