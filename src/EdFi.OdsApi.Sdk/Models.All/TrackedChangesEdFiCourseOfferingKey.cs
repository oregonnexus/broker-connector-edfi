/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// TrackedChangesEdFiCourseOfferingKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_courseOfferingKey")]
    public partial class TrackedChangesEdFiCourseOfferingKey : IEquatable<TrackedChangesEdFiCourseOfferingKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiCourseOfferingKey" /> class.
        /// </summary>
        /// <param name="localCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students..</param>
        /// <param name="schoolId">The identifier assigned to a school..</param>
        /// <param name="schoolYear">The identifier for the school year..</param>
        /// <param name="sessionName">The identifier for the calendar for the academic session..</param>
        public TrackedChangesEdFiCourseOfferingKey(string localCourseCode = default(string), long schoolId = default(long), int schoolYear = default(int), string sessionName = default(string))
        {
            this.LocalCourseCode = localCourseCode;
            this.SchoolId = schoolId;
            this.SchoolYear = schoolYear;
            this.SessionName = sessionName;
        }

        /// <summary>
        /// The local code assigned by the School that identifies the course offering provided for the instruction of students.
        /// </summary>
        /// <value>The local code assigned by the School that identifies the course offering provided for the instruction of students.</value>
        [DataMember(Name = "localCourseCode", EmitDefaultValue = false)]
        public string LocalCourseCode { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name = "schoolId", EmitDefaultValue = false)]
        public long SchoolId { get; set; }

        /// <summary>
        /// The identifier for the school year.
        /// </summary>
        /// <value>The identifier for the school year.</value>
        [DataMember(Name = "schoolYear", EmitDefaultValue = false)]
        public int SchoolYear { get; set; }

        /// <summary>
        /// The identifier for the calendar for the academic session.
        /// </summary>
        /// <value>The identifier for the calendar for the academic session.</value>
        [DataMember(Name = "sessionName", EmitDefaultValue = false)]
        public string SessionName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiCourseOfferingKey {\n");
            sb.Append("  LocalCourseCode: ").Append(LocalCourseCode).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrackedChangesEdFiCourseOfferingKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiCourseOfferingKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiCourseOfferingKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiCourseOfferingKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LocalCourseCode == input.LocalCourseCode ||
                    (this.LocalCourseCode != null &&
                    this.LocalCourseCode.Equals(input.LocalCourseCode))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    this.SchoolId.Equals(input.SchoolId)
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    this.SchoolYear.Equals(input.SchoolYear)
                ) && 
                (
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
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
                if (this.LocalCourseCode != null)
                {
                    hashCode = (hashCode * 59) + this.LocalCourseCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchoolId.GetHashCode();
                hashCode = (hashCode * 59) + this.SchoolYear.GetHashCode();
                if (this.SessionName != null)
                {
                    hashCode = (hashCode * 59) + this.SessionName.GetHashCode();
                }
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
            // LocalCourseCode (string) maxLength
            if (this.LocalCourseCode != null && this.LocalCourseCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalCourseCode, length must be less than 60.", new [] { "LocalCourseCode" });
            }

            // LocalCourseCode (string) minLength
            if (this.LocalCourseCode != null && this.LocalCourseCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalCourseCode, length must be greater than 1.", new [] { "LocalCourseCode" });
            }

            // SessionName (string) maxLength
            if (this.SessionName != null && this.SessionName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SessionName, length must be less than 60.", new [] { "SessionName" });
            }

            // SessionName (string) minLength
            if (this.SessionName != null && this.SessionName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SessionName, length must be greater than 1.", new [] { "SessionName" });
            }

            yield break;
        }
    }

}
