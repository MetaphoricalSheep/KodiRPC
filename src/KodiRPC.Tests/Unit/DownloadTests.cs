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

using KodiRPC.ExceptionHandling.RPC;
using KodiRPC.Responses.Files;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.Files;
using KodiRPC.Tests.Unit.Common;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class DownloadTests : BaseTest
    {
        [Test]
        public void GivenAString_WhenDownloadingFile_WithAValidPath_ItshouldReturnAFile()
        {
            var parameters = new DownloadParams()
            {
                Path = "/media/gotham/series/Dexter/Season 05/Dexter - S05E06 - Everything Is Illumenated.mkv"
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;
            var actual = service.Download(parameters, "UnitTests");
            const string expected = "downloading...";

            Assert.IsInstanceOf<JsonRpcResponse<DownloadResponse>>(actual);
            Assert.That(actual.Result, Is.EqualTo(expected));
        }

        public void GivenAString_WhenDownload_ItShouldThrowRpcInternalServerErrorException()
        {
            var parameters = new DownloadParams()
            {
                Path = "/media/gotham/series/Dexter/Season 05/Dexter - S05E06 - Nothing Is Illumenated.mkv"
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;

            Assert.That(() => service.Download(parameters, "UnitTests"), Throws.Exception.TypeOf<RpcInternalServerErrorException>());
        }
    }
}
