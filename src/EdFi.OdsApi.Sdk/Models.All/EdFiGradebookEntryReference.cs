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
    /// EdFiGradebookEntryReference
    /// </summary>
    [DataContract(Name = "edFi_gradebookEntryReference")]
    public partial class EdFiGradebookEntryReference : IEquatable<EdFiGradebookEntryReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradebookEntryReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGradebookEntryReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradebookEntryReference" /> class.
        /// </summary>
        /// <param name="gradebookEntryIdentifier">A unique number or alphanumeric code assigned to a gradebook entry by the source system. (required).</param>
        /// <param name="_namespace">Namespace URI for the source of the gradebook entry. (required).</param>
        /// <param name="link">link.</param>
        public EdFiGradebookEntryReference(string gradebookEntryIdentifier = default(string), string _namespace = default(string), Link link = default(Link))
        {
            // to ensure "gradebookEntryIdentifier" is required (not null)
            if (gradebookEntryIdentifier == null)
            {
                throw new ArgumentNullException("gradebookEntryIdentifier is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            this.GradebookEntryIdentifier = gradebookEntryIdentifier;
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new ArgumentNullException("_namespace is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            this.Namespace = _namespace;
            this.Link = link;
        }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a gradebook entry by the source system.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a gradebook entry by the source system.</value>
        [DataMember(Name = "gradebookEntryIdentifier", IsRequired = true, EmitDefaultValue = true)]
        public string GradebookEntryIdentifier { get; set; }

        /// <summary>
        /// Namespace URI for the source of the gradebook entry.
        /// </summary>
        /// <value>Namespace URI for the source of the gradebook entry.</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = true)]
        public string Namespace { get; set; }

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
            sb.Append("class EdFiGradebookEntryReference {\n");
            sb.Append("  GradebookEntryIdentifier: ").Append(GradebookEntryIdentifier).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
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
            return this.Equals(input as EdFiGradebookEntryReference);
        }

        /// <summary>
        /// Returns true if EdFiGradebookEntryReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGradebookEntryReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGradebookEntryReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GradebookEntryIdentifier == input.GradebookEntryIdentifier ||
                    (this.GradebookEntryIdentifier != null &&
                    this.GradebookEntryIdentifier.Equals(input.GradebookEntryIdentifier))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
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
                if (this.GradebookEntryIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.GradebookEntryIdentifier.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
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
            // GradebookEntryIdentifier (string) maxLength
            if (this.GradebookEntryIdentifier != null && this.GradebookEntryIdentifier.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradebookEntryIdentifier, length must be less than 60.", new [] { "GradebookEntryIdentifier" });
            }

            // GradebookEntryIdentifier (string) minLength
            if (this.GradebookEntryIdentifier != null && this.GradebookEntryIdentifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradebookEntryIdentifier, length must be greater than 1.", new [] { "GradebookEntryIdentifier" });
            }

            // Namespace (string) maxLength
            if (this.Namespace != null && this.Namespace.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Namespace, length must be less than 255.", new [] { "Namespace" });
            }

            // Namespace (string) minLength
            if (this.Namespace != null && this.Namespace.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Namespace, length must be greater than 5.", new [] { "Namespace" });
            }

            yield break;
        }
    }

}
