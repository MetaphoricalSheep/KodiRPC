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
using System.Linq;
using KodiRPC.Responses.Files;
using KodiRPC.RPC.RequestResponse;
using KodiRPC.RPC.RequestResponse.Params.Files;
using KodiRPC.RPC.Specifications.Properties;
using KodiRPC.Services;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetDirectoryTests
    {
        [Test]
        public void WhenGettingDirectory_WithValidDirectory_ItShouldReturnADirectoryResult()
        {
            var service = new KodiService();
            var parameters = new GetDirectoryParams
            {
                Directory = "/media/gotham/series/Dark Matter/Season 01/",
                Properties = FileProperties.All()
            };
            var directory = service.GetDirectory(parameters);

            Assert.IsNotNull(directory);
            Assert.IsInstanceOf<JsonRpcResponse<GetDirectoryResponse>>(directory);
            Assert.AreEqual(directory.Result.Files.Count, 13);
            Assert.AreEqual(directory.Result.Files.FirstOrDefault(f => f.FilePath.Contains("S01E01"))?.FilePath, "/media/gotham/series/Dark Matter/Season 01/Dark Matter - S01E01 - Episode One.mkv");
        }

        [Test]
        public void WhenGettingDirectory_WithInvalidDirectory_ItShouldReturnAnException()
        {
            var service = new KodiService();
            Assert.That(() => service.GetDirectory(new GetDirectoryParams {Directory = "invalid path"}), Throws.Exception.TypeOf<Exception>());
        }
    }
}
