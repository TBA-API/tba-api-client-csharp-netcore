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
    ///  Class for testing DistrictApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DistrictApiTests : IDisposable
    {
        private DistrictApi instance;

        public DistrictApiTests()
        {
            instance = new DistrictApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DistrictApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DistrictApi
            //Assert.IsType(typeof(DistrictApi), instance, "instance is a DistrictApi");
        }

        
        /// <summary>
        /// Test GetDistrictEvents
        /// </summary>
        [Fact]
        public void GetDistrictEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictEvents(districtKey, ifModifiedSince);
            //Assert.IsType<List<Event>> (response, "response is List<Event>");
        }
        
        /// <summary>
        /// Test GetDistrictEventsKeys
        /// </summary>
        [Fact]
        public void GetDistrictEventsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictEventsKeys(districtKey, ifModifiedSince);
            //Assert.IsType<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetDistrictEventsSimple
        /// </summary>
        [Fact]
        public void GetDistrictEventsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictEventsSimple(districtKey, ifModifiedSince);
            //Assert.IsType<List<EventSimple>> (response, "response is List<EventSimple>");
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
        /// Test GetDistrictsByYear
        /// </summary>
        [Fact]
        public void GetDistrictsByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictsByYear(year, ifModifiedSince);
            //Assert.IsType<List<DistrictList>> (response, "response is List<DistrictList>");
        }
        
        /// <summary>
        /// Test GetEventDistrictPoints
        /// </summary>
        [Fact]
        public void GetEventDistrictPointsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventDistrictPoints(eventKey, ifModifiedSince);
            //Assert.IsType<EventDistrictPoints> (response, "response is EventDistrictPoints");
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
        
    }

}