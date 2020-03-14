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
    /// TeamEventStatusRank
    /// </summary>
    [DataContract]
    public partial class TeamEventStatusRank :  IEquatable<TeamEventStatusRank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamEventStatusRank" /> class.
        /// </summary>
        /// <param name="numTeams">Number of teams ranked..</param>
        /// <param name="ranking">ranking.</param>
        /// <param name="sortOrderInfo">Ordered list of names corresponding to the elements of the &#x60;sort_orders&#x60; array..</param>
        /// <param name="status">status.</param>
        public TeamEventStatusRank(int numTeams = default(int), TeamEventStatusRankRanking ranking = default(TeamEventStatusRankRanking), List<TeamEventStatusRankSortOrderInfo> sortOrderInfo = default(List<TeamEventStatusRankSortOrderInfo>), string status = default(string))
        {
            this.NumTeams = numTeams;
            this.Ranking = ranking;
            this.SortOrderInfo = sortOrderInfo;
            this.Status = status;
        }
        
        /// <summary>
        /// Number of teams ranked.
        /// </summary>
        /// <value>Number of teams ranked.</value>
        [DataMember(Name="num_teams", EmitDefaultValue=false)]
        public int NumTeams { get; set; }

        /// <summary>
        /// Gets or Sets Ranking
        /// </summary>
        [DataMember(Name="ranking", EmitDefaultValue=false)]
        public TeamEventStatusRankRanking Ranking { get; set; }

        /// <summary>
        /// Ordered list of names corresponding to the elements of the &#x60;sort_orders&#x60; array.
        /// </summary>
        /// <value>Ordered list of names corresponding to the elements of the &#x60;sort_orders&#x60; array.</value>
        [DataMember(Name="sort_order_info", EmitDefaultValue=false)]
        public List<TeamEventStatusRankSortOrderInfo> SortOrderInfo { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamEventStatusRank {\n");
            sb.Append("  NumTeams: ").Append(NumTeams).Append("\n");
            sb.Append("  Ranking: ").Append(Ranking).Append("\n");
            sb.Append("  SortOrderInfo: ").Append(SortOrderInfo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as TeamEventStatusRank);
        }

        /// <summary>
        /// Returns true if TeamEventStatusRank instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamEventStatusRank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamEventStatusRank input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumTeams == input.NumTeams ||
                    this.NumTeams.Equals(input.NumTeams)
                ) && 
                (
                    this.Ranking == input.Ranking ||
                    (this.Ranking != null &&
                    this.Ranking.Equals(input.Ranking))
                ) && 
                (
                    this.SortOrderInfo == input.SortOrderInfo ||
                    this.SortOrderInfo != null &&
                    input.SortOrderInfo != null &&
                    this.SortOrderInfo.SequenceEqual(input.SortOrderInfo)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                hashCode = hashCode * 59 + this.NumTeams.GetHashCode();
                if (this.Ranking != null)
                    hashCode = hashCode * 59 + this.Ranking.GetHashCode();
                if (this.SortOrderInfo != null)
                    hashCode = hashCode * 59 + this.SortOrderInfo.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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