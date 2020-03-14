# TBAAPI.V3Client - the C# library for the The Blue Alliance API v3

# Overview 

 Information and statistics about FIRST Robotics Competition teams and events. 

# Authentication 

All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account). 

 A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 3.8.0
- SDK version: 3.8.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.10.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [CompareNETObjects](https://www.nuget.org/packages/CompareNETObjects) - 4.57.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
Install-Package CompareNETObjects
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using TBAAPI.V3Client.Api;
using TBAAPI.V3Client.Client;
using TBAAPI.V3Client.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TBAAPI.V3Client.Api;
using TBAAPI.V3Client.Client;
using TBAAPI.V3Client.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://www.thebluealliance.com/api/v3";
            // Configure API key authorization: apiKey
            config.ApiKey.Add("X-TBA-Auth-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new DistrictApi(config);
            var districtKey = districtKey_example;  // string | TBA District Key, eg `2016fim`
            var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List<Event> result = apiInstance.GetDistrictEvents(districtKey, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DistrictApi.GetDistrictEvents: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://www.thebluealliance.com/api/v3*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DistrictApi* | [**GetDistrictEvents**](docs/DistrictApi.md#getdistrictevents) | **GET** /district/{district_key}/events | 
*DistrictApi* | [**GetDistrictEventsKeys**](docs/DistrictApi.md#getdistricteventskeys) | **GET** /district/{district_key}/events/keys | 
*DistrictApi* | [**GetDistrictEventsSimple**](docs/DistrictApi.md#getdistricteventssimple) | **GET** /district/{district_key}/events/simple | 
*DistrictApi* | [**GetDistrictRankings**](docs/DistrictApi.md#getdistrictrankings) | **GET** /district/{district_key}/rankings | 
*DistrictApi* | [**GetDistrictTeams**](docs/DistrictApi.md#getdistrictteams) | **GET** /district/{district_key}/teams | 
*DistrictApi* | [**GetDistrictTeamsKeys**](docs/DistrictApi.md#getdistrictteamskeys) | **GET** /district/{district_key}/teams/keys | 
*DistrictApi* | [**GetDistrictTeamsSimple**](docs/DistrictApi.md#getdistrictteamssimple) | **GET** /district/{district_key}/teams/simple | 
*DistrictApi* | [**GetDistrictsByYear**](docs/DistrictApi.md#getdistrictsbyyear) | **GET** /districts/{year} | 
*DistrictApi* | [**GetEventDistrictPoints**](docs/DistrictApi.md#geteventdistrictpoints) | **GET** /event/{event_key}/district_points | 
*DistrictApi* | [**GetTeamDistricts**](docs/DistrictApi.md#getteamdistricts) | **GET** /team/{team_key}/districts | 
*EventApi* | [**GetDistrictEvents**](docs/EventApi.md#getdistrictevents) | **GET** /district/{district_key}/events | 
*EventApi* | [**GetDistrictEventsKeys**](docs/EventApi.md#getdistricteventskeys) | **GET** /district/{district_key}/events/keys | 
*EventApi* | [**GetDistrictEventsSimple**](docs/EventApi.md#getdistricteventssimple) | **GET** /district/{district_key}/events/simple | 
*EventApi* | [**GetEvent**](docs/EventApi.md#getevent) | **GET** /event/{event_key} | 
*EventApi* | [**GetEventAlliances**](docs/EventApi.md#geteventalliances) | **GET** /event/{event_key}/alliances | 
*EventApi* | [**GetEventAwards**](docs/EventApi.md#geteventawards) | **GET** /event/{event_key}/awards | 
*EventApi* | [**GetEventDistrictPoints**](docs/EventApi.md#geteventdistrictpoints) | **GET** /event/{event_key}/district_points | 
*EventApi* | [**GetEventInsights**](docs/EventApi.md#geteventinsights) | **GET** /event/{event_key}/insights | 
*EventApi* | [**GetEventMatchTimeseries**](docs/EventApi.md#geteventmatchtimeseries) | **GET** /event/{event_key}/matches/timeseries | 
*EventApi* | [**GetEventMatches**](docs/EventApi.md#geteventmatches) | **GET** /event/{event_key}/matches | 
*EventApi* | [**GetEventMatchesKeys**](docs/EventApi.md#geteventmatcheskeys) | **GET** /event/{event_key}/matches/keys | 
*EventApi* | [**GetEventMatchesSimple**](docs/EventApi.md#geteventmatchessimple) | **GET** /event/{event_key}/matches/simple | 
*EventApi* | [**GetEventOPRs**](docs/EventApi.md#geteventoprs) | **GET** /event/{event_key}/oprs | 
*EventApi* | [**GetEventPredictions**](docs/EventApi.md#geteventpredictions) | **GET** /event/{event_key}/predictions | 
*EventApi* | [**GetEventRankings**](docs/EventApi.md#geteventrankings) | **GET** /event/{event_key}/rankings | 
*EventApi* | [**GetEventSimple**](docs/EventApi.md#geteventsimple) | **GET** /event/{event_key}/simple | 
*EventApi* | [**GetEventTeams**](docs/EventApi.md#geteventteams) | **GET** /event/{event_key}/teams | 
*EventApi* | [**GetEventTeamsKeys**](docs/EventApi.md#geteventteamskeys) | **GET** /event/{event_key}/teams/keys | 
*EventApi* | [**GetEventTeamsSimple**](docs/EventApi.md#geteventteamssimple) | **GET** /event/{event_key}/teams/simple | 
*EventApi* | [**GetEventTeamsStatuses**](docs/EventApi.md#geteventteamsstatuses) | **GET** /event/{event_key}/teams/statuses | 
*EventApi* | [**GetEventsByYear**](docs/EventApi.md#geteventsbyyear) | **GET** /events/{year} | 
*EventApi* | [**GetEventsByYearKeys**](docs/EventApi.md#geteventsbyyearkeys) | **GET** /events/{year}/keys | 
*EventApi* | [**GetEventsByYearSimple**](docs/EventApi.md#geteventsbyyearsimple) | **GET** /events/{year}/simple | 
*EventApi* | [**GetTeamEventAwards**](docs/EventApi.md#getteameventawards) | **GET** /team/{team_key}/event/{event_key}/awards | 
*EventApi* | [**GetTeamEventMatches**](docs/EventApi.md#getteameventmatches) | **GET** /team/{team_key}/event/{event_key}/matches | 
*EventApi* | [**GetTeamEventMatchesKeys**](docs/EventApi.md#getteameventmatcheskeys) | **GET** /team/{team_key}/event/{event_key}/matches/keys | 
*EventApi* | [**GetTeamEventMatchesSimple**](docs/EventApi.md#getteameventmatchessimple) | **GET** /team/{team_key}/event/{event_key}/matches/simple | 
*EventApi* | [**GetTeamEventStatus**](docs/EventApi.md#getteameventstatus) | **GET** /team/{team_key}/event/{event_key}/status | 
*EventApi* | [**GetTeamEvents**](docs/EventApi.md#getteamevents) | **GET** /team/{team_key}/events | 
*EventApi* | [**GetTeamEventsByYear**](docs/EventApi.md#getteameventsbyyear) | **GET** /team/{team_key}/events/{year} | 
*EventApi* | [**GetTeamEventsByYearKeys**](docs/EventApi.md#getteameventsbyyearkeys) | **GET** /team/{team_key}/events/{year}/keys | 
*EventApi* | [**GetTeamEventsByYearSimple**](docs/EventApi.md#getteameventsbyyearsimple) | **GET** /team/{team_key}/events/{year}/simple | 
*EventApi* | [**GetTeamEventsKeys**](docs/EventApi.md#getteameventskeys) | **GET** /team/{team_key}/events/keys | 
*EventApi* | [**GetTeamEventsSimple**](docs/EventApi.md#getteameventssimple) | **GET** /team/{team_key}/events/simple | 
*EventApi* | [**GetTeamEventsStatusesByYear**](docs/EventApi.md#getteameventsstatusesbyyear) | **GET** /team/{team_key}/events/{year}/statuses | 
*ListApi* | [**GetDistrictEvents**](docs/ListApi.md#getdistrictevents) | **GET** /district/{district_key}/events | 
*ListApi* | [**GetDistrictEventsKeys**](docs/ListApi.md#getdistricteventskeys) | **GET** /district/{district_key}/events/keys | 
*ListApi* | [**GetDistrictEventsSimple**](docs/ListApi.md#getdistricteventssimple) | **GET** /district/{district_key}/events/simple | 
*ListApi* | [**GetDistrictRankings**](docs/ListApi.md#getdistrictrankings) | **GET** /district/{district_key}/rankings | 
*ListApi* | [**GetDistrictTeams**](docs/ListApi.md#getdistrictteams) | **GET** /district/{district_key}/teams | 
*ListApi* | [**GetDistrictTeamsKeys**](docs/ListApi.md#getdistrictteamskeys) | **GET** /district/{district_key}/teams/keys | 
*ListApi* | [**GetDistrictTeamsSimple**](docs/ListApi.md#getdistrictteamssimple) | **GET** /district/{district_key}/teams/simple | 
*ListApi* | [**GetEventTeams**](docs/ListApi.md#geteventteams) | **GET** /event/{event_key}/teams | 
*ListApi* | [**GetEventTeamsKeys**](docs/ListApi.md#geteventteamskeys) | **GET** /event/{event_key}/teams/keys | 
*ListApi* | [**GetEventTeamsSimple**](docs/ListApi.md#geteventteamssimple) | **GET** /event/{event_key}/teams/simple | 
*ListApi* | [**GetEventTeamsStatuses**](docs/ListApi.md#geteventteamsstatuses) | **GET** /event/{event_key}/teams/statuses | 
*ListApi* | [**GetEventsByYear**](docs/ListApi.md#geteventsbyyear) | **GET** /events/{year} | 
*ListApi* | [**GetEventsByYearKeys**](docs/ListApi.md#geteventsbyyearkeys) | **GET** /events/{year}/keys | 
*ListApi* | [**GetEventsByYearSimple**](docs/ListApi.md#geteventsbyyearsimple) | **GET** /events/{year}/simple | 
*ListApi* | [**GetTeamEventsStatusesByYear**](docs/ListApi.md#getteameventsstatusesbyyear) | **GET** /team/{team_key}/events/{year}/statuses | 
*ListApi* | [**GetTeams**](docs/ListApi.md#getteams) | **GET** /teams/{page_num} | 
*ListApi* | [**GetTeamsByYear**](docs/ListApi.md#getteamsbyyear) | **GET** /teams/{year}/{page_num} | 
*ListApi* | [**GetTeamsByYearKeys**](docs/ListApi.md#getteamsbyyearkeys) | **GET** /teams/{year}/{page_num}/keys | 
*ListApi* | [**GetTeamsByYearSimple**](docs/ListApi.md#getteamsbyyearsimple) | **GET** /teams/{year}/{page_num}/simple | 
*ListApi* | [**GetTeamsKeys**](docs/ListApi.md#getteamskeys) | **GET** /teams/{page_num}/keys | 
*ListApi* | [**GetTeamsSimple**](docs/ListApi.md#getteamssimple) | **GET** /teams/{page_num}/simple | 
*MatchApi* | [**GetEventMatchTimeseries**](docs/MatchApi.md#geteventmatchtimeseries) | **GET** /event/{event_key}/matches/timeseries | 
*MatchApi* | [**GetEventMatches**](docs/MatchApi.md#geteventmatches) | **GET** /event/{event_key}/matches | 
*MatchApi* | [**GetEventMatchesKeys**](docs/MatchApi.md#geteventmatcheskeys) | **GET** /event/{event_key}/matches/keys | 
*MatchApi* | [**GetEventMatchesSimple**](docs/MatchApi.md#geteventmatchessimple) | **GET** /event/{event_key}/matches/simple | 
*MatchApi* | [**GetMatch**](docs/MatchApi.md#getmatch) | **GET** /match/{match_key} | 
*MatchApi* | [**GetMatchSimple**](docs/MatchApi.md#getmatchsimple) | **GET** /match/{match_key}/simple | 
*MatchApi* | [**GetMatchTimeseries**](docs/MatchApi.md#getmatchtimeseries) | **GET** /match/{match_key}/timeseries | 
*MatchApi* | [**GetMatchZebra**](docs/MatchApi.md#getmatchzebra) | **GET** /match/{match_key}/zebra_motionworks | 
*MatchApi* | [**GetTeamEventMatches**](docs/MatchApi.md#getteameventmatches) | **GET** /team/{team_key}/event/{event_key}/matches | 
*MatchApi* | [**GetTeamEventMatchesKeys**](docs/MatchApi.md#getteameventmatcheskeys) | **GET** /team/{team_key}/event/{event_key}/matches/keys | 
*MatchApi* | [**GetTeamEventMatchesSimple**](docs/MatchApi.md#getteameventmatchessimple) | **GET** /team/{team_key}/event/{event_key}/matches/simple | 
*MatchApi* | [**GetTeamMatchesByYear**](docs/MatchApi.md#getteammatchesbyyear) | **GET** /team/{team_key}/matches/{year} | 
*MatchApi* | [**GetTeamMatchesByYearKeys**](docs/MatchApi.md#getteammatchesbyyearkeys) | **GET** /team/{team_key}/matches/{year}/keys | 
*MatchApi* | [**GetTeamMatchesByYearSimple**](docs/MatchApi.md#getteammatchesbyyearsimple) | **GET** /team/{team_key}/matches/{year}/simple | 
*TBAApi* | [**GetStatus**](docs/TBAApi.md#getstatus) | **GET** /status | 
*TeamApi* | [**GetDistrictRankings**](docs/TeamApi.md#getdistrictrankings) | **GET** /district/{district_key}/rankings | 
*TeamApi* | [**GetDistrictTeams**](docs/TeamApi.md#getdistrictteams) | **GET** /district/{district_key}/teams | 
*TeamApi* | [**GetDistrictTeamsKeys**](docs/TeamApi.md#getdistrictteamskeys) | **GET** /district/{district_key}/teams/keys | 
*TeamApi* | [**GetDistrictTeamsSimple**](docs/TeamApi.md#getdistrictteamssimple) | **GET** /district/{district_key}/teams/simple | 
*TeamApi* | [**GetEventTeams**](docs/TeamApi.md#geteventteams) | **GET** /event/{event_key}/teams | 
*TeamApi* | [**GetEventTeamsKeys**](docs/TeamApi.md#geteventteamskeys) | **GET** /event/{event_key}/teams/keys | 
*TeamApi* | [**GetEventTeamsSimple**](docs/TeamApi.md#geteventteamssimple) | **GET** /event/{event_key}/teams/simple | 
*TeamApi* | [**GetEventTeamsStatuses**](docs/TeamApi.md#geteventteamsstatuses) | **GET** /event/{event_key}/teams/statuses | 
*TeamApi* | [**GetTeam**](docs/TeamApi.md#getteam) | **GET** /team/{team_key} | 
*TeamApi* | [**GetTeamAwards**](docs/TeamApi.md#getteamawards) | **GET** /team/{team_key}/awards | 
*TeamApi* | [**GetTeamAwardsByYear**](docs/TeamApi.md#getteamawardsbyyear) | **GET** /team/{team_key}/awards/{year} | 
*TeamApi* | [**GetTeamDistricts**](docs/TeamApi.md#getteamdistricts) | **GET** /team/{team_key}/districts | 
*TeamApi* | [**GetTeamEventAwards**](docs/TeamApi.md#getteameventawards) | **GET** /team/{team_key}/event/{event_key}/awards | 
*TeamApi* | [**GetTeamEventMatches**](docs/TeamApi.md#getteameventmatches) | **GET** /team/{team_key}/event/{event_key}/matches | 
*TeamApi* | [**GetTeamEventMatchesKeys**](docs/TeamApi.md#getteameventmatcheskeys) | **GET** /team/{team_key}/event/{event_key}/matches/keys | 
*TeamApi* | [**GetTeamEventMatchesSimple**](docs/TeamApi.md#getteameventmatchessimple) | **GET** /team/{team_key}/event/{event_key}/matches/simple | 
*TeamApi* | [**GetTeamEventStatus**](docs/TeamApi.md#getteameventstatus) | **GET** /team/{team_key}/event/{event_key}/status | 
*TeamApi* | [**GetTeamEvents**](docs/TeamApi.md#getteamevents) | **GET** /team/{team_key}/events | 
*TeamApi* | [**GetTeamEventsByYear**](docs/TeamApi.md#getteameventsbyyear) | **GET** /team/{team_key}/events/{year} | 
*TeamApi* | [**GetTeamEventsByYearKeys**](docs/TeamApi.md#getteameventsbyyearkeys) | **GET** /team/{team_key}/events/{year}/keys | 
*TeamApi* | [**GetTeamEventsByYearSimple**](docs/TeamApi.md#getteameventsbyyearsimple) | **GET** /team/{team_key}/events/{year}/simple | 
*TeamApi* | [**GetTeamEventsKeys**](docs/TeamApi.md#getteameventskeys) | **GET** /team/{team_key}/events/keys | 
*TeamApi* | [**GetTeamEventsSimple**](docs/TeamApi.md#getteameventssimple) | **GET** /team/{team_key}/events/simple | 
*TeamApi* | [**GetTeamEventsStatusesByYear**](docs/TeamApi.md#getteameventsstatusesbyyear) | **GET** /team/{team_key}/events/{year}/statuses | 
*TeamApi* | [**GetTeamMatchesByYear**](docs/TeamApi.md#getteammatchesbyyear) | **GET** /team/{team_key}/matches/{year} | 
*TeamApi* | [**GetTeamMatchesByYearKeys**](docs/TeamApi.md#getteammatchesbyyearkeys) | **GET** /team/{team_key}/matches/{year}/keys | 
*TeamApi* | [**GetTeamMatchesByYearSimple**](docs/TeamApi.md#getteammatchesbyyearsimple) | **GET** /team/{team_key}/matches/{year}/simple | 
*TeamApi* | [**GetTeamMediaByTag**](docs/TeamApi.md#getteammediabytag) | **GET** /team/{team_key}/media/tag/{media_tag} | 
*TeamApi* | [**GetTeamMediaByTagYear**](docs/TeamApi.md#getteammediabytagyear) | **GET** /team/{team_key}/media/tag/{media_tag}/{year} | 
*TeamApi* | [**GetTeamMediaByYear**](docs/TeamApi.md#getteammediabyyear) | **GET** /team/{team_key}/media/{year} | 
*TeamApi* | [**GetTeamRobots**](docs/TeamApi.md#getteamrobots) | **GET** /team/{team_key}/robots | 
*TeamApi* | [**GetTeamSimple**](docs/TeamApi.md#getteamsimple) | **GET** /team/{team_key}/simple | 
*TeamApi* | [**GetTeamSocialMedia**](docs/TeamApi.md#getteamsocialmedia) | **GET** /team/{team_key}/social_media | 
*TeamApi* | [**GetTeamYearsParticipated**](docs/TeamApi.md#getteamyearsparticipated) | **GET** /team/{team_key}/years_participated | 
*TeamApi* | [**GetTeams**](docs/TeamApi.md#getteams) | **GET** /teams/{page_num} | 
*TeamApi* | [**GetTeamsByYear**](docs/TeamApi.md#getteamsbyyear) | **GET** /teams/{year}/{page_num} | 
*TeamApi* | [**GetTeamsByYearKeys**](docs/TeamApi.md#getteamsbyyearkeys) | **GET** /teams/{year}/{page_num}/keys | 
*TeamApi* | [**GetTeamsByYearSimple**](docs/TeamApi.md#getteamsbyyearsimple) | **GET** /teams/{year}/{page_num}/simple | 
*TeamApi* | [**GetTeamsKeys**](docs/TeamApi.md#getteamskeys) | **GET** /teams/{page_num}/keys | 
*TeamApi* | [**GetTeamsSimple**](docs/TeamApi.md#getteamssimple) | **GET** /teams/{page_num}/simple | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.APIStatus](docs/APIStatus.md)
 - [Model.APIStatusAppVersion](docs/APIStatusAppVersion.md)
 - [Model.Award](docs/Award.md)
 - [Model.AwardRecipient](docs/AwardRecipient.md)
 - [Model.DistrictList](docs/DistrictList.md)
 - [Model.DistrictRanking](docs/DistrictRanking.md)
 - [Model.DistrictRankingEventPoints](docs/DistrictRankingEventPoints.md)
 - [Model.EliminationAlliance](docs/EliminationAlliance.md)
 - [Model.EliminationAllianceBackup](docs/EliminationAllianceBackup.md)
 - [Model.EliminationAllianceStatus](docs/EliminationAllianceStatus.md)
 - [Model.Event](docs/Event.md)
 - [Model.EventDistrictPoints](docs/EventDistrictPoints.md)
 - [Model.EventDistrictPointsPoints](docs/EventDistrictPointsPoints.md)
 - [Model.EventDistrictPointsTiebreakers](docs/EventDistrictPointsTiebreakers.md)
 - [Model.EventInsights](docs/EventInsights.md)
 - [Model.EventInsights2016](docs/EventInsights2016.md)
 - [Model.EventInsights2017](docs/EventInsights2017.md)
 - [Model.EventInsights2018](docs/EventInsights2018.md)
 - [Model.EventOPRs](docs/EventOPRs.md)
 - [Model.EventRanking](docs/EventRanking.md)
 - [Model.EventRankingExtraStatsInfo](docs/EventRankingExtraStatsInfo.md)
 - [Model.EventRankingRankings](docs/EventRankingRankings.md)
 - [Model.EventRankingSortOrderInfo](docs/EventRankingSortOrderInfo.md)
 - [Model.EventSimple](docs/EventSimple.md)
 - [Model.Match](docs/Match.md)
 - [Model.MatchAlliance](docs/MatchAlliance.md)
 - [Model.MatchScoreBreakdown2015](docs/MatchScoreBreakdown2015.md)
 - [Model.MatchScoreBreakdown2015Alliance](docs/MatchScoreBreakdown2015Alliance.md)
 - [Model.MatchScoreBreakdown2016](docs/MatchScoreBreakdown2016.md)
 - [Model.MatchScoreBreakdown2016Alliance](docs/MatchScoreBreakdown2016Alliance.md)
 - [Model.MatchScoreBreakdown2017](docs/MatchScoreBreakdown2017.md)
 - [Model.MatchScoreBreakdown2017Alliance](docs/MatchScoreBreakdown2017Alliance.md)
 - [Model.MatchScoreBreakdown2018](docs/MatchScoreBreakdown2018.md)
 - [Model.MatchScoreBreakdown2018Alliance](docs/MatchScoreBreakdown2018Alliance.md)
 - [Model.MatchScoreBreakdown2019](docs/MatchScoreBreakdown2019.md)
 - [Model.MatchScoreBreakdown2019Alliance](docs/MatchScoreBreakdown2019Alliance.md)
 - [Model.MatchScoreBreakdown2020](docs/MatchScoreBreakdown2020.md)
 - [Model.MatchScoreBreakdown2020Alliance](docs/MatchScoreBreakdown2020Alliance.md)
 - [Model.MatchSimple](docs/MatchSimple.md)
 - [Model.MatchSimpleAlliances](docs/MatchSimpleAlliances.md)
 - [Model.MatchTimeseries2018](docs/MatchTimeseries2018.md)
 - [Model.MatchVideos](docs/MatchVideos.md)
 - [Model.Media](docs/Media.md)
 - [Model.Team](docs/Team.md)
 - [Model.TeamEventStatus](docs/TeamEventStatus.md)
 - [Model.TeamEventStatusAlliance](docs/TeamEventStatusAlliance.md)
 - [Model.TeamEventStatusAllianceBackup](docs/TeamEventStatusAllianceBackup.md)
 - [Model.TeamEventStatusPlayoff](docs/TeamEventStatusPlayoff.md)
 - [Model.TeamEventStatusRank](docs/TeamEventStatusRank.md)
 - [Model.TeamEventStatusRankRanking](docs/TeamEventStatusRankRanking.md)
 - [Model.TeamEventStatusRankSortOrderInfo](docs/TeamEventStatusRankSortOrderInfo.md)
 - [Model.TeamRobot](docs/TeamRobot.md)
 - [Model.TeamSimple](docs/TeamSimple.md)
 - [Model.WLTRecord](docs/WLTRecord.md)
 - [Model.Webcast](docs/Webcast.md)
 - [Model.Zebra](docs/Zebra.md)
 - [Model.ZebraAlliances](docs/ZebraAlliances.md)
 - [Model.ZebraTeam](docs/ZebraTeam.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="apiKey"></a>
### apiKey

- **Type**: API key
- **API key parameter name**: X-TBA-Auth-Key
- **Location**: HTTP header
