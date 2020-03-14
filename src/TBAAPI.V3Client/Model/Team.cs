/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TBAAPI.V3Client.Client.OpenAPIDateConverter;

namespace TBAAPI.V3Client.Model
{
    /// <summary>
    /// Team
    /// </summary>
    [DataContract]
    public partial class Team :  IEquatable<Team>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Team() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        /// <param name="key">TBA team key with the format &#x60;frcXXXX&#x60; with &#x60;XXXX&#x60; representing the team number. (required).</param>
        /// <param name="teamNumber">Official team number issued by FIRST. (required).</param>
        /// <param name="nickname">Team nickname provided by FIRST..</param>
        /// <param name="name">Official long name registered with FIRST. (required).</param>
        /// <param name="schoolName">Name of team school or affilited group registered with FIRST..</param>
        /// <param name="city">City of team derived from parsing the address registered with FIRST..</param>
        /// <param name="stateProv">State of team derived from parsing the address registered with FIRST..</param>
        /// <param name="country">Country of team derived from parsing the address registered with FIRST..</param>
        /// <param name="address">Will be NULL, for future development..</param>
        /// <param name="postalCode">Postal code from the team address..</param>
        /// <param name="gmapsPlaceId">Will be NULL, for future development..</param>
        /// <param name="gmapsUrl">Will be NULL, for future development..</param>
        /// <param name="lat">Will be NULL, for future development..</param>
        /// <param name="lng">Will be NULL, for future development..</param>
        /// <param name="locationName">Will be NULL, for future development..</param>
        /// <param name="website">Official website associated with the team..</param>
        /// <param name="rookieYear">First year the team officially competed..</param>
        /// <param name="motto">Team&#39;s motto as provided by FIRST. This field is deprecated and will return null - will be removed at end-of-season in 2019..</param>
        /// <param name="homeChampionship">Location of the team&#39;s home championship each year as a key-value pair. The year (as a string) is the key, and the city is the value..</param>
        public Team(string key = default(string), int teamNumber = default(int), string nickname = default(string), string name = default(string), string schoolName = default(string), string city = default(string), string stateProv = default(string), string country = default(string), string address = default(string), string postalCode = default(string), string gmapsPlaceId = default(string), string gmapsUrl = default(string), double lat = default(double), double lng = default(double), string locationName = default(string), string website = default(string), int rookieYear = default(int), string motto = default(string), Object homeChampionship = default(Object))
        {
            // to ensure "key" is required (not null)
            this.Key = key ?? throw new ArgumentNullException("key is a required property for Team and cannot be null");;
            this.TeamNumber = teamNumber;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for Team and cannot be null");;
            this.Nickname = nickname;
            this.SchoolName = schoolName;
            this.City = city;
            this.StateProv = stateProv;
            this.Country = country;
            this.Address = address;
            this.PostalCode = postalCode;
            this.GmapsPlaceId = gmapsPlaceId;
            this.GmapsUrl = gmapsUrl;
            this.Lat = lat;
            this.Lng = lng;
            this.LocationName = locationName;
            this.Website = website;
            this.RookieYear = rookieYear;
            this.Motto = motto;
            this.HomeChampionship = homeChampionship;
        }
        
        /// <summary>
        /// TBA team key with the format &#x60;frcXXXX&#x60; with &#x60;XXXX&#x60; representing the team number.
        /// </summary>
        /// <value>TBA team key with the format &#x60;frcXXXX&#x60; with &#x60;XXXX&#x60; representing the team number.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Official team number issued by FIRST.
        /// </summary>
        /// <value>Official team number issued by FIRST.</value>
        [DataMember(Name="team_number", EmitDefaultValue=false)]
        public int TeamNumber { get; set; }

        /// <summary>
        /// Team nickname provided by FIRST.
        /// </summary>
        /// <value>Team nickname provided by FIRST.</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Official long name registered with FIRST.
        /// </summary>
        /// <value>Official long name registered with FIRST.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Name of team school or affilited group registered with FIRST.
        /// </summary>
        /// <value>Name of team school or affilited group registered with FIRST.</value>
        [DataMember(Name="school_name", EmitDefaultValue=false)]
        public string SchoolName { get; set; }

        /// <summary>
        /// City of team derived from parsing the address registered with FIRST.
        /// </summary>
        /// <value>City of team derived from parsing the address registered with FIRST.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// State of team derived from parsing the address registered with FIRST.
        /// </summary>
        /// <value>State of team derived from parsing the address registered with FIRST.</value>
        [DataMember(Name="state_prov", EmitDefaultValue=false)]
        public string StateProv { get; set; }

        /// <summary>
        /// Country of team derived from parsing the address registered with FIRST.
        /// </summary>
        /// <value>Country of team derived from parsing the address registered with FIRST.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Will be NULL, for future development.
        /// </summary>
        /// <value>Will be NULL, for future development.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Postal code from the team address.
        /// </summary>
        /// <value>Postal code from the team address.</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Will be NULL, for future development.
        /// </summary>
        /// <value>Will be NULL, for future development.</value>
        [DataMember(Name="gmaps_place_id", EmitDefaultValue=false)]
        public string GmapsPlaceId { get; set; }

