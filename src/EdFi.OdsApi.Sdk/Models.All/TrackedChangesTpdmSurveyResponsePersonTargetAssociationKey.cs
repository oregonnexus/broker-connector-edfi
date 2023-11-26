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
    /// TrackedChangesTpdmSurveyResponsePersonTargetAssociationKey
    /// </summary>
    [DataContract(Name = "trackedChanges_tpdm_surveyResponsePersonTargetAssociationKey")]
    public partial class TrackedChangesTpdmSurveyResponsePersonTargetAssociationKey : IEquatable<TrackedChangesTpdmSurveyResponsePersonTargetAssociationKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesTpdmSurveyResponsePersonTargetAssociationKey" /> class.
        /// </summary>
        /// <param name="personId">A unique alphanumeric code assigned to a person..</param>
        /// <param name="sourceSystemDescriptor">This descriptor defines the originating record source system for the person..</param>
        /// <param name="_namespace">Namespace for the survey..</param>
        /// <param name="surveyIdentifier">The unique survey identifier from the survey tool..</param>
        /// <param name="surveyResponseIdentifier">The identifier of the survey typically from the survey application..</param>
        public TrackedChangesTpdmSurveyResponsePersonTargetAssociationKey(string personId = default(string), string sourceSystemDescriptor = default(string), string _namespace = default(string), string surveyIdentifier = default(string), string surveyResponseIdentifier = default(string))
        {
            this.PersonId = personId;
            this.SourceSystemDescriptor = sourceSystemDescriptor;
            this.Namespace = _namespace;
            this.SurveyIdentifier = surveyIdentifier;
            this.SurveyResponseIdentifier = surveyResponseIdentifier;
        }

        /// <summary>
        /// A unique alphanumeric code assigned to a person.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a person.</value>
        [DataMember(Name = "personId", EmitDefaultValue = false)]
        public string PersonId { get; set; }

        /// <summary>
        /// This descriptor defines the originating record source system for the person.
        /// </summary>
        /// <value>This descriptor defines the originating record source system for the person.</value>
        [DataMember(Name = "sourceSystemDescriptor", EmitDefaultValue = false)]
        public string SourceSystemDescriptor { get; set; }

        /// <summary>
        /// Namespace for the survey.
        /// </summary>
        /// <value>Namespace for the survey.</value>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The unique survey identifier from the survey tool.
        /// </summary>
        /// <value>The unique survey identifier from the survey tool.</value>
        [DataMember(Name = "surveyIdentifier", EmitDefaultValue = false)]
        public string SurveyIdentifier { get; set; }

        /// <summary>
        /// The identifier of the survey typically from the survey application.
        /// </summary>
        /// <value>The identifier of the survey typically from the survey application.</value>
        [DataMember(Name = "surveyResponseIdentifier", EmitDefaultValue = false)]
        public string SurveyResponseIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesTpdmSurveyResponsePersonTargetAssociationKey {\n");
            sb.Append("  PersonId: ").Append(PersonId).Append("\n");
            sb.Append("  SourceSystemDescriptor: ").Append(SourceSystemDescriptor).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  SurveyIdentifier: ").Append(SurveyIdentifier).Append("\n");
            sb.Append("  SurveyResponseIdentifier: ").Append(SurveyResponseIdentifier).Append("\n");
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
            return this.Equals(input as TrackedChangesTpdmSurveyResponsePersonTargetAssociationKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesTpdmSurveyResponsePersonTargetAssociationKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesTpdmSurveyResponsePersonTargetAssociationKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesTpdmSurveyResponsePersonTargetAssociationKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.SurveyIdentifier == input.SurveyIdentifier ||
                    (this.SurveyIdentifier != null &&
                    this.SurveyIdentifier.Equals(input.SurveyIdentifier))
                ) && 
                (
                    this.SurveyResponseIdentifier == input.SurveyResponseIdentifier ||
                    (this.SurveyResponseIdentifier != null &&
                    this.SurveyResponseIdentifier.Equals(input.SurveyResponseIdentifier))
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
                if (this.PersonId != null)
                {
                    hashCode = (hashCode * 59) + this.PersonId.GetHashCode();
                }
                if (this.SourceSystemDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.SourceSystemDescriptor.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.SurveyIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.SurveyIdentifier.GetHashCode();
                }
                if (this.SurveyResponseIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.SurveyResponseIdentifier.GetHashCode();
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

            // SurveyIdentifier (string) maxLength
            if (this.SurveyIdentifier != null && this.SurveyIdentifier.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SurveyIdentifier, length must be less than 60.", new [] { "SurveyIdentifier" });
            }

            // SurveyIdentifier (string) minLength
            if (this.SurveyIdentifier != null && this.SurveyIdentifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SurveyIdentifier, length must be greater than 1.", new [] { "SurveyIdentifier" });
            }

            // SurveyResponseIdentifier (string) maxLength
            if (this.SurveyResponseIdentifier != null && this.SurveyResponseIdentifier.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SurveyResponseIdentifier, length must be less than 60.", new [] { "SurveyResponseIdentifier" });
            }

            // SurveyResponseIdentifier (string) minLength
            if (this.SurveyResponseIdentifier != null && this.SurveyResponseIdentifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SurveyResponseIdentifier, length must be greater than 1.", new [] { "SurveyResponseIdentifier" });
            }

            yield break;
        }
    }

}