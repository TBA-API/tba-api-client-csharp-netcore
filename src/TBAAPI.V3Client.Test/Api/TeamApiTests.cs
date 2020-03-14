/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using TBAAPI.V3Client.Client;
using TBAAPI.V3Client.Api;
using TBAAPI.V3Client.Model;

namespace TBAAPI.V3Client.Test
{
    /// <summary>
    ///  Class for testing TeamApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TeamApiTests : IDisposable
    {
        private TeamApi instance;

        public TeamApiTests()
        {
            instance = new TeamApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TeamApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamApi
            //Assert.IsType(typeof(TeamApi), instance, "instance is a TeamApi");
        }

        
        /// <summary>
        /// Test GetDistrictRankings
        /// </summary>
        [Fact]
        public void GetDistrictRankingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictRankings(districtKey, ifModifiedSince);
            //Assert.IsType<List<DistrictRanking>> (response, "response is List<DistrictRanking>");
        }
        
        /// <summary>
        /// Test GetDistrictTeams
        /// </summary>
        [Fact]
        public void GetDistrictTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictTeams(districtKey, ifModifiedSince);
            //Assert.IsType<List<Team>> (response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test GetDistrictTeamsKeys
        /// </summary>
        [Fact]
        public void GetDistrictTeamsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictTeamsKeys(districtKey, ifModifiedSince);
            //Assert.IsType<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetDistrictTeamsSimple
        /// </summary>
        [Fact]
        public void GetDistrictTeamsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictTeamsSimple(districtKey, ifModifiedSince);
            //Assert.IsType<List<TeamSimple>> (response, "response is List<TeamSimple>");
        }
        
        /// <summary>
        /// Test GetEventTeams
        /// </summary>
        [Fact]
        public void GetEventTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeams(eventKey, ifModifiedSince);
            //Assert.IsType<List<Team>> (response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test GetEventTeamsKeys
        /// </summary>
        [Fact]
        public void GetEventTeamsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeamsKeys(eventKey, ifModifiedSince);
            //Assert.IsType<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetEventTeamsSimple
        /// </summary>
        [Fact]
        public void GetEventTeamsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeamsSimple(eventKey, ifModifiedSince);
            //Assert.IsType<List<TeamSimple>> (response, "response is List<TeamSimple>");
        }
        
        /// <summary>
        /// Test GetEventTeamsStatuses
        /// </summary>
        [Fact]
        public void GetEventTeamsStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeamsStatuses(eventKey, ifModifiedSince);
            //Assert.IsType<Dictionary<string, TeamEventStatus>> (response, "response is Dictionary<string, TeamEventStatus>");
        }
        
        /// <summary>
        /// Test GetTeam
        /// </summary>
        [Fact]
        public void GetTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeam(teamKey, ifModifiedSince);
            //Assert.IsType<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test GetTeamAwards
        /// </summary>
        [Fact]
        public void GetTeamAwardsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamAwards(teamKey, ifModifiedSince);
            //Assert.IsType<List<Award>> (response, "response is List<Award>");
        }
        
        /// <summary>
        /// Test GetTeamAwardsByYear
        /// </summary>
        [Fact]
        public void GetTeamAwardsByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamAwardsByYear(teamKey, year, ifModifiedSince);
            //Assert.IsType<List<Award>> (response, "response is List<Award>");
        }
        
        /// <summary>
        /// Test GetTeamDistricts
        /// </summary>
        [Fact]
        public void GetTeamDistrictsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamDistricts(teamKey, ifModifiedSince);
            //Assert.IsType<List<DistrictList>> (response, "response is List<DistrictList>");
        }
        
        /// <summary>
        /// Test GetTeamEventAwards
        /// </summary>
        [Fact]
        public void GetTeamEventAwardsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventAwards(teamKey, eventKey, ifModifiedSince);
            //Assert.IsType<List<Award>> (response, "response is List<Award>");
        }
        
        /// <summary>
        /// Test GetTeamEventMatches
        /// </summary>
        [Fact]
        public void GetTeamEventMatchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventMatches(teamKey, eventKey, ifModifiedSince);
            //Assert.IsType<List<Match>> (response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetTeamEventMatchesKeys
        /// </summary>
        [Fact]
        public void GetTeamEventMatchesKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventMatchesKeys(teamKey, eventKey, ifModifiedSince);
            //Assert.IsType<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamEventMatchesSimple
        /// </summary>
        [Fact]
        public void GetTeamEventMatchesSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventMatchesSimple(teamKey, eventKey, ifModifiedSince);
            //Assert.IsType<List<Match>> (response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetTeamEventStatus
        /// </summary>
        [Fact]
        public void GetTeamEventStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventStatus(teamKey, eventKey, ifModifiedSince);
            //Assert.IsType<TeamEventStatus> (response, "response is TeamEventStatus");
        }
        
        /// <summary>
        /// Test GetTeamEvents
        /// </summary>
        [Fact]
        public void GetTeamEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEvents(teamKey, ifModifiedSince);
            //Assert.IsType<List<Event>> (response, "response is List<Event>");
        }
        
        /// <summary>
        /// Test GetTeamEventsByYear
        /// </summary>
        [Fact]
        public void GetTeamEventsByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsByYear(teamKey, year, ifModifiedSince);
            //Assert.IsType<List<Event>> (response, "response is List<Event>");
        }
        
        /// <summary>
        /// Test GetTeamEventsByYearKeys
        /// </summary>
        [Fact]
        public void GetTeamEventsByYearKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsByYearKeys(teamKey, year, ifModifiedSince);
            //Assert.IsType<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamEventsByYearSimple
        /// </summary>
        [Fact]
        public void GetTeamEventsByYearSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsByYearSimple(teamKey, year, ifModifiedSince);
            //Assert.IsType<List<EventSimple>> (response, "response is List<EventSimple>");
        }
        
        /// <summary>
        /// Test GetTeamEventsKeys
        /// </summary>
        [Fact]
        public void GetTeamEventsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsKeys(teamKey, ifModifiedSince);
            //Assert.IsType<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamEventsSimple
        /// </summary>
        [Fact]
        public void GetTeamEventsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsSimple(teamKey, ifModifiedSince);
            //Assert.IsType<List<EventSimple>> (response, "response is List<EventSimple>");
        }
        
        /// <summary>
        /// Test GetTeamEventsStatusesByYear
        /// </summary>
        [Fact]
        public void GetTeamEventsStatusesByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsStatusesByYear(teamKey, year, ifModifiedSince);
            //Assert.IsType<Dictionary<string, TeamEventStatus>> (response, "response is Dictionary<string, TeamEventStatus>");
        }
        
        /// <summary>
        /// Test GetTeamMatchesByYear
        /// </summary>
        [Fact]
        public void GetTeamMatchesByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMatchesByYear(teamKey, year, ifModifiedSince);
            //Assert.IsType<List<Match>> (response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetTeamMatchesByYearKeys
        /// </summary>
        [Fact]
        public void GetTeamMatchesByYearKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMatchesByYearKeys(teamKey, year, ifModifiedSince);
            //Assert.IsType<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamMatchesByYearSimple
        /// </summary>
        [Fact]
        public void GetTeamMatchesByYearSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMatchesByYearSimple(teamKey, year, ifModifiedSince);
            //Assert.IsType<List<MatchSimple>> (response, "response is List<MatchSimple>");
        }
        
        /// <summary>
        /// Test GetTeamMediaByTag
        /// </summary>
        [Fact]
        public void GetTeamMediaByTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string mediaTag = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMediaByTag(teamKey, mediaTag, ifModifiedSince);
            //Assert.IsType<List<Media>> (response, "response is List<Media>");
        }
        
        /// <summary>
        /// Test GetTeamMediaByTagYear
        /// </summary>
        [Fact]
        public void GetTeamMediaByTagYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string mediaTag = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMediaByTagYear(teamKey, mediaTag, year, ifModifiedSince);
            //Assert.IsType<List<Media>> (response, "response is List<Media>");
        }
        
        /// <summary>
        /// Test GetTeamMediaByYear
        /// </summary>
        [Fact]
        public void GetTeamMediaByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMediaByYear(teamKey, year, ifModifiedSince);
            //Assert.IsType<List<Media>> (response, "response is List<Media>");
        }
        
        /// <summary>
        /// Test GetTeamRobots
        /// </summary>
        [Fact]
        public void GetTeamRobotsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamRobots(teamKey, ifModifiedSince);
            //Assert.IsType<List<TeamRobot>> (response, "response is List<TeamRobot>");
        }
        
        /// <summary>
        /// Test GetTeamSimple
        /// </summary>
        [Fact]
        public void GetTeamSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamSimple(teamKey, ifModifiedSince);
            //Assert.IsType<TeamSimple> (response, "response is TeamSimple");
        }
        
        /// <summary>
        /// Test GetTeamSocialMedia
        /// </summary>
        [Fact]
        public void GetTeamSocialMediaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamSocialMedia(teamKey, ifModifiedSince);
            //Assert.IsType<List<Media>> (response, "response is List<Media>");
        }
        
        /// <summary>
        /// Test GetTeamYearsParticipated
        /// </summary>
        [Fact]
        public void GetTeamYearsParticipatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamYearsParticipated(teamKey, ifModifiedSince);
            //Assert.IsType<List<int>> (response, "response is List<int>");
        }
        
        /// <summary>
        /// Test GetTeams
        /// </summary>
        [Fact]
        public void GetTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeams(pageNum, ifModifiedSince);
            //Assert.IsType<List<Team>> (response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test GetTeamsByYear
        /// </summary>
        [Fact]
        public void GetTeamsByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //int pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamsByYear(year, pageNum, ifModifiedSince);
            //Assert.IsType<List<Team>> (response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test GetTeamsByYearKeys
        /// </summary>
        [Fact]
        public void GetTeamsByYearKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //int pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamsByYearKeys(year, pageNum, ifModifiedSince);
            //Assert.IsType<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamsByYearSimple
        /// </summary>
        [Fact]
        public void GetTeamsByYearSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //int pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamsByYearSimple(year, pageNum, ifModifiedSince);
            //Assert.IsType<List<TeamSimple>> (response, "response is List<TeamSimple>");
        }
        
        /// <summary>
        /// Test GetTeamsKeys
        /// </summary>
        [Fact]
        public void GetTeamsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamsKeys(pageNum, ifModifiedSince);
            //Assert.IsType<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamsSimple
        /// </summary>
        [Fact]
        public void GetTeamsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamsSimple(pageNum, ifModifiedSince);
            //Assert.IsType<List<TeamSimple>> (response, "response is List<TeamSimple>");
        }
        
    }

}