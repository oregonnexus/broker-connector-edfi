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
    /// EdFiPerson
    /// </summary>
    [DataContract(Name = "edFi_person")]
    public partial class EdFiPerson : IEquatable<EdFiPerson>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiPerson" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiPerson() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiPerson" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="personId">A unique alphanumeric code assigned to a person. (required).</param>
        /// <param name="sourceSystemDescriptor">This descriptor defines the originating record source system for the person. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiPerson(string id = default(string), string personId = default(string), string sourceSystemDescriptor = default(string), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "personId" is required (not null)
            if (personId == null)
            {
                throw new ArgumentNullException("personId is a required property for EdFiPerson and cannot be null");
            }
            this.PersonId = personId;
            // to ensure "sourceSystemDescriptor" is required (not null)
            if (sourceSystemDescriptor == null)
            {
                throw new ArgumentNullException("sourceSystemDescriptor is a required property for EdFiPerson and cannot be null");
            }
            this.SourceSystemDescriptor = sourceSystemDescriptor;
            this.Id = id;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a person.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a person.</value>
        [DataMember(Name = "personId", IsRequired = true, EmitDefaultValue = true)]
        public string PersonId { get; set; }

        /// <summary>
        /// This descriptor defines the originating record source system for the person.
        /// </summary>
        /// <value>This descriptor defines the originating record source system for the person.</value>
        [DataMember(Name = "sourceSystemDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string SourceSystemDescriptor { get; set; }

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
            sb.Append("class EdFiPerson {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PersonId: ").Append(PersonId).Append("\n");
            sb.Append("  SourceSystemDescriptor: ").Append(SourceSystemDescriptor).Append("\n");
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
            return this.Equals(input as EdFiPerson);
        }

        /// <summary>
        /// Returns true if EdFiPerson instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiPerson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiPerson input)
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
                    this.PersonId == input.PersonId ||
                    (this.PersonId != null &&
                    this.PersonId.Equals(input.PersonId))
                ) && 
                (
                    this.SourceSystemDescriptor == input.SourceSystemDescriptor ||
                    (this.SourceSystemDescriptor != null &&
                    this.SourceSystemDescriptor.Equals(input.SourceSystemDescriptor))
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
                if (this.PersonId != null)
                {
                    hashCode = (hashCode * 59) + this.PersonId.GetHashCode();
                }
                if (this.SourceSystemDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.SourceSystemDescriptor.GetHashCode();
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
            // PersonId (string) maxLength
            if (this.PersonId != null && this.PersonId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PersonId, length must be less than 32.", new [] { "PersonId" });
            }

            // PersonId (string) minLength
            if (this.PersonId != null && this.PersonId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PersonId, length must be greater than 1.", new [] { "PersonId" });
            }

            // SourceSystemDescriptor (string) maxLength
            if (this.SourceSystemDescriptor != null && this.SourceSystemDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourceSystemDescriptor, length must be less than 306.", new [] { "SourceSystemDescriptor" });
            }

            yield break;
        }
    }

}
