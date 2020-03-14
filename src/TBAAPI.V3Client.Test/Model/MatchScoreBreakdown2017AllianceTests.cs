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
    ///  Class for testing MatchScoreBreakdown2017Alliance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MatchScoreBreakdown2017AllianceTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MatchScoreBreakdown2017Alliance
        //private MatchScoreBreakdown2017Alliance instance;

        public MatchScoreBreakdown2017AllianceTests()
        {
            // TODO uncomment below to create an instance of MatchScoreBreakdown2017Alliance
            //instance = new MatchScoreBreakdown2017Alliance();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MatchScoreBreakdown2017Alliance
        /// </summary>
        [Fact]
        public void MatchScoreBreakdown2017AllianceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MatchScoreBreakdown2017Alliance
            //Assert.IsInstanceOfType<MatchScoreBreakdown2017Alliance> (instance, "variable 'instance' is a MatchScoreBreakdown2017Alliance");
        }


        /// <summary>
        /// Test the property 'AutoPoints'
        /// </summary>
        [Fact]
        public void AutoPointsTest()
        {
            // TODO unit test for the property 'AutoPoints'
        }
        /// <summary>
        /// Test the property 'TeleopPoints'
        /// </summary>
        [Fact]
        public void TeleopPointsTest()
        {
            // TODO unit test for the property 'TeleopPoints'
        }
        /// <summary>
        /// Test the property 'FoulPoints'
        /// </summary>
        [Fact]
        public void FoulPointsTest()
        {
            // TODO unit test for the property 'FoulPoints'
        }
        /// <summary>
        /// Test the property 'AdjustPoints'
        /// </summary>
        [Fact]
        public void AdjustPointsTest()
        {
            // TODO unit test for the property 'AdjustPoints'
        }
        /// <summary>
        /// Test the property 'TotalPoints'
        /// </summary>
        [Fact]
        public void TotalPointsTest()
        {
            // TODO unit test for the property 'TotalPoints'
        }
        /// <summary>
        /// Test the property 'Robot1Auto'
        /// </summary>
        [Fact]
        public void Robot1AutoTest()
        {
            // TODO unit test for the property 'Robot1Auto'
        }
        /// <summary>
        /// Test the property 'Robot2Auto'
        /// </summary>
        [Fact]
        public void Robot2AutoTest()
        {
            // TODO unit test for the property 'Robot2Auto'
        }
        /// <summary>
        /// Test the property 'Robot3Auto'
        /// </summary>
        [Fact]
        public void Robot3AutoTest()
        {
            // TODO unit test for the property 'Robot3Auto'
        }
        /// <summary>
        /// Test the property 'Rotor1Auto'
        /// </summary>
        [Fact]
        public void Rotor1AutoTest()
        {
            // TODO unit test for the property 'Rotor1Auto'
        }
        /// <summary>
        /// Test the property 'Rotor2Auto'
        /// </summary>
        [Fact]
        public void Rotor2AutoTest()
        {
            // TODO unit test for the property 'Rotor2Auto'
        }
        /// <summary>
        /// Test the property 'AutoFuelLow'
        /// </summary>
        [Fact]
        public void AutoFuelLowTest()
        {
            // TODO unit test for the property 'AutoFuelLow'
        }
        /// <summary>
        /// Test the property 'AutoFuelHigh'
        /// </summary>
        [Fact]
        public void AutoFuelHighTest()
        {
            // TODO unit test for the property 'AutoFuelHigh'
        }
        /// <summary>
        /// Test the property 'AutoMobilityPoints'
        /// </summary>
        [Fact]
        public void AutoMobilityPointsTest()
        {
            // TODO unit test for the property 'AutoMobilityPoints'
        }
        /// <summary>
        /// Test the property 'AutoRotorPoints'
        /// </summary>
        [Fact]
        public void AutoRotorPointsTest()
        {
            // TODO unit test for the property 'AutoRotorPoints'
        }
        /// <summary>
        /// Test the property 'AutoFuelPoints'
        /// </summary>
        [Fact]
        public void AutoFuelPointsTest()
        {
            // TODO unit test for the property 'AutoFuelPoints'
        }
        /// <summary>
        /// Test the property 'TeleopFuelPoints'
        /// </summary>
        [Fact]
        public void TeleopFuelPointsTest()
        {
            // TODO unit test for the property 'TeleopFuelPoints'
        }
        /// <summary>
        /// Test the property 'TeleopFuelLow'
        /// </summary>
        [Fact]
        public void TeleopFuelLowTest()
        {
            // TODO unit test for the property 'TeleopFuelLow'
        }
        /// <summary>
        /// Test the property 'TeleopFuelHigh'
        /// </summary>
        [Fact]
        public void TeleopFuelHighTest()
        {
            // TODO unit test for the property 'TeleopFuelHigh'
        }
        /// <summary>
        /// Test the property 'TeleopRotorPoints'
        /// </summary>
        [Fact]
        public void TeleopRotorPointsTest()
        {
            // TODO unit test for the property 'TeleopRotorPoints'
        }
        /// <summary>
        /// Test the property 'KPaRankingPointAchieved'
        /// </summary>
        [Fact]
        public void KPaRankingPointAchievedTest()
        {
            // TODO unit test for the property 'KPaRankingPointAchieved'
        }
        /// <summary>
        /// Test the property 'TeleopTakeoffPoints'
        /// </summary>
        [Fact]
        public void TeleopTakeoffPointsTest()
        {
            // TODO unit test for the property 'TeleopTakeoffPoints'
        }
        /// <summary>
        /// Test the property 'KPaBonusPoints'
        /// </summary>
        [Fact]
        public void KPaBonusPointsTest()
        {
            // TODO unit test for the property 'KPaBonusPoints'
        }
        /// <summary>
        /// Test the property 'RotorBonusPoints'
        /// </summary>
        [Fact]
        public void RotorBonusPointsTest()
        {
            // TODO unit test for the property 'RotorBonusPoints'
        }
        /// <summary>
        /// Test the property 'Rotor1Engaged'
        /// </summary>
        [Fact]
        public void Rotor1EngagedTest()
        {
            // TODO unit test for the property 'Rotor1Engaged'
        }
        /// <summary>
        /// Test the property 'Rotor2Engaged'
        /// </summary>
        [Fact]
        public void Rotor2EngagedTest()
        {
            // TODO unit test for the property 'Rotor2Engaged'
        }
        /// <summary>
        /// Test the property 'Rotor3Engaged'
        /// </summary>
        [Fact]
        public void Rotor3EngagedTest()
        {
            // TODO unit test for the property 'Rotor3Engaged'
        }
        /// <summary>
        /// Test the property 'Rotor4Engaged'
        /// </summary>
        [Fact]
        public void Rotor4EngagedTest()
        {
            // TODO unit test for the property 'Rotor4Engaged'
        }
        /// <summary>
        /// Test the property 'RotorRankingPointAchieved'
        /// </summary>
        [Fact]
        public void RotorRankingPointAchievedTest()
        {
            // TODO unit test for the property 'RotorRankingPointAchieved'
        }
        /// <summary>
        /// Test the property 'TechFoulCount'
        /// </summary>
        [Fact]
        public void TechFoulCountTest()
        {
            // TODO unit test for the property 'TechFoulCount'
        }
        /// <summary>
        /// Test the property 'FoulCount'
        /// </summary>
        [Fact]
        public void FoulCountTest()
        {
            // TODO unit test for the property 'FoulCount'
        }
        /// <summary>
        /// Test the property 'TouchpadNear'
        /// </summary>
        [Fact]
        public void TouchpadNearTest()
        {
            // TODO unit test for the property 'TouchpadNear'
        }
        /// <summary>
        /// Test the property 'TouchpadMiddle'
        /// </summary>
        [Fact]
        public void TouchpadMiddleTest()
        {
            // TODO unit test for the property 'TouchpadMiddle'
        }
        /// <summary>
        /// Test the property 'TouchpadFar'
        /// </summary>
        [Fact]
        public void TouchpadFarTest()
        {
            // TODO unit test for the property 'TouchpadFar'
        }

    }

}