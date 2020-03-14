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
    ///  Class for testing EventDistrictPointsTiebreakers
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EventDistrictPointsTiebreakersTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EventDistrictPointsTiebreakers
        //private EventDistrictPointsTiebreakers instance;

        public EventDistrictPointsTiebreakersTests()
        {
            // TODO uncomment below to create an instance of EventDistrictPointsTiebreakers
            //instance = new EventDistrictPointsTiebreakers();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventDistrictPointsTiebreakers
        /// </summary>
        [Fact]
        public void EventDistrictPointsTiebreakersInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EventDistrictPointsTiebreakers
            //Assert.IsInstanceOfType<EventDistrictPointsTiebreakers> (instance, "variable 'instance' is a EventDistrictPointsTiebreakers");
        }


        /// <summary>
        /// Test the property 'HighestQualScores'
        /// </summary>
        [Fact]
        public void HighestQualScoresTest()
        {
            // TODO unit test for the property 'HighestQualScores'
        }
        /// <summary>
        /// Test the property 'QualWins'
        /// </summary>
        [Fact]
        public void QualWinsTest()
        {
            // TODO unit test for the property 'QualWins'
        }

    }

}
