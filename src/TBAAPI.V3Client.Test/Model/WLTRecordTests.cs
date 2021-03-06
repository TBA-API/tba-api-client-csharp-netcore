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
    ///  Class for testing WLTRecord
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WLTRecordTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WLTRecord
        //private WLTRecord instance;

        public WLTRecordTests()
        {
            // TODO uncomment below to create an instance of WLTRecord
            //instance = new WLTRecord();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WLTRecord
        /// </summary>
        [Fact]
        public void WLTRecordInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" WLTRecord
            //Assert.IsInstanceOfType<WLTRecord> (instance, "variable 'instance' is a WLTRecord");
        }


        /// <summary>
        /// Test the property 'Losses'
        /// </summary>
        [Fact]
        public void LossesTest()
        {
            // TODO unit test for the property 'Losses'
        }
        /// <summary>
        /// Test the property 'Wins'
        /// </summary>
        [Fact]
        public void WinsTest()
        {
            // TODO unit test for the property 'Wins'
        }
        /// <summary>
        /// Test the property 'Ties'
        /// </summary>
        [Fact]
        public void TiesTest()
        {
            // TODO unit test for the property 'Ties'
        }

    }

}
