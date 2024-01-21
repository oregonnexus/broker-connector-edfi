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
    /// EdFiStudentSchoolAttendanceEvent
    /// </summary>
    [DataContract(Name = "edFi_studentSchoolAttendanceEvent")]
    public partial class EdFiStudentSchoolAttendanceEvent : IEquatable<EdFiStudentSchoolAttendanceEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolAttendanceEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSchoolAttendanceEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolAttendanceEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="attendanceEventCategoryDescriptor">A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy. (required).</param>
        /// <param name="eventDate">Date for this attendance event. (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="sessionReference">sessionReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="arrivalTime">The time of day the student arrived for the attendance event in ISO 8601 format..</param>
        /// <param name="attendanceEventReason">The reported reason for a student&#39;s absence..</param>
        /// <param name="departureTime">The time of day the student departed for the attendance event in ISO 8601 format..</param>
        /// <param name="educationalEnvironmentDescriptor">The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section..</param>
        /// <param name="eventDuration">The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33..</param>
        /// <param name="schoolAttendanceDuration">The duration in minutes of the school attendance event..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiStudentSchoolAttendanceEvent(string id = default(string), string attendanceEventCategoryDescriptor = default(string), DateTime eventDate = default(DateTime), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), EdFiSessionReference sessionReference = default(EdFiSessionReference), EdFiStudentReference studentReference = default(EdFiStudentReference), string arrivalTime = default(string), string attendanceEventReason = default(string), string departureTime = default(string), string educationalEnvironmentDescriptor = default(string), double? eventDuration = default(double?), int? schoolAttendanceDuration = default(int?), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "attendanceEventCategoryDescriptor" is required (not null)
            if (attendanceEventCategoryDescriptor == null)
            {
                throw new ArgumentNullException("attendanceEventCategoryDescriptor is a required property for EdFiStudentSchoolAttendanceEvent and cannot be null");
            }
            this.AttendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor;
            this.EventDate = eventDate;
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new ArgumentNullException("schoolReference is a required property for EdFiStudentSchoolAttendanceEvent and cannot be null");
            }
            this.SchoolReference = schoolReference;
            // to ensure "sessionReference" is required (not null)
            if (sessionReference == null)
            {
                throw new ArgumentNullException("sessionReference is a required property for EdFiStudentSchoolAttendanceEvent and cannot be null");
            }
            this.SessionReference = sessionReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for EdFiStudentSchoolAttendanceEvent and cannot be null");
            }
            this.StudentReference = studentReference;
            this.Id = id;
            this.ArrivalTime = arrivalTime;
            this.AttendanceEventReason = attendanceEventReason;
            this.DepartureTime = departureTime;
            this.EducationalEnvironmentDescriptor = educationalEnvironmentDescriptor;
            this.EventDuration = eventDuration;
            this.SchoolAttendanceDuration = schoolAttendanceDuration;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.
        /// </summary>
        /// <value>A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.</value>
        [DataMember(Name = "attendanceEventCategoryDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string AttendanceEventCategoryDescriptor { get; set; }

        /// <summary>
        /// Date for this attendance event.
        /// </summary>
        /// <value>Date for this attendance event.</value>
        [DataMember(Name = "eventDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets SessionReference
        /// </summary>
        [DataMember(Name = "sessionReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSessionReference SessionReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The time of day the student arrived for the attendance event in ISO 8601 format.
        /// </summary>
        /// <value>The time of day the student arrived for the attendance event in ISO 8601 format.</value>
        [DataMember(Name = "arrivalTime", EmitDefaultValue = true)]
        public string ArrivalTime { get; set; }

        /// <summary>
        /// The reported reason for a student&#39;s absence.
        /// </summary>
        /// <value>The reported reason for a student&#39;s absence.</value>
        [DataMember(Name = "attendanceEventReason", EmitDefaultValue = true)]
        public string AttendanceEventReason { get; set; }

        /// <summary>
        /// The time of day the student departed for the attendance event in ISO 8601 format.
        /// </summary>
        /// <value>The time of day the student departed for the attendance event in ISO 8601 format.</value>
        [DataMember(Name = "departureTime", EmitDefaultValue = true)]
        public string DepartureTime { get; set; }

        /// <summary>
        /// The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section.
        /// </summary>
        /// <value>The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section.</value>
        [DataMember(Name = "educationalEnvironmentDescriptor", EmitDefaultValue = true)]
        public string EducationalEnvironmentDescriptor { get; set; }

        /// <summary>
        /// The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33.
        /// </summary>
        /// <value>The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33.</value>
        [DataMember(Name = "eventDuration", EmitDefaultValue = true)]
        public double? EventDuration { get; set; }

        /// <summary>
        /// The duration in minutes of the school attendance event.
        /// </summary>
        /// <value>The duration in minutes of the school attendance event.</value>
        [DataMember(Name = "schoolAttendanceDuration", EmitDefaultValue = true)]
        public int? SchoolAttendanceDuration { get; set; }

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
            sb.Append("class EdFiStudentSchoolAttendanceEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AttendanceEventCategoryDescriptor: ").Append(AttendanceEventCategoryDescriptor).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  SessionReference: ").Append(SessionReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  ArrivalTime: ").Append(ArrivalTime).Append("\n");
            sb.Append("  AttendanceEventReason: ").Append(AttendanceEventReason).Append("\n");
            sb.Append("  DepartureTime: ").Append(DepartureTime).Append("\n");
            sb.Append("  EducationalEnvironmentDescriptor: ").Append(EducationalEnvironmentDescriptor).Append("\n");
            sb.Append("  EventDuration: ").Append(EventDuration).Append("\n");
            sb.Append("  SchoolAttendanceDuration: ").Append(SchoolAttendanceDuration).Append("\n");
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
            return this.Equals(input as EdFiStudentSchoolAttendanceEvent);
        }

        /// <summary>
        /// Returns true if EdFiStudentSchoolAttendanceEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSchoolAttendanceEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSchoolAttendanceEvent input)
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
                    this.AttendanceEventCategoryDescriptor == input.AttendanceEventCategoryDescriptor ||
                    (this.AttendanceEventCategoryDescriptor != null &&
                    this.AttendanceEventCategoryDescriptor.Equals(input.AttendanceEventCategoryDescriptor))
                ) && 
                (
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.SessionReference == input.SessionReference ||
                    (this.SessionReference != null &&
                    this.SessionReference.Equals(input.SessionReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.ArrivalTime == input.ArrivalTime ||
                    (this.ArrivalTime != null &&
                    this.ArrivalTime.Equals(input.ArrivalTime))
                ) && 
                (
                    this.AttendanceEventReason == input.AttendanceEventReason ||
                    (this.AttendanceEventReason != null &&
                    this.AttendanceEventReason.Equals(input.AttendanceEventReason))
                ) && 
                (
                    this.DepartureTime == input.DepartureTime ||
                    (this.DepartureTime != null &&
                    this.DepartureTime.Equals(input.DepartureTime))
                ) && 
                (
                    this.EducationalEnvironmentDescriptor == input.EducationalEnvironmentDescriptor ||
                    (this.EducationalEnvironmentDescriptor != null &&
                    this.EducationalEnvironmentDescriptor.Equals(input.EducationalEnvironmentDescriptor))
                ) && 
                (
                    this.EventDuration == input.EventDuration ||
                    (this.EventDuration != null &&
                    this.EventDuration.Equals(input.EventDuration))
                ) && 
                (
                    this.SchoolAttendanceDuration == input.SchoolAttendanceDuration ||
                    (this.SchoolAttendanceDuration != null &&
                    this.SchoolAttendanceDuration.Equals(input.SchoolAttendanceDuration))
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
                if (this.AttendanceEventCategoryDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.AttendanceEventCategoryDescriptor.GetHashCode();
                }
                if (this.EventDate != null)
                {
                    hashCode = (hashCode * 59) + this.EventDate.GetHashCode();
                }
                if (this.SchoolReference != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolReference.GetHashCode();
                }
                if (this.SessionReference != null)
                {
                    hashCode = (hashCode * 59) + this.SessionReference.GetHashCode();
                }
                if (this.StudentReference != null)
                {
                    hashCode = (hashCode * 59) + this.StudentReference.GetHashCode();
                }
                if (this.ArrivalTime != null)
                {
                    hashCode = (hashCode * 59) + this.ArrivalTime.GetHashCode();
                }
                if (this.AttendanceEventReason != null)
                {
                    hashCode = (hashCode * 59) + this.AttendanceEventReason.GetHashCode();
                }
                if (this.DepartureTime != null)
                {
                    hashCode = (hashCode * 59) + this.DepartureTime.GetHashCode();
                }
                if (this.EducationalEnvironmentDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.EducationalEnvironmentDescriptor.GetHashCode();
                }
                if (this.EventDuration != null)
                {
                    hashCode = (hashCode * 59) + this.EventDuration.GetHashCode();
                }
                if (this.SchoolAttendanceDuration != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolAttendanceDuration.GetHashCode();
                }
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
            // AttendanceEventCategoryDescriptor (string) maxLength
            if (this.AttendanceEventCategoryDescriptor != null && this.AttendanceEventCategoryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AttendanceEventCategoryDescriptor, length must be less than 306.", new [] { "AttendanceEventCategoryDescriptor" });
            }

            // AttendanceEventReason (string) maxLength
            if (this.AttendanceEventReason != null && this.AttendanceEventReason.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AttendanceEventReason, length must be less than 255.", new [] { "AttendanceEventReason" });
            }

            // AttendanceEventReason (string) minLength
            if (this.AttendanceEventReason != null && this.AttendanceEventReason.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AttendanceEventReason, length must be greater than 1.", new [] { "AttendanceEventReason" });
            }

            // EducationalEnvironmentDescriptor (string) maxLength
            if (this.EducationalEnvironmentDescriptor != null && this.EducationalEnvironmentDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducationalEnvironmentDescriptor, length must be less than 306.", new [] { "EducationalEnvironmentDescriptor" });
            }

            // EventDuration (double?) maximum
            if (this.EventDuration > (double?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventDuration, must be a value less than or equal to 1.", new [] { "EventDuration" });
            }

            // EventDuration (double?) minimum
            if (this.EventDuration < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventDuration, must be a value greater than or equal to 0.", new [] { "EventDuration" });
            }

            // SchoolAttendanceDuration (int?) maximum
            if (this.SchoolAttendanceDuration > (int?)1440)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SchoolAttendanceDuration, must be a value less than or equal to 1440.", new [] { "SchoolAttendanceDuration" });
            }

            // SchoolAttendanceDuration (int?) minimum
            if (this.SchoolAttendanceDuration < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SchoolAttendanceDuration, must be a value greater than or equal to 0.", new [] { "SchoolAttendanceDuration" });
            }

            yield break;
        }
    }

}
