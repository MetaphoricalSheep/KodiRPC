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
using KodiRPC.Responses.Files;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.Files;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.Services;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class PrepareDownloadTests
    {
        [Test]
        public void WhenPreparingDownload_WithValidPath_ItShouldReturnAString()
        {
            var service = new KodiService();
            var prepareDownload = service.PrepareDownload(new PrepareDownloadParams(){Path="valid path"});

            Assert.IsNotNull(prepareDownload);
            Assert.IsInstanceOf<JsonRpcResponse<PrepareDownloadResponse>>(prepareDownload.Result);
            Assert.AreEqual(prepareDownload.Result.Details, "some valid url");
        }

        [Test]
        public void WhenPreparingDownload_WithInvalidPath_ItShouldReturnAnException()
        {
            var service = new KodiService();
            var prepareDownload = service.PrepareDownload(new PrepareDownloadParams(){Path="Invalid path"});

            Assert.IsNotNull(prepareDownload);
            Assert.IsInstanceOf<JsonRpcResponse<PrepareDownloadResponse>>(prepareDownload.Result);
            Assert.IsNotNull(prepareDownload.Error);
        }
    }
}
