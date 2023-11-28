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
    /// EdFiLearningStandardEquivalenceAssociation
    /// </summary>
    [DataContract(Name = "edFi_learningStandardEquivalenceAssociation")]
    public partial class EdFiLearningStandardEquivalenceAssociation : IEquatable<EdFiLearningStandardEquivalenceAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningStandardEquivalenceAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLearningStandardEquivalenceAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningStandardEquivalenceAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="_namespace">The namespace of the organization that has created and owns the association. (required).</param>
        /// <param name="sourceLearningStandardReference">sourceLearningStandardReference (required).</param>
        /// <param name="targetLearningStandardReference">targetLearningStandardReference (required).</param>
        /// <param name="effectiveDate">The date that the association is considered to be applicable or effective..</param>
        /// <param name="learningStandardEquivalenceStrengthDescription">Captures supplemental information on the relationship. Recommended for use only when the match is partial..</param>
        /// <param name="learningStandardEquivalenceStrengthDescriptor">A measure that indicates the strength or quality of the equivalence relationship..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiLearningStandardEquivalenceAssociation(string id = default(string), string _namespace = default(string), EdFiLearningStandardReference sourceLearningStandardReference = default(EdFiLearningStandardReference), EdFiLearningStandardReference targetLearningStandardReference = default(EdFiLearningStandardReference), DateTime? effectiveDate = default(DateTime?), string learningStandardEquivalenceStrengthDescription = default(string), string learningStandardEquivalenceStrengthDescriptor = default(string), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new ArgumentNullException("_namespace is a required property for EdFiLearningStandardEquivalenceAssociation and cannot be null");
            }
            this.Namespace = _namespace;
            // to ensure "sourceLearningStandardReference" is required (not null)
            if (sourceLearningStandardReference == null)
            {
                throw new ArgumentNullException("sourceLearningStandardReference is a required property for EdFiLearningStandardEquivalenceAssociation and cannot be null");
            }
            this.SourceLearningStandardReference = sourceLearningStandardReference;
            // to ensure "targetLearningStandardReference" is required (not null)
            if (targetLearningStandardReference == null)
            {
                throw new ArgumentNullException("targetLearningStandardReference is a required property for EdFiLearningStandardEquivalenceAssociation and cannot be null");
            }
            this.TargetLearningStandardReference = targetLearningStandardReference;
            this.Id = id;
            this.EffectiveDate = effectiveDate;
            this.LearningStandardEquivalenceStrengthDescription = learningStandardEquivalenceStrengthDescription;
            this.LearningStandardEquivalenceStrengthDescriptor = learningStandardEquivalenceStrengthDescriptor;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The namespace of the organization that has created and owns the association.
        /// </summary>
        /// <value>The namespace of the organization that has created and owns the association.</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets SourceLearningStandardReference
        /// </summary>
        [DataMember(Name = "sourceLearningStandardReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiLearningStandardReference SourceLearningStandardReference { get; set; }

        /// <summary>
        /// Gets or Sets TargetLearningStandardReference
        /// </summary>
        [DataMember(Name = "targetLearningStandardReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiLearningStandardReference TargetLearningStandardReference { get; set; }

        /// <summary>
        /// The date that the association is considered to be applicable or effective.
        /// </summary>
        /// <value>The date that the association is considered to be applicable or effective.</value>
        [DataMember(Name = "effectiveDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Captures supplemental information on the relationship. Recommended for use only when the match is partial.
        /// </summary>
        /// <value>Captures supplemental information on the relationship. Recommended for use only when the match is partial.</value>
        [DataMember(Name = "learningStandardEquivalenceStrengthDescription", EmitDefaultValue = true)]
        public string LearningStandardEquivalenceStrengthDescription { get; set; }

        /// <summary>
        /// A measure that indicates the strength or quality of the equivalence relationship.
        /// </summary>
        /// <value>A measure that indicates the strength or quality of the equivalence relationship.</value>
        [DataMember(Name = "learningStandardEquivalenceStrengthDescriptor", EmitDefaultValue = true)]
        public string LearningStandardEquivalenceStrengthDescriptor { get; set; }

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
            sb.Append("class EdFiLearningStandardEquivalenceAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  SourceLearningStandardReference: ").Append(SourceLearningStandardReference).Append("\n");
            sb.Append("  TargetLearningStandardReference: ").Append(TargetLearningStandardReference).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  LearningStandardEquivalenceStrengthDescription: ").Append(LearningStandardEquivalenceStrengthDescription).Append("\n");
            sb.Append("  LearningStandardEquivalenceStrengthDescriptor: ").Append(LearningStandardEquivalenceStrengthDescriptor).Append("\n");
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
            return this.Equals(input as EdFiLearningStandardEquivalenceAssociation);
        }

        /// <summary>
        /// Returns true if EdFiLearningStandardEquivalenceAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLearningStandardEquivalenceAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLearningStandardEquivalenceAssociation input)
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
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.SourceLearningStandardReference == input.SourceLearningStandardReference ||
                    (this.SourceLearningStandardReference != null &&
                    this.SourceLearningStandardReference.Equals(input.SourceLearningStandardReference))
                ) && 
                (
                    this.TargetLearningStandardReference == input.TargetLearningStandardReference ||
                    (this.TargetLearningStandardReference != null &&
                    this.TargetLearningStandardReference.Equals(input.TargetLearningStandardReference))
                ) && 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && 
                (
                    this.LearningStandardEquivalenceStrengthDescription == input.LearningStandardEquivalenceStrengthDescription ||
                    (this.LearningStandardEquivalenceStrengthDescription != null &&
                    this.LearningStandardEquivalenceStrengthDescription.Equals(input.LearningStandardEquivalenceStrengthDescription))
                ) && 
                (
                    this.LearningStandardEquivalenceStrengthDescriptor == input.LearningStandardEquivalenceStrengthDescriptor ||
                    (this.LearningStandardEquivalenceStrengthDescriptor != null &&
                    this.LearningStandardEquivalenceStrengthDescriptor.Equals(input.LearningStandardEquivalenceStrengthDescriptor))
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
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.SourceLearningStandardReference != null)
                {
                    hashCode = (hashCode * 59) + this.SourceLearningStandardReference.GetHashCode();
                }
                if (this.TargetLearningStandardReference != null)
                {
                    hashCode = (hashCode * 59) + this.TargetLearningStandardReference.GetHashCode();
                }
                if (this.EffectiveDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveDate.GetHashCode();
                }
                if (this.LearningStandardEquivalenceStrengthDescription != null)
                {
                    hashCode = (hashCode * 59) + this.LearningStandardEquivalenceStrengthDescription.GetHashCode();
                }
                if (this.LearningStandardEquivalenceStrengthDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.LearningStandardEquivalenceStrengthDescriptor.GetHashCode();
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

            // LearningStandardEquivalenceStrengthDescription (string) maxLength
            if (this.LearningStandardEquivalenceStrengthDescription != null && this.LearningStandardEquivalenceStrengthDescription.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LearningStandardEquivalenceStrengthDescription, length must be less than 255.", new [] { "LearningStandardEquivalenceStrengthDescription" });
            }

            // LearningStandardEquivalenceStrengthDescription (string) minLength
            if (this.LearningStandardEquivalenceStrengthDescription != null && this.LearningStandardEquivalenceStrengthDescription.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LearningStandardEquivalenceStrengthDescription, length must be greater than 1.", new [] { "LearningStandardEquivalenceStrengthDescription" });
            }

            // LearningStandardEquivalenceStrengthDescriptor (string) maxLength
            if (this.LearningStandardEquivalenceStrengthDescriptor != null && this.LearningStandardEquivalenceStrengthDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LearningStandardEquivalenceStrengthDescriptor, length must be less than 306.", new [] { "LearningStandardEquivalenceStrengthDescriptor" });
            }

            yield break;
        }
    }

}
