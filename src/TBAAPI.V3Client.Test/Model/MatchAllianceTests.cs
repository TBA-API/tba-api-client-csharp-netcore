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
    ///  Class for testing MatchAlliance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MatchAllianceTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MatchAlliance
        //private MatchAlliance instance;

        public MatchAllianceTests()
        {
            // TODO uncomment below to create an instance of MatchAlliance
            //instance = new MatchAlliance();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MatchAlliance
        /// </summary>
        [Fact]
        public void MatchAllianceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MatchAlliance
            //Assert.IsInstanceOfType<MatchAlliance> (instance, "variable 'instance' is a MatchAlliance");
        }


        /// <summary>
        /// Test the property 'Score'
        /// </summary>
        [Fact]
        public void ScoreTest()
        {
            // TODO unit test for the property 'Score'
        }
        /// <summary>
        /// Test the property 'TeamKeys'
        /// </summary>
        [Fact]
        public void TeamKeysTest()
        {
            // TODO unit test for the property 'TeamKeys'
        }
        /// <summary>
        /// Test the property 'SurrogateTeamKeys'
        /// </summary>
        [Fact]
        public void SurrogateTeamKeysTest()
        {
            // TODO unit test for the property 'SurrogateTeamKeys'
        }
        /// <summary>
        /// Test the property 'DqTeamKeys'
        /// </summary>
        [Fact]
        public void DqTeamKeysTest()
        {
            // TODO unit test for the property 'DqTeamKeys'
        }

    }

}
