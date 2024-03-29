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
    /// EdFiLocation
    /// </summary>
    [DataContract(Name = "edFi_location")]
    public partial class EdFiLocation : IEquatable<EdFiLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="classroomIdentificationCode">A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity. (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="maximumNumberOfSeats">The most number of seats the class can maintain..</param>
        /// <param name="optimalNumberOfSeats">The number of seats that is most favorable to the class..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiLocation(string id = default(string), string classroomIdentificationCode = default(string), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), int? maximumNumberOfSeats = default(int?), int? optimalNumberOfSeats = default(int?), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "classroomIdentificationCode" is required (not null)
            if (classroomIdentificationCode == null)
            {
                throw new ArgumentNullException("classroomIdentificationCode is a required property for EdFiLocation and cannot be null");
            }
            this.ClassroomIdentificationCode = classroomIdentificationCode;
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new ArgumentNullException("schoolReference is a required property for EdFiLocation and cannot be null");
            }
            this.SchoolReference = schoolReference;
            this.Id = id;
            this.MaximumNumberOfSeats = maximumNumberOfSeats;
            this.OptimalNumberOfSeats = optimalNumberOfSeats;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.</value>
        [DataMember(Name = "classroomIdentificationCode", IsRequired = true, EmitDefaultValue = true)]
        public string ClassroomIdentificationCode { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// The most number of seats the class can maintain.
        /// </summary>
        /// <value>The most number of seats the class can maintain.</value>
        [DataMember(Name = "maximumNumberOfSeats", EmitDefaultValue = true)]
        public int? MaximumNumberOfSeats { get; set; }

        /// <summary>
        /// The number of seats that is most favorable to the class.
        /// </summary>
        /// <value>The number of seats that is most favorable to the class.</value>
        [DataMember(Name = "optimalNumberOfSeats", EmitDefaultValue = true)]
        public int? OptimalNumberOfSeats { get; set; }

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
            sb.Append("class EdFiLocation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClassroomIdentificationCode: ").Append(ClassroomIdentificationCode).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  MaximumNumberOfSeats: ").Append(MaximumNumberOfSeats).Append("\n");
            sb.Append("  OptimalNumberOfSeats: ").Append(OptimalNumberOfSeats).Append("\n");
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
            return this.Equals(input as EdFiLocation);
        }

        /// <summary>
        /// Returns true if EdFiLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLocation input)
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
                    this.ClassroomIdentificationCode == input.ClassroomIdentificationCode ||
                    (this.ClassroomIdentificationCode != null &&
                    this.ClassroomIdentificationCode.Equals(input.ClassroomIdentificationCode))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.MaximumNumberOfSeats == input.MaximumNumberOfSeats ||
                    (this.MaximumNumberOfSeats != null &&
                    this.MaximumNumberOfSeats.Equals(input.MaximumNumberOfSeats))
                ) && 
                (
                    this.OptimalNumberOfSeats == input.OptimalNumberOfSeats ||
                    (this.OptimalNumberOfSeats != null &&
                    this.OptimalNumberOfSeats.Equals(input.OptimalNumberOfSeats))
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
                if (this.ClassroomIdentificationCode != null)
                {
                    hashCode = (hashCode * 59) + this.ClassroomIdentificationCode.GetHashCode();
                }
                if (this.SchoolReference != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolReference.GetHashCode();
                }
                if (this.MaximumNumberOfSeats != null)
                {
                    hashCode = (hashCode * 59) + this.MaximumNumberOfSeats.GetHashCode();
                }
                if (this.OptimalNumberOfSeats != null)
                {
                    hashCode = (hashCode * 59) + this.OptimalNumberOfSeats.GetHashCode();
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
            // ClassroomIdentificationCode (string) maxLength
            if (this.ClassroomIdentificationCode != null && this.ClassroomIdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassroomIdentificationCode, length must be less than 60.", new [] { "ClassroomIdentificationCode" });
            }

            // ClassroomIdentificationCode (string) minLength
            if (this.ClassroomIdentificationCode != null && this.ClassroomIdentificationCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassroomIdentificationCode, length must be greater than 1.", new [] { "ClassroomIdentificationCode" });
            }

            yield break;
        }
    }

}
