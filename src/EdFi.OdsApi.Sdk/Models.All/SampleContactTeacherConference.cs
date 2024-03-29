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
    /// SampleContactTeacherConference
    /// </summary>
    [DataContract(Name = "sample_contactTeacherConference")]
    public partial class SampleContactTeacherConference : IEquatable<SampleContactTeacherConference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleContactTeacherConference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleContactTeacherConference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleContactTeacherConference" /> class.
        /// </summary>
        /// <param name="dayOfWeek">The day of the week the parent prefers to meet for parent-teacher conferences. (required).</param>
        /// <param name="endTime">The end time the parent prefers to meet for parent-teacher conferences. (required).</param>
        /// <param name="startTime">The start time the parent prefers to meet for parent-teacher conferences. (required).</param>
        public SampleContactTeacherConference(string dayOfWeek = default(string), string endTime = default(string), string startTime = default(string))
        {
            // to ensure "dayOfWeek" is required (not null)
            if (dayOfWeek == null)
            {
                throw new ArgumentNullException("dayOfWeek is a required property for SampleContactTeacherConference and cannot be null");
            }
            this.DayOfWeek = dayOfWeek;
            // to ensure "endTime" is required (not null)
            if (endTime == null)
            {
                throw new ArgumentNullException("endTime is a required property for SampleContactTeacherConference and cannot be null");
            }
            this.EndTime = endTime;
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new ArgumentNullException("startTime is a required property for SampleContactTeacherConference and cannot be null");
            }
            this.StartTime = startTime;
        }

        /// <summary>
        /// The day of the week the parent prefers to meet for parent-teacher conferences.
        /// </summary>
        /// <value>The day of the week the parent prefers to meet for parent-teacher conferences.</value>
        [DataMember(Name = "dayOfWeek", IsRequired = true, EmitDefaultValue = true)]
        public string DayOfWeek { get; set; }

        /// <summary>
        /// The end time the parent prefers to meet for parent-teacher conferences.
        /// </summary>
        /// <value>The end time the parent prefers to meet for parent-teacher conferences.</value>
        [DataMember(Name = "endTime", IsRequired = true, EmitDefaultValue = true)]
        public string EndTime { get; set; }

        /// <summary>
        /// The start time the parent prefers to meet for parent-teacher conferences.
        /// </summary>
        /// <value>The start time the parent prefers to meet for parent-teacher conferences.</value>
        [DataMember(Name = "startTime", IsRequired = true, EmitDefaultValue = true)]
        public string StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SampleContactTeacherConference {\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as SampleContactTeacherConference);
        }

        /// <summary>
        /// Returns true if SampleContactTeacherConference instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleContactTeacherConference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleContactTeacherConference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DayOfWeek == input.DayOfWeek ||
                    (this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(input.DayOfWeek))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.DayOfWeek != null)
                {
                    hashCode = (hashCode * 59) + this.DayOfWeek.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
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
            // DayOfWeek (string) maxLength
            if (this.DayOfWeek != null && this.DayOfWeek.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DayOfWeek, length must be less than 10.", new [] { "DayOfWeek" });
            }

            yield break;
        }
    }

}
