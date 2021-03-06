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
    ///  Class for testing Award
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AwardTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Award
        //private Award instance;

        public AwardTests()
        {
            // TODO uncomment below to create an instance of Award
            //instance = new Award();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Award
        /// </summary>
        [Fact]
        public void AwardInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Award
            //Assert.IsInstanceOfType<Award> (instance, "variable 'instance' is a Award");
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'AwardType'
        /// </summary>
        [Fact]
        public void AwardTypeTest()
        {
            // TODO unit test for the property 'AwardType'
        }
        /// <summary>
        /// Test the property 'EventKey'
        /// </summary>
        [Fact]
        public void EventKeyTest()
        {
            // TODO unit test for the property 'EventKey'
        }
        /// <summary>
        /// Test the property 'RecipientList'
        /// </summary>
        [Fact]
        public void RecipientListTest()
        {
            // TODO unit test for the property 'RecipientList'
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
