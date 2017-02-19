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
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.RPC.RequestResponse.Params;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties.Video.Details;
using KodiRPC.Services;
using NUnit.Framework;

namespace KodiRPC.Tests.Integration
{
    [ExcludeFromCodeCoverage]
    public class GetEpisodesTests
    {
        [Test]
        public void WhenGettingAllEpisodes_ItShouldReturnAListOfEpisodes()
        {
            var service = new KodiService();

            var parameters = new GetEpisodesParams
            {
                Properties = new[] { EpisodeProperties.Title, EpisodeProperties.UniqueId }
            };

            var details = service.GetEpisodes(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.That(details.Result.Episodes.Count, Is.GreaterThan(0));
            Assert.IsInstanceOf<List<Episode>>(details.Result.Episodes);
        }

        [Test]
        public void WhenGettingAllEpisodes_WithALimitOf0And1_ItShouldReturnAListWithOneEpisode()
        {
            var service = new KodiService();

            var parameters = new GetEpisodesParams
            {
                Properties = new[] { EpisodeProperties.Title, EpisodeProperties.UniqueId },
                Limits = new Limits
                {
                    Start = 0,
                    End = 1
                }
            };

            var details = service.GetEpisodes(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.That(details.Result.Episodes.Count, Is.EqualTo(1));
            Assert.IsInstanceOf<List<Episode>>(details.Result.Episodes);
        }

        [Test]
        public void WhenGettingAllEpisodes_WithAnTvShowIdOf1_ItShouldReturnAListOfEpisodesBelongingToTvShow()
        {
            var service = new KodiService();

            var parameters = new GetEpisodesParams
            {
                TvShowId = 1,
                Properties = new[] { EpisodeProperties.Title, EpisodeProperties.TvShowId }
            };

            var details = service.GetEpisodes(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.IsInstanceOf<List<Episode>>(details.Result.Episodes);
            Assert.That(details.Result.Episodes.Find(s => s.TvShowId != 1), Is.Null);
        }

        [Test]
        public void WhenGettingAllEpisodes_WithAnTvShowId1AndSeasonNumber1_ItShouldReturnAListOfEpisodesBelongingToSeason()
        {
            var service = new KodiService();

            var parameters = new GetEpisodesParams
            {
                TvShowId = 1,
                SeasonNumber = 1,
                Properties = new[] { EpisodeProperties.Title, EpisodeProperties.Season }
            };

            var details = service.GetEpisodes(parameters);

            Assert.IsNotNull(details);
            Assert.IsNotNull(details.Result);
            Assert.IsInstanceOf<List<Episode>>(details.Result.Episodes);
            Console.WriteLine(details.Result.Episodes.Find(s => s.TvShowId != 1).Title);
            Console.WriteLine(details.Result.Episodes.Find(s => s.TvShowId != 1).TvShowId);
            Assert.That(details.Result.Episodes.Find(s => s.Season != 1), Is.Null);
        }
    }
}