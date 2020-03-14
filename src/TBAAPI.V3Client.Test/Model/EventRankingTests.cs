/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TBAAPI.V3Client.Api;
using TBAAPI.V3Client.Model;
using TBAAPI.V3Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TBAAPI.V3Client.Test
{
    /// <summary>
    ///  Class for testing EventRanking
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EventRankingTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EventRanking
        //private EventRanking instance;

        public EventRankingTests()
        {
            // TODO uncomment below to create an instance of EventRanking
            //instance = new EventRanking();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventRanking
        /// </summary>
        [Fact]
        public void EventRankingInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EventRanking
            //Assert.IsInstanceOfType<EventRanking> (instance, "variable 'instance' is a EventRanking");
        }


        /// <summary>
        /// Test the property 'Rankings'
        /// </summary>
        [Fact]
        public void RankingsTest()
        {
            // TODO unit test for the property 'Rankings'
        }
        /// <summary>
        /// Test the property 'ExtraStatsInfo'
        /// </summary>
        [Fact]
        public void ExtraStatsInfoTest()
        {
            // TODO unit test for the property 'ExtraStatsInfo'
        }
        /// <summary>
        /// Test the property 'SortOrderInfo'
        /// </summary>
        [Fact]
        public void SortOrderInfoTest()
        {
            // TODO unit test for the property 'SortOrderInfo'
        }

    }

}