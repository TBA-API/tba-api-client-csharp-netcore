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
    ///  Class for testing MatchTimeseries2018
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MatchTimeseries2018Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MatchTimeseries2018
        //private MatchTimeseries2018 instance;

        public MatchTimeseries2018Tests()
        {
            // TODO uncomment below to create an instance of MatchTimeseries2018
            //instance = new MatchTimeseries2018();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MatchTimeseries2018
        /// </summary>
        [Fact]
        public void MatchTimeseries2018InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MatchTimeseries2018
            //Assert.IsInstanceOfType<MatchTimeseries2018> (instance, "variable 'instance' is a MatchTimeseries2018");
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
        /// Test the property 'MatchId'
        /// </summary>
        [Fact]
        public void MatchIdTest()
        {
            // TODO unit test for the property 'MatchId'
        }
        /// <summary>
        /// Test the property 'Mode'
        /// </summary>
        [Fact]
        public void ModeTest()
        {
            // TODO unit test for the property 'Mode'
        }
        /// <summary>
        /// Test the property 'Play'
        /// </summary>
        [Fact]
        public void PlayTest()
        {
            // TODO unit test for the property 'Play'
        }
        /// <summary>
        /// Test the property 'TimeRemaining'
        /// </summary>
        [Fact]
        public void TimeRemainingTest()
        {
            // TODO unit test for the property 'TimeRemaining'
        }
        /// <summary>
        /// Test the property 'BlueAutoQuest'
        /// </summary>
        [Fact]
        public void BlueAutoQuestTest()
        {
            // TODO unit test for the property 'BlueAutoQuest'
        }
        /// <summary>
        /// Test the property 'BlueBoostCount'
        /// </summary>
        [Fact]
        public void BlueBoostCountTest()
        {
            // TODO unit test for the property 'BlueBoostCount'
        }
        /// <summary>
        /// Test the property 'BlueBoostPlayed'
        /// </summary>
        [Fact]
        public void BlueBoostPlayedTest()
        {
            // TODO unit test for the property 'BlueBoostPlayed'
        }
        /// <summary>
        /// Test the property 'BlueCurrentPowerup'
        /// </summary>
        [Fact]
        public void BlueCurrentPowerupTest()
        {
            // TODO unit test for the property 'BlueCurrentPowerup'
        }
        /// <summary>
        /// Test the property 'BlueFaceTheBoss'
        /// </summary>
        [Fact]
        public void BlueFaceTheBossTest()
        {
            // TODO unit test for the property 'BlueFaceTheBoss'
        }
        /// <summary>
        /// Test the property 'BlueForceCount'
        /// </summary>
        [Fact]
        public void BlueForceCountTest()
        {
            // TODO unit test for the property 'BlueForceCount'
        }
        /// <summary>
        /// Test the property 'BlueForcePlayed'
        /// </summary>
        [Fact]
        public void BlueForcePlayedTest()
        {
            // TODO unit test for the property 'BlueForcePlayed'
        }
        /// <summary>
        /// Test the property 'BlueLevitateCount'
        /// </summary>
        [Fact]
        public void BlueLevitateCountTest()
        {
            // TODO unit test for the property 'BlueLevitateCount'
        }
        /// <summary>
        /// Test the property 'BlueLevitatePlayed'
        /// </summary>
        [Fact]
        public void BlueLevitatePlayedTest()
        {
            // TODO unit test for the property 'BlueLevitatePlayed'
        }
        /// <summary>
        /// Test the property 'BluePowerupTimeRemaining'
        /// </summary>
        [Fact]
        public void BluePowerupTimeRemainingTest()
        {
            // TODO unit test for the property 'BluePowerupTimeRemaining'
        }
        /// <summary>
        /// Test the property 'BlueScaleOwned'
        /// </summary>
        [Fact]
        public void BlueScaleOwnedTest()
        {
            // TODO unit test for the property 'BlueScaleOwned'
        }
        /// <summary>
        /// Test the property 'BlueScore'
        /// </summary>
        [Fact]
        public void BlueScoreTest()
        {
            // TODO unit test for the property 'BlueScore'
        }
        /// <summary>
        /// Test the property 'BlueSwitchOwned'
        /// </summary>
        [Fact]
        public void BlueSwitchOwnedTest()
        {
            // TODO unit test for the property 'BlueSwitchOwned'
        }
        /// <summary>
        /// Test the property 'RedAutoQuest'
        /// </summary>
        [Fact]
        public void RedAutoQuestTest()
        {
            // TODO unit test for the property 'RedAutoQuest'
        }
        /// <summary>
        /// Test the property 'RedBoostCount'
        /// </summary>
        [Fact]
        public void RedBoostCountTest()
        {
            // TODO unit test for the property 'RedBoostCount'
        }
        /// <summary>
        /// Test the property 'RedBoostPlayed'
        /// </summary>
        [Fact]
        public void RedBoostPlayedTest()
        {
            // TODO unit test for the property 'RedBoostPlayed'
        }
        /// <summary>
        /// Test the property 'RedCurrentPowerup'
        /// </summary>
        [Fact]
        public void RedCurrentPowerupTest()
        {
            // TODO unit test for the property 'RedCurrentPowerup'
        }
        /// <summary>
        /// Test the property 'RedFaceTheBoss'
        /// </summary>
        [Fact]
        public void RedFaceTheBossTest()
        {
            // TODO unit test for the property 'RedFaceTheBoss'
        }
        /// <summary>
        /// Test the property 'RedForceCount'
        /// </summary>
        [Fact]
        public void RedForceCountTest()
        {
            // TODO unit test for the property 'RedForceCount'
        }
        /// <summary>
        /// Test the property 'RedForcePlayed'
        /// </summary>
        [Fact]
        public void RedForcePlayedTest()
        {
            // TODO unit test for the property 'RedForcePlayed'
        }
        /// <summary>
        /// Test the property 'RedLevitateCount'
        /// </summary>
        [Fact]
        public void RedLevitateCountTest()
        {
            // TODO unit test for the property 'RedLevitateCount'
        }
        /// <summary>
        /// Test the property 'RedLevitatePlayed'
        /// </summary>
        [Fact]
        public void RedLevitatePlayedTest()
        {
            // TODO unit test for the property 'RedLevitatePlayed'
        }
        /// <summary>
        /// Test the property 'RedPowerupTimeRemaining'
        /// </summary>
        [Fact]
        public void RedPowerupTimeRemainingTest()
        {
            // TODO unit test for the property 'RedPowerupTimeRemaining'
        }
        /// <summary>
        /// Test the property 'RedScaleOwned'
        /// </summary>
        [Fact]
        public void RedScaleOwnedTest()
        {
            // TODO unit test for the property 'RedScaleOwned'
        }
        /// <summary>
        /// Test the property 'RedScore'
        /// </summary>
        [Fact]
        public void RedScoreTest()
        {
            // TODO unit test for the property 'RedScore'
        }
        /// <summary>
        /// Test the property 'RedSwitchOwned'
        /// </summary>
        [Fact]
        public void RedSwitchOwnedTest()
        {
            // TODO unit test for the property 'RedSwitchOwned'
        }

    }

}
