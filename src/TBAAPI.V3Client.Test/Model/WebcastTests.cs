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
    ///  Class for testing Webcast
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WebcastTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Webcast
        //private Webcast instance;

        public WebcastTests()
        {
            // TODO uncomment below to create an instance of Webcast
            //instance = new Webcast();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Webcast
        /// </summary>
        [Fact]
        public void WebcastInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Webcast
            //Assert.IsInstanceOfType<Webcast> (instance, "variable 'instance' is a Webcast");
        }


        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Channel'
        /// </summary>
        [Fact]
        public void ChannelTest()
        {
            // TODO unit test for the property 'Channel'
        }
        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Fact]
        public void DateTest()
        {
            // TODO unit test for the property 'Date'
        }
        /// <summary>
        /// Test the property 'File'
        /// </summary>
        [Fact]
        public void FileTest()
        {
            // TODO unit test for the property 'File'
        }

    }

}
