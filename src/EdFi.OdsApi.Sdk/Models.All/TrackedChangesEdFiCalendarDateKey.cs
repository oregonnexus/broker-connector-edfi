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
    /// TrackedChangesEdFiCalendarDateKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_calendarDateKey")]
    public partial class TrackedChangesEdFiCalendarDateKey : IEquatable<TrackedChangesEdFiCalendarDateKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiCalendarDateKey" /> class.
        /// </summary>
        /// <param name="date">The month, day, and year of the calendar event..</param>
        /// <param name="calendarCode">The identifier for the calendar..</param>
        /// <param name="schoolId">The identifier assigned to a school..</param>
        /// <param name="schoolYear">The identifier for the school year associated with the calendar..</param>
        public TrackedChangesEdFiCalendarDateKey(DateTime date = default(DateTime), string calendarCode = default(string), long schoolId = default(long), int schoolYear = default(int))
        {
            this.Date = date;
            this.CalendarCode = calendarCode;
            this.SchoolId = schoolId;
            this.SchoolYear = schoolYear;
        }

        /// <summary>
        /// The month, day, and year of the calendar event.
        /// </summary>
        /// <value>The month, day, and year of the calendar event.</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// The identifier for the calendar.
        /// </summary>
        /// <value>The identifier for the calendar.</value>
        [DataMember(Name = "calendarCode", EmitDefaultValue = false)]
        public string CalendarCode { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name = "schoolId", EmitDefaultValue = false)]
        public long SchoolId { get; set; }

        /// <summary>
        /// The identifier for the school year associated with the calendar.
        /// </summary>
        /// <value>The identifier for the school year associated with the calendar.</value>
        [DataMember(Name = "schoolYear", EmitDefaultValue = false)]
        public int SchoolYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiCalendarDateKey {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  CalendarCode: ").Append(CalendarCode).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiCalendarDateKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiCalendarDateKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiCalendarDateKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiCalendarDateKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.CalendarCode == input.CalendarCode ||
                    (this.CalendarCode != null &&
                    this.CalendarCode.Equals(input.CalendarCode))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    this.SchoolId.Equals(input.SchoolId)
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    this.SchoolYear.Equals(input.SchoolYear)
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
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.CalendarCode != null)
                {
                    hashCode = (hashCode * 59) + this.CalendarCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchoolId.GetHashCode();
                hashCode = (hashCode * 59) + this.SchoolYear.GetHashCode();
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
            // CalendarCode (string) maxLength
            if (this.CalendarCode != null && this.CalendarCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CalendarCode, length must be less than 60.", new [] { "CalendarCode" });
            }

            // CalendarCode (string) minLength
            if (this.CalendarCode != null && this.CalendarCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CalendarCode, length must be greater than 1.", new [] { "CalendarCode" });
            }

            yield break;
        }
    }

}
