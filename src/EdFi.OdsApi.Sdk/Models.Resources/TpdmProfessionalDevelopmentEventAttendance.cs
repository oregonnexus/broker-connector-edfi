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
    /// TpdmProfessionalDevelopmentEventAttendance
    /// </summary>
    [DataContract]
    public partial class TpdmProfessionalDevelopmentEventAttendance :  IEquatable<TpdmProfessionalDevelopmentEventAttendance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmProfessionalDevelopmentEventAttendance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmProfessionalDevelopmentEventAttendance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmProfessionalDevelopmentEventAttendance" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="attendanceDate">Date for this attendance event. (required).</param>
        /// <param name="personReference">personReference (required).</param>
        /// <param name="professionalDevelopmentEventReference">professionalDevelopmentEventReference (required).</param>
        /// <param name="attendanceEventCategoryDescriptor">A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy. (required).</param>
        /// <param name="attendanceEventReason">The reported reason for a teacher candidate&#39;s absence..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmProfessionalDevelopmentEventAttendance(string id = default(string), DateTime? attendanceDate = default(DateTime?), EdFiPersonReference personReference = default(EdFiPersonReference), TpdmProfessionalDevelopmentEventReference professionalDevelopmentEventReference = default(TpdmProfessionalDevelopmentEventReference), string attendanceEventCategoryDescriptor = default(string), string attendanceEventReason = default(string), string etag = default(string))
        {
            // to ensure "attendanceDate" is required (not null)
            if (attendanceDate == null)
            {
                throw new InvalidDataException("attendanceDate is a required property for TpdmProfessionalDevelopmentEventAttendance and cannot be null");
            }
            else
            {
                this.AttendanceDate = attendanceDate;
            }
            // to ensure "personReference" is required (not null)
            if (personReference == null)
            {
                throw new InvalidDataException("personReference is a required property for TpdmProfessionalDevelopmentEventAttendance and cannot be null");
            }
            else
            {
                this.PersonReference = personReference;
            }
            // to ensure "professionalDevelopmentEventReference" is required (not null)
            if (professionalDevelopmentEventReference == null)
            {
                throw new InvalidDataException("professionalDevelopmentEventReference is a required property for TpdmProfessionalDevelopmentEventAttendance and cannot be null");
            }
            else
            {
                this.ProfessionalDevelopmentEventReference = professionalDevelopmentEventReference;
            }
            // to ensure "attendanceEventCategoryDescriptor" is required (not null)
            if (attendanceEventCategoryDescriptor == null)
            {
                throw new InvalidDataException("attendanceEventCategoryDescriptor is a required property for TpdmProfessionalDevelopmentEventAttendance and cannot be null");
            }
            else
            {
                this.AttendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor;
            }
            this.Id = id;
            this.AttendanceEventReason = attendanceEventReason;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Date for this attendance event.
        /// </summary>
        /// <value>Date for this attendance event.</value>
        [DataMember(Name="attendanceDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? AttendanceDate { get; set; }

        /// <summary>
        /// Gets or Sets PersonReference
        /// </summary>
        [DataMember(Name="personReference", EmitDefaultValue=false)]
        public EdFiPersonReference PersonReference { get; set; }

        /// <summary>
        /// Gets or Sets ProfessionalDevelopmentEventReference
        /// </summary>
        [DataMember(Name="professionalDevelopmentEventReference", EmitDefaultValue=false)]
        public TpdmProfessionalDevelopmentEventReference ProfessionalDevelopmentEventReference { get; set; }

        /// <summary>
        /// A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.
        /// </summary>
        /// <value>A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.</value>
        [DataMember(Name="attendanceEventCategoryDescriptor", EmitDefaultValue=false)]
        public string AttendanceEventCategoryDescriptor { get; set; }

        /// <summary>
        /// The reported reason for a teacher candidate&#39;s absence.
        /// </summary>
        /// <value>The reported reason for a teacher candidate&#39;s absence.</value>
        [DataMember(Name="attendanceEventReason", EmitDefaultValue=false)]
        public string AttendanceEventReason { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmProfessionalDevelopmentEventAttendance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AttendanceDate: ").Append(AttendanceDate).Append("\n");
            sb.Append("  PersonReference: ").Append(PersonReference).Append("\n");
            sb.Append("  ProfessionalDevelopmentEventReference: ").Append(ProfessionalDevelopmentEventReference).Append("\n");
            sb.Append("  AttendanceEventCategoryDescriptor: ").Append(AttendanceEventCategoryDescriptor).Append("\n");
            sb.Append("  AttendanceEventReason: ").Append(AttendanceEventReason).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as TpdmProfessionalDevelopmentEventAttendance);
        }

        /// <summary>
        /// Returns true if TpdmProfessionalDevelopmentEventAttendance instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmProfessionalDevelopmentEventAttendance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmProfessionalDevelopmentEventAttendance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AttendanceDate == input.AttendanceDate ||
                    (this.AttendanceDate != null &&
                    this.AttendanceDate.Equals(input.AttendanceDate))
                ) && 
                (
                    this.PersonReference == input.PersonReference ||
                    (this.PersonReference != null &&
                    this.PersonReference.Equals(input.PersonReference))
                ) && 
                (
                    this.ProfessionalDevelopmentEventReference == input.ProfessionalDevelopmentEventReference ||
                    (this.ProfessionalDevelopmentEventReference != null &&
                    this.ProfessionalDevelopmentEventReference.Equals(input.ProfessionalDevelopmentEventReference))
                ) && 
                (
                    this.AttendanceEventCategoryDescriptor == input.AttendanceEventCategoryDescriptor ||
                    (this.AttendanceEventCategoryDescriptor != null &&
                    this.AttendanceEventCategoryDescriptor.Equals(input.AttendanceEventCategoryDescriptor))
                ) && 
                (
                    this.AttendanceEventReason == input.AttendanceEventReason ||
                    (this.AttendanceEventReason != null &&
                    this.AttendanceEventReason.Equals(input.AttendanceEventReason))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AttendanceDate != null)
                    hashCode = hashCode * 59 + this.AttendanceDate.GetHashCode();
                if (this.PersonReference != null)
                    hashCode = hashCode * 59 + this.PersonReference.GetHashCode();
                if (this.ProfessionalDevelopmentEventReference != null)
                    hashCode = hashCode * 59 + this.ProfessionalDevelopmentEventReference.GetHashCode();
                if (this.AttendanceEventCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.AttendanceEventCategoryDescriptor.GetHashCode();
                if (this.AttendanceEventReason != null)
                    hashCode = hashCode * 59 + this.AttendanceEventReason.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
