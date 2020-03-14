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
    ///  Class for testing MatchScoreBreakdown2017
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MatchScoreBreakdown2017Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MatchScoreBreakdown2017
        //private MatchScoreBreakdown2017 instance;

        public MatchScoreBreakdown2017Tests()
        {
            // TODO uncomment below to create an instance of MatchScoreBreakdown2017
            //instance = new MatchScoreBreakdown2017();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MatchScoreBreakdown2017
        /// </summary>
        [Fact]
        public void MatchScoreBreakdown2017InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MatchScoreBreakdown2017
            //Assert.IsInstanceOfType<MatchScoreBreakdown2017> (instance, "variable 'instance' is a MatchScoreBreakdown2017");
        }


        /// <summary>
        /// Test the property 'Blue'
        /// </summary>
        [Fact]
        public void BlueTest()
        {
            // TODO unit test for the property 'Blue'
        }
        /// <summary>
        /// Test the property 'Red'
        /// </summary>
        [Fact]
        public void RedTest()
        {
            // TODO unit test for the property 'Red'
        }

    }

}