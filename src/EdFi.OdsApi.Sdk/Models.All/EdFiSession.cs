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
    /// EdFiSession
    /// </summary>
    [DataContract(Name = "edFi_session")]
    public partial class EdFiSession : IEquatable<EdFiSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSession" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sessionName">The identifier for the calendar for the academic session. (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference (required).</param>
        /// <param name="academicWeeks">An unordered collection of sessionAcademicWeeks. The academic weeks associated with the school year..</param>
        /// <param name="beginDate">Month, day, and year of the first day of the session. (required).</param>
        /// <param name="endDate">Month, day and year of the last day of the session. (required).</param>
        /// <param name="gradingPeriods">An unordered collection of sessionGradingPeriods. Grading periods associated with the session..</param>
        /// <param name="termDescriptor">An descriptor value indicating the term. (required).</param>
        /// <param name="totalInstructionalDays">The total number of instructional days in the school calendar. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiSession(string id = default(string), string sessionName = default(string), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference), List<EdFiSessionAcademicWeek> academicWeeks = default(List<EdFiSessionAcademicWeek>), DateTime beginDate = default(DateTime), DateTime endDate = default(DateTime), List<EdFiSessionGradingPeriod> gradingPeriods = default(List<EdFiSessionGradingPeriod>), string termDescriptor = default(string), int totalInstructionalDays = default(int), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "sessionName" is required (not null)
            if (sessionName == null)
            {
                throw new ArgumentNullException("sessionName is a required property for EdFiSession and cannot be null");
            }
            this.SessionName = sessionName;
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new ArgumentNullException("schoolReference is a required property for EdFiSession and cannot be null");
            }
            this.SchoolReference = schoolReference;
            // to ensure "schoolYearTypeReference" is required (not null)
            if (schoolYearTypeReference == null)
            {
                throw new ArgumentNullException("schoolYearTypeReference is a required property for EdFiSession and cannot be null");
            }
            this.SchoolYearTypeReference = schoolYearTypeReference;
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            // to ensure "termDescriptor" is required (not null)
            if (termDescriptor == null)
            {
                throw new ArgumentNullException("termDescriptor is a required property for EdFiSession and cannot be null");
            }
            this.TermDescriptor = termDescriptor;
            this.TotalInstructionalDays = totalInstructionalDays;
            this.Id = id;
            this.AcademicWeeks = academicWeeks;
            this.GradingPeriods = gradingPeriods;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier for the calendar for the academic session.
        /// </summary>
        /// <value>The identifier for the calendar for the academic session.</value>
        [DataMember(Name = "sessionName", IsRequired = true, EmitDefaultValue = true)]
        public string SessionName { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name = "schoolYearTypeReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// An unordered collection of sessionAcademicWeeks. The academic weeks associated with the school year.
        /// </summary>
        /// <value>An unordered collection of sessionAcademicWeeks. The academic weeks associated with the school year.</value>
        [DataMember(Name = "academicWeeks", EmitDefaultValue = false)]
        public List<EdFiSessionAcademicWeek> AcademicWeeks { get; set; }

        /// <summary>
        /// Month, day, and year of the first day of the session.
        /// </summary>
        /// <value>Month, day, and year of the first day of the session.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Month, day and year of the last day of the session.
        /// </summary>
        /// <value>Month, day and year of the last day of the session.</value>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// An unordered collection of sessionGradingPeriods. Grading periods associated with the session.
        /// </summary>
        /// <value>An unordered collection of sessionGradingPeriods. Grading periods associated with the session.</value>
        [DataMember(Name = "gradingPeriods", EmitDefaultValue = false)]
        public List<EdFiSessionGradingPeriod> GradingPeriods { get; set; }

        /// <summary>
        /// An descriptor value indicating the term.
        /// </summary>
        /// <value>An descriptor value indicating the term.</value>
        [DataMember(Name = "termDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string TermDescriptor { get; set; }

        /// <summary>
        /// The total number of instructional days in the school calendar.
        /// </summary>
        /// <value>The total number of instructional days in the school calendar.</value>
        [DataMember(Name = "totalInstructionalDays", IsRequired = true, EmitDefaultValue = true)]
        public int TotalInstructionalDays { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// The date and time the resource was last modified.
        /// </summary>
        /// <value>The date and time the resource was last modified.</value>
        [DataMember(Name = "_lastModifiedDate", EmitDefaultValue = false)]
        public DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
            sb.Append("  AcademicWeeks: ").Append(AcademicWeeks).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  GradingPeriods: ").Append(GradingPeriods).Append("\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
            sb.Append("  TotalInstructionalDays: ").Append(TotalInstructionalDays).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
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
            return this.Equals(input as EdFiSession);
        }

        /// <summary>
        /// Returns true if EdFiSession instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSession input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
                ) && 
                (
                    this.AcademicWeeks == input.AcademicWeeks ||
                    this.AcademicWeeks != null &&
                    input.AcademicWeeks != null &&
                    this.AcademicWeeks.SequenceEqual(input.AcademicWeeks)
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.GradingPeriods == input.GradingPeriods ||
                    this.GradingPeriods != null &&
                    input.GradingPeriods != null &&
                    this.GradingPeriods.SequenceEqual(input.GradingPeriods)
                ) && 
                (
                    this.TermDescriptor == input.TermDescriptor ||
                    (this.TermDescriptor != null &&
                    this.TermDescriptor.Equals(input.TermDescriptor))
                ) && 
                (
                    this.TotalInstructionalDays == input.TotalInstructionalDays ||
                    this.TotalInstructionalDays.Equals(input.TotalInstructionalDays)
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.SessionName != null)
                {
                    hashCode = (hashCode * 59) + this.SessionName.GetHashCode();
                }
                if (this.SchoolReference != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolReference.GetHashCode();
                }
                if (this.SchoolYearTypeReference != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolYearTypeReference.GetHashCode();
                }
                if (this.AcademicWeeks != null)
                {
                    hashCode = (hashCode * 59) + this.AcademicWeeks.GetHashCode();
                }
                if (this.BeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.GradingPeriods != null)
                {
                    hashCode = (hashCode * 59) + this.GradingPeriods.GetHashCode();
                }
                if (this.TermDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.TermDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalInstructionalDays.GetHashCode();
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
                }
                if (this.LastModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedDate.GetHashCode();
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

            // TermDescriptor (string) maxLength
            if (this.TermDescriptor != null && this.TermDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TermDescriptor, length must be less than 306.", new [] { "TermDescriptor" });
            }

            // TotalInstructionalDays (int) minimum
            if (this.TotalInstructionalDays < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalInstructionalDays, must be a value greater than or equal to 0.", new [] { "TotalInstructionalDays" });
            }

            yield break;
        }
    }

}
