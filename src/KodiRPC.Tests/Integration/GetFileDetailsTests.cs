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
    public class GetFileDetailsTests
    {
        [Test]
        public void WhenGettingFileDetails_WithValidFile_ItShouldReturnAFileResult()
        {
            var service = new KodiService();
            var fileDetails = service.GetFileDetails(new GetFileDetailsParams(){ File = "some kodi string path" });

            Assert.IsNotNull(fileDetails);
            Assert.IsInstanceOf<JsonRpcResponse<GetFileDetailsResponse>>(fileDetails.Result);
            StringAssert.IsMatch(fileDetails.Result.FileDetails.FilePath, "OK");
        }

        [Test]
        public void WhenGettingFileDetails_WithInvalidFile_ItShouldReturnAnException()
        {
            var service = new KodiService();
            var fileDetails = service.GetFileDetails(new GetFileDetailsParams() {File = "invalid path"});

            Assert.IsNotNull(fileDetails);
            Assert.IsInstanceOf<JsonRpcResponse<GetFileDetailsResponse>>(fileDetails.Result);
            Assert.IsNotNull(fileDetails.Error);
        }
    }
}
