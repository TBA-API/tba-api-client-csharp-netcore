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
    ///  Class for testing APIStatusAppVersion
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class APIStatusAppVersionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for APIStatusAppVersion
        //private APIStatusAppVersion instance;

        public APIStatusAppVersionTests()
        {
            // TODO uncomment below to create an instance of APIStatusAppVersion
            //instance = new APIStatusAppVersion();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of APIStatusAppVersion
        /// </summary>
        [Fact]
        public void APIStatusAppVersionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" APIStatusAppVersion
            //Assert.IsInstanceOfType<APIStatusAppVersion> (instance, "variable 'instance' is a APIStatusAppVersion");
        }


        /// <summary>
        /// Test the property 'MinAppVersion'
        /// </summary>
        [Fact]
        public void MinAppVersionTest()
        {
            // TODO unit test for the property 'MinAppVersion'
        }
        /// <summary>
        /// Test the property 'LatestAppVersion'
        /// </summary>
        [Fact]
        public void LatestAppVersionTest()
        {
            // TODO unit test for the property 'LatestAppVersion'
        }

    }

}
