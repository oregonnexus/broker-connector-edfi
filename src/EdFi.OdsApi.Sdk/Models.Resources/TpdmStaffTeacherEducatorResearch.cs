/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Resources
{
    /// <summary>
    /// TpdmStaffTeacherEducatorResearch
    /// </summary>
    [DataContract]
    public partial class TpdmStaffTeacherEducatorResearch :  IEquatable<TpdmStaffTeacherEducatorResearch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmStaffTeacherEducatorResearch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmStaffTeacherEducatorResearch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmStaffTeacherEducatorResearch" /> class.
        /// </summary>
        /// <param name="researchExperienceDate">Month, day, and year of the start or effective date of a staff member&#39;s teacher educator position for an Education Organization. (required).</param>
        /// <param name="researchExperienceDescription">The description of the research experience..</param>
        /// <param name="researchExperienceTitle">The title of the research experience..</param>
        public TpdmStaffTeacherEducatorResearch(DateTime? researchExperienceDate = default(DateTime?), string researchExperienceDescription = default(string), string researchExperienceTitle = default(string))
        {
            // to ensure "researchExperienceDate" is required (not null)
            if (researchExperienceDate == null)
            {
                throw new InvalidDataException("researchExperienceDate is a required property for TpdmStaffTeacherEducatorResearch and cannot be null");
            }
            else
            {
                this.ResearchExperienceDate = researchExperienceDate;
            }
            this.ResearchExperienceDescription = researchExperienceDescription;
            this.ResearchExperienceTitle = researchExperienceTitle;
        }
        
        /// <summary>
        /// Month, day, and year of the start or effective date of a staff member&#39;s teacher educator position for an Education Organization.
        /// </summary>
        /// <value>Month, day, and year of the start or effective date of a staff member&#39;s teacher educator position for an Education Organization.</value>
        [DataMember(Name="researchExperienceDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ResearchExperienceDate { get; set; }

        /// <summary>
        /// The description of the research experience.
        /// </summary>
        /// <value>The description of the research experience.</value>
        [DataMember(Name="researchExperienceDescription", EmitDefaultValue=false)]
        public string ResearchExperienceDescription { get; set; }

        /// <summary>
        /// The title of the research experience.
        /// </summary>
        /// <value>The title of the research experience.</value>
        [DataMember(Name="researchExperienceTitle", EmitDefaultValue=false)]
        public string ResearchExperienceTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmStaffTeacherEducatorResearch {\n");
            sb.Append("  ResearchExperienceDate: ").Append(ResearchExperienceDate).Append("\n");
            sb.Append("  ResearchExperienceDescription: ").Append(ResearchExperienceDescription).Append("\n");
            sb.Append("  ResearchExperienceTitle: ").Append(ResearchExperienceTitle).Append("\n");
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
            return this.Equals(input as TpdmStaffTeacherEducatorResearch);
        }

        /// <summary>
        /// Returns true if TpdmStaffTeacherEducatorResearch instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmStaffTeacherEducatorResearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmStaffTeacherEducatorResearch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResearchExperienceDate == input.ResearchExperienceDate ||
                    (this.ResearchExperienceDate != null &&
                    this.ResearchExperienceDate.Equals(input.ResearchExperienceDate))
                ) && 
                (
                    this.ResearchExperienceDescription == input.ResearchExperienceDescription ||
                    (this.ResearchExperienceDescription != null &&
                    this.ResearchExperienceDescription.Equals(input.ResearchExperienceDescription))
                ) && 
                (
                    this.ResearchExperienceTitle == input.ResearchExperienceTitle ||
                    (this.ResearchExperienceTitle != null &&
                    this.ResearchExperienceTitle.Equals(input.ResearchExperienceTitle))
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
                if (this.ResearchExperienceDate != null)
                    hashCode = hashCode * 59 + this.ResearchExperienceDate.GetHashCode();
                if (this.ResearchExperienceDescription != null)
                    hashCode = hashCode * 59 + this.ResearchExperienceDescription.GetHashCode();
                if (this.ResearchExperienceTitle != null)
                    hashCode = hashCode * 59 + this.ResearchExperienceTitle.GetHashCode();
                return hashCode;
            }
        }
    }

}
