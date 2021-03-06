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
    ///  Class for testing DistrictList
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DistrictListTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DistrictList
        //private DistrictList instance;

        public DistrictListTests()
        {
            // TODO uncomment below to create an instance of DistrictList
            //instance = new DistrictList();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DistrictList
        /// </summary>
        [Fact]
        public void DistrictListInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DistrictList
            //Assert.IsInstanceOfType<DistrictList> (instance, "variable 'instance' is a DistrictList");
        }


        /// <summary>
        /// Test the property 'Abbreviation'
        /// </summary>
        [Fact]
        public void AbbreviationTest()
        {
            // TODO unit test for the property 'Abbreviation'
        }
        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Fact]
        public void DisplayNameTest()
        {
            // TODO unit test for the property 'DisplayName'
        }
        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Fact]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }
        /// <summary>
        /// Test the property 'Year'
        /// </summary>
        [Fact]
        public void YearTest()
        {
            // TODO unit test for the property 'Year'
        }

    }

}
