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
    /// TrackedChangesEdFiStudentContactAssociationKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_studentContactAssociationKey")]
    public partial class TrackedChangesEdFiStudentContactAssociationKey : IEquatable<TrackedChangesEdFiStudentContactAssociationKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStudentContactAssociationKey" /> class.
        /// </summary>
        /// <param name="contactUniqueId">A unique alphanumeric code assigned to a contact..</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student..</param>
        public TrackedChangesEdFiStudentContactAssociationKey(string contactUniqueId = default(string), string studentUniqueId = default(string))
        {
            this.ContactUniqueId = contactUniqueId;
            this.StudentUniqueId = studentUniqueId;
        }

        /// <summary>
        /// A unique alphanumeric code assigned to a contact.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a contact.</value>
        [DataMember(Name = "contactUniqueId", EmitDefaultValue = false)]
        public string ContactUniqueId { get; set; }

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
            sb.Append("class TrackedChangesEdFiStudentContactAssociationKey {\n");
            sb.Append("  ContactUniqueId: ").Append(ContactUniqueId).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiStudentContactAssociationKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiStudentContactAssociationKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiStudentContactAssociationKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiStudentContactAssociationKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContactUniqueId == input.ContactUniqueId ||
                    (this.ContactUniqueId != null &&
                    this.ContactUniqueId.Equals(input.ContactUniqueId))
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
                if (this.ContactUniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.ContactUniqueId.GetHashCode();
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
            // ContactUniqueId (string) maxLength
            if (this.ContactUniqueId != null && this.ContactUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactUniqueId, length must be less than 32.", new [] { "ContactUniqueId" });
            }

            // ContactUniqueId (string) minLength
            if (this.ContactUniqueId != null && this.ContactUniqueId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactUniqueId, length must be greater than 1.", new [] { "ContactUniqueId" });
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
