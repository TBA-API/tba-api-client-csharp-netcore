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
    ///  Class for testing EventDistrictPointsPoints
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EventDistrictPointsPointsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EventDistrictPointsPoints
        //private EventDistrictPointsPoints instance;

        public EventDistrictPointsPointsTests()
        {
            // TODO uncomment below to create an instance of EventDistrictPointsPoints
            //instance = new EventDistrictPointsPoints();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventDistrictPointsPoints
        /// </summary>
        [Fact]
        public void EventDistrictPointsPointsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EventDistrictPointsPoints
            //Assert.IsInstanceOfType<EventDistrictPointsPoints> (instance, "variable 'instance' is a EventDistrictPointsPoints");
        }


        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Fact]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'AlliancePoints'
        /// </summary>
        [Fact]
        public void AlliancePointsTest()
        {
            // TODO unit test for the property 'AlliancePoints'
        }
        /// <summary>
        /// Test the property 'ElimPoints'
        /// </summary>
        [Fact]
        public void ElimPointsTest()
        {
            // TODO unit test for the property 'ElimPoints'
        }
        /// <summary>
        /// Test the property 'AwardPoints'
        /// </summary>
        [Fact]
        public void AwardPointsTest()
        {
            // TODO unit test for the property 'AwardPoints'
        }
        /// <summary>
        /// Test the property 'QualPoints'
        /// </summary>
        [Fact]
        public void QualPointsTest()
        {
            // TODO unit test for the property 'QualPoints'
        }

    }

}