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
using System.Diagnostics.CodeAnalysis;
using KodiRPC.Responses.Files;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.Files;
using KodiRPC.RPC.Specifications.Properties;
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
            var parameters = new GetFileDetailsParams
            {
                File = "/media/gotham/series/Dark Matter/Season 02/Dark Matter - S02E03 - I’ve Seen the Other Side of You.mkv",
                Properties = FileProperties.All()
            };

            var fileDetails = service.GetFileDetails(parameters);

            Assert.IsNotNull(fileDetails);
            Assert.IsInstanceOf<JsonRpcResponse<GetFileDetailsResponse>>(fileDetails);
            StringAssert.IsMatch(fileDetails.Result.FileDetails.FilePath, "/media/gotham/series/Dark Matter/Season 02/Dark Matter - S02E03 - I’ve Seen the Other Side of You.mkv");
            Assert.AreEqual(fileDetails.Result.FileDetails.MimeType, "video/x-matroska");
            Assert.AreEqual(fileDetails.Result.FileDetails.Size, 857542653);
        }

        [Test]
        public void WhenGettingFileDetails_WithInvalidFile_ItShouldReturnAnException()
        {
            var service = new KodiService();

            Assert.That(() => service.GetFileDetails(new GetFileDetailsParams {File = "invalid path"}), Throws.Exception.TypeOf<Exception>());
        }
    }
}
