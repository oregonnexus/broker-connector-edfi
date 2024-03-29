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
    /// TrackedChangesEdFiStudentProgramAttendanceEventKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_studentProgramAttendanceEventKey")]
    public partial class TrackedChangesEdFiStudentProgramAttendanceEventKey : IEquatable<TrackedChangesEdFiStudentProgramAttendanceEventKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStudentProgramAttendanceEventKey" /> class.
        /// </summary>
        /// <param name="attendanceEventCategoryDescriptor">A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy..</param>
        /// <param name="eventDate">Date for this attendance event..</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="programEducationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="programName">The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies..</param>
        /// <param name="programTypeDescriptor">The type of program..</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student..</param>
        public TrackedChangesEdFiStudentProgramAttendanceEventKey(string attendanceEventCategoryDescriptor = default(string), DateTime eventDate = default(DateTime), long educationOrganizationId = default(long), long programEducationOrganizationId = default(long), string programName = default(string), string programTypeDescriptor = default(string), string studentUniqueId = default(string))
        {
            this.AttendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor;
            this.EventDate = eventDate;
            this.EducationOrganizationId = educationOrganizationId;
            this.ProgramEducationOrganizationId = programEducationOrganizationId;
            this.ProgramName = programName;
            this.ProgramTypeDescriptor = programTypeDescriptor;
            this.StudentUniqueId = studentUniqueId;
        }

        /// <summary>
        /// A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.
        /// </summary>
        /// <value>A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.</value>
        [DataMember(Name = "attendanceEventCategoryDescriptor", EmitDefaultValue = false)]
        public string AttendanceEventCategoryDescriptor { get; set; }

        /// <summary>
        /// Date for this attendance event.
        /// </summary>
        /// <value>Date for this attendance event.</value>
        [DataMember(Name = "eventDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = false)]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "programEducationOrganizationId", EmitDefaultValue = false)]
        public long ProgramEducationOrganizationId { get; set; }

        /// <summary>
        /// The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies.
        /// </summary>
        /// <value>The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies.</value>
        [DataMember(Name = "programName", EmitDefaultValue = false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// The type of program.
        /// </summary>
        /// <value>The type of program.</value>
        [DataMember(Name = "programTypeDescriptor", EmitDefaultValue = false)]
        public string ProgramTypeDescriptor { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name = "studentUniqueId", EmitDefaultValue = false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiStudentProgramAttendanceEventKey {\n");
            sb.Append("  AttendanceEventCategoryDescriptor: ").Append(AttendanceEventCategoryDescriptor).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  ProgramEducationOrganizationId: ").Append(ProgramEducationOrganizationId).Append("\n");
            sb.Append("  ProgramName: ").Append(ProgramName).Append("\n");
            sb.Append("  ProgramTypeDescriptor: ").Append(ProgramTypeDescriptor).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiStudentProgramAttendanceEventKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiStudentProgramAttendanceEventKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiStudentProgramAttendanceEventKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiStudentProgramAttendanceEventKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId)
                ) && 
                (
                    this.ProgramEducationOrganizationId == input.ProgramEducationOrganizationId ||
                    this.ProgramEducationOrganizationId.Equals(input.ProgramEducationOrganizationId)
                ) && 
                (
                    this.ProgramName == input.ProgramName ||
                    (this.ProgramName != null &&
                    this.ProgramName.Equals(input.ProgramName))
                ) && 
                (
                    this.ProgramTypeDescriptor == input.ProgramTypeDescriptor ||
                    (this.ProgramTypeDescriptor != null &&
                    this.ProgramTypeDescriptor.Equals(input.ProgramTypeDescriptor))
                ) && 
                (
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
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
                if (this.AttendanceEventCategoryDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.AttendanceEventCategoryDescriptor.GetHashCode();
                }
                if (this.EventDate != null)
                {
                    hashCode = (hashCode * 59) + this.EventDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
                hashCode = (hashCode * 59) + this.ProgramEducationOrganizationId.GetHashCode();
                if (this.ProgramName != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramName.GetHashCode();
                }
                if (this.ProgramTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramTypeDescriptor.GetHashCode();
                }
                if (this.StudentUniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.StudentUniqueId.GetHashCode();
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

            // ProgramName (string) maxLength
            if (this.ProgramName != null && this.ProgramName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramName, length must be less than 60.", new [] { "ProgramName" });
            }

            // ProgramName (string) minLength
            if (this.ProgramName != null && this.ProgramName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramName, length must be greater than 1.", new [] { "ProgramName" });
            }

            // ProgramTypeDescriptor (string) maxLength
            if (this.ProgramTypeDescriptor != null && this.ProgramTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramTypeDescriptor, length must be less than 306.", new [] { "ProgramTypeDescriptor" });
            }

            // StudentUniqueId (string) maxLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            // StudentUniqueId (string) minLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be greater than 1.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

}
