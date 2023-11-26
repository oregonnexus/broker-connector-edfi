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
    /// TrackedChangesEdFiSurveySectionKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_surveySectionKey")]
    public partial class TrackedChangesEdFiSurveySectionKey : IEquatable<TrackedChangesEdFiSurveySectionKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiSurveySectionKey" /> class.
        /// </summary>
        /// <param name="surveySectionTitle">The title or label for the survey section..</param>
        /// <param name="_namespace">Namespace for the survey..</param>
        /// <param name="surveyIdentifier">The unique survey identifier from the survey tool..</param>
        public TrackedChangesEdFiSurveySectionKey(string surveySectionTitle = default(string), string _namespace = default(string), string surveyIdentifier = default(string))
        {
            this.SurveySectionTitle = surveySectionTitle;
            this.Namespace = _namespace;
            this.SurveyIdentifier = surveyIdentifier;
        }

        /// <summary>
        /// The title or label for the survey section.
        /// </summary>
        /// <value>The title or label for the survey section.</value>
        [DataMember(Name = "surveySectionTitle", EmitDefaultValue = false)]
        public string SurveySectionTitle { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiSurveySectionKey {\n");
            sb.Append("  SurveySectionTitle: ").Append(SurveySectionTitle).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  SurveyIdentifier: ").Append(SurveyIdentifier).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiSurveySectionKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiSurveySectionKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiSurveySectionKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiSurveySectionKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SurveySectionTitle == input.SurveySectionTitle ||
                    (this.SurveySectionTitle != null &&
                    this.SurveySectionTitle.Equals(input.SurveySectionTitle))
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
                if (this.SurveySectionTitle != null)
                {
                    hashCode = (hashCode * 59) + this.SurveySectionTitle.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.SurveyIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.SurveyIdentifier.GetHashCode();
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
            // SurveySectionTitle (string) maxLength
            if (this.SurveySectionTitle != null && this.SurveySectionTitle.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SurveySectionTitle, length must be less than 255.", new [] { "SurveySectionTitle" });
            }

            // SurveySectionTitle (string) minLength
            if (this.SurveySectionTitle != null && this.SurveySectionTitle.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SurveySectionTitle, length must be greater than 1.", new [] { "SurveySectionTitle" });
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

            yield break;
        }
    }

}