        /// <summary>
        /// Will be NULL, for future development.
        /// </summary>
        /// <value>Will be NULL, for future development.</value>
        [DataMember(Name="gmaps_url", EmitDefaultValue=false)]
        public string GmapsUrl { get; set; }

        /// <summary>
        /// Will be NULL, for future development.
        /// </summary>
        /// <value>Will be NULL, for future development.</value>
        [DataMember(Name="lat", EmitDefaultValue=false)]
        public double Lat { get; set; }

        /// <summary>
        /// Will be NULL, for future development.
        /// </summary>
        /// <value>Will be NULL, for future development.</value>
        [DataMember(Name="lng", EmitDefaultValue=false)]
        public double Lng { get; set; }

        /// <summary>
        /// Will be NULL, for future development.
        /// </summary>
        /// <value>Will be NULL, for future development.</value>
        [DataMember(Name="location_name", EmitDefaultValue=false)]
        public string LocationName { get; set; }

        /// <summary>
        /// Official website associated with the team.
        /// </summary>
        /// <value>Official website associated with the team.</value>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }

        /// <summary>
        /// First year the team officially competed.
        /// </summary>
        /// <value>First year the team officially competed.</value>
        [DataMember(Name="rookie_year", EmitDefaultValue=false)]
        public int RookieYear { get; set; }

        /// <summary>
        /// Team&#39;s motto as provided by FIRST. This field is deprecated and will return null - will be removed at end-of-season in 2019.
        /// </summary>
        /// <value>Team&#39;s motto as provided by FIRST. This field is deprecated and will return null - will be removed at end-of-season in 2019.</value>
        [DataMember(Name="motto", EmitDefaultValue=false)]
        public string Motto { get; set; }

        /// <summary>
        /// Location of the team&#39;s home championship each year as a key-value pair. The year (as a string) is the key, and the city is the value.
        /// </summary>
        /// <value>Location of the team&#39;s home championship each year as a key-value pair. The year (as a string) is the key, and the city is the value.</value>
        [DataMember(Name="home_championship", EmitDefaultValue=false)]
        public Object HomeChampionship { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Team {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  TeamNumber: ").Append(TeamNumber).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SchoolName: ").Append(SchoolName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateProv: ").Append(StateProv).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  GmapsPlaceId: ").Append(GmapsPlaceId).Append("\n");
            sb.Append("  GmapsUrl: ").Append(GmapsUrl).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  RookieYear: ").Append(RookieYear).Append("\n");
            sb.Append("  Motto: ").Append(Motto).Append("\n");
            sb.Append("  HomeChampionship: ").Append(HomeChampionship).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Team);
        }

        /// <summary>
        /// Returns true if Team instances are equal
        /// </summary>
        /// <param name="input">Instance of Team to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Team input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.TeamNumber == input.TeamNumber ||
                    this.TeamNumber.Equals(input.TeamNumber)
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SchoolName == input.SchoolName ||
                    (this.SchoolName != null &&
                    this.SchoolName.Equals(input.SchoolName))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.StateProv == input.StateProv ||
                    (this.StateProv != null &&
                    this.StateProv.Equals(input.StateProv))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.GmapsPlaceId == input.GmapsPlaceId ||
                    (this.GmapsPlaceId != null &&
                    this.GmapsPlaceId.Equals(input.GmapsPlaceId))
                ) && 
                (
                    this.GmapsUrl == input.GmapsUrl ||
                    (this.GmapsUrl != null &&
                    this.GmapsUrl.Equals(input.GmapsUrl))
                ) && 
                (
                    this.Lat == input.Lat ||
                    this.Lat.Equals(input.Lat)
                ) && 
                (
                    this.Lng == input.Lng ||
                    this.Lng.Equals(input.Lng)
                ) && 
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.RookieYear == input.RookieYear ||
                    this.RookieYear.Equals(input.RookieYear)
                ) && 
                (
                    this.Motto == input.Motto ||
                    (this.Motto != null &&
                    this.Motto.Equals(input.Motto))
                ) && 
                (
                    this.HomeChampionship == input.HomeChampionship ||
                    (this.HomeChampionship != null &&
                    this.HomeChampionship.Equals(input.HomeChampionship))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                hashCode = hashCode * 59 + this.TeamNumber.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SchoolName != null)
                    hashCode = hashCode * 59 + this.SchoolName.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateProv != null)
                    hashCode = hashCode * 59 + this.StateProv.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.GmapsPlaceId != null)
                    hashCode = hashCode * 59 + this.GmapsPlaceId.GetHashCode();
                if (this.GmapsUrl != null)
                    hashCode = hashCode * 59 + this.GmapsUrl.GetHashCode();
                hashCode = hashCode * 59 + this.Lat.GetHashCode();
                hashCode = hashCode * 59 + this.Lng.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.Website != null)
                    hashCode = hashCode * 59 + this.Website.GetHashCode();
                hashCode = hashCode * 59 + this.RookieYear.GetHashCode();
                if (this.Motto != null)
                    hashCode = hashCode * 59 + this.Motto.GetHashCode();
                if (this.HomeChampionship != null)
                    hashCode = hashCode * 59 + this.HomeChampionship.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
