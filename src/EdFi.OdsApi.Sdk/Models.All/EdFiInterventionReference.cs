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
    /// EdFiInterventionReference
    /// </summary>
    [DataContract(Name = "edFi_interventionReference")]
    public partial class EdFiInterventionReference : IEquatable<EdFiInterventionReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionReference" /> class.
        /// </summary>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="interventionIdentificationCode">A unique number or alphanumeric code assigned to an intervention. (required).</param>
        /// <param name="link">link.</param>
        public EdFiInterventionReference(long educationOrganizationId = default(long), string interventionIdentificationCode = default(string), Link link = default(Link))
        {
            this.EducationOrganizationId = educationOrganizationId;
            // to ensure "interventionIdentificationCode" is required (not null)
            if (interventionIdentificationCode == null)
            {
                throw new ArgumentNullException("interventionIdentificationCode is a required property for EdFiInterventionReference and cannot be null");
            }
            this.InterventionIdentificationCode = interventionIdentificationCode;
            this.Link = link;
        }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", IsRequired = true, EmitDefaultValue = true)]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to an intervention.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an intervention.</value>
        [DataMember(Name = "interventionIdentificationCode", IsRequired = true, EmitDefaultValue = true)]
        public string InterventionIdentificationCode { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiInterventionReference {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  InterventionIdentificationCode: ").Append(InterventionIdentificationCode).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiInterventionReference);
        }

        /// <summary>
        /// Returns true if EdFiInterventionReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId)
                ) && 
                (
                    this.InterventionIdentificationCode == input.InterventionIdentificationCode ||
                    (this.InterventionIdentificationCode != null &&
                    this.InterventionIdentificationCode.Equals(input.InterventionIdentificationCode))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
                if (this.InterventionIdentificationCode != null)
                {
                    hashCode = (hashCode * 59) + this.InterventionIdentificationCode.GetHashCode();
                }
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
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
            // InterventionIdentificationCode (string) maxLength
            if (this.InterventionIdentificationCode != null && this.InterventionIdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InterventionIdentificationCode, length must be less than 60.", new [] { "InterventionIdentificationCode" });
            }

            // InterventionIdentificationCode (string) minLength
            if (this.InterventionIdentificationCode != null && this.InterventionIdentificationCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InterventionIdentificationCode, length must be greater than 1.", new [] { "InterventionIdentificationCode" });
            }

            yield break;
        }
    }

}
