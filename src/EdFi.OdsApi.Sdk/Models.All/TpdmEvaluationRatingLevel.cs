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
    /// TpdmEvaluationRatingLevel
    /// </summary>
    [DataContract(Name = "tpdm_evaluationRatingLevel")]
    public partial class TpdmEvaluationRatingLevel : IEquatable<TpdmEvaluationRatingLevel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationRatingLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluationRatingLevel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationRatingLevel" /> class.
        /// </summary>
        /// <param name="evaluationRatingLevelDescriptor">The title for a level of rating or evaluation band (e.g., Excellent, Acceptable, Needs Improvement, Unacceptable). (required).</param>
        /// <param name="maxRating">The maximum numerical rating or score to achieve the evaluation rating level..</param>
        /// <param name="minRating">The minimum numerical rating or score to achieve the evaluation rating level..</param>
        public TpdmEvaluationRatingLevel(string evaluationRatingLevelDescriptor = default(string), double? maxRating = default(double?), double? minRating = default(double?))
        {
            // to ensure "evaluationRatingLevelDescriptor" is required (not null)
            if (evaluationRatingLevelDescriptor == null)
            {
                throw new ArgumentNullException("evaluationRatingLevelDescriptor is a required property for TpdmEvaluationRatingLevel and cannot be null");
            }
            this.EvaluationRatingLevelDescriptor = evaluationRatingLevelDescriptor;
            this.MaxRating = maxRating;
            this.MinRating = minRating;
        }

        /// <summary>
        /// The title for a level of rating or evaluation band (e.g., Excellent, Acceptable, Needs Improvement, Unacceptable).
        /// </summary>
        /// <value>The title for a level of rating or evaluation band (e.g., Excellent, Acceptable, Needs Improvement, Unacceptable).</value>
        [DataMember(Name = "evaluationRatingLevelDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string EvaluationRatingLevelDescriptor { get; set; }

        /// <summary>
        /// The maximum numerical rating or score to achieve the evaluation rating level.
        /// </summary>
        /// <value>The maximum numerical rating or score to achieve the evaluation rating level.</value>
        [DataMember(Name = "maxRating", EmitDefaultValue = true)]
        public double? MaxRating { get; set; }

        /// <summary>
        /// The minimum numerical rating or score to achieve the evaluation rating level.
        /// </summary>
        /// <value>The minimum numerical rating or score to achieve the evaluation rating level.</value>
        [DataMember(Name = "minRating", EmitDefaultValue = true)]
        public double? MinRating { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TpdmEvaluationRatingLevel {\n");
            sb.Append("  EvaluationRatingLevelDescriptor: ").Append(EvaluationRatingLevelDescriptor).Append("\n");
            sb.Append("  MaxRating: ").Append(MaxRating).Append("\n");
            sb.Append("  MinRating: ").Append(MinRating).Append("\n");
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
            return this.Equals(input as TpdmEvaluationRatingLevel);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationRatingLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationRatingLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationRatingLevel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EvaluationRatingLevelDescriptor == input.EvaluationRatingLevelDescriptor ||
                    (this.EvaluationRatingLevelDescriptor != null &&
                    this.EvaluationRatingLevelDescriptor.Equals(input.EvaluationRatingLevelDescriptor))
                ) && 
                (
                    this.MaxRating == input.MaxRating ||
                    (this.MaxRating != null &&
                    this.MaxRating.Equals(input.MaxRating))
                ) && 
                (
                    this.MinRating == input.MinRating ||
                    (this.MinRating != null &&
                    this.MinRating.Equals(input.MinRating))
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
                if (this.EvaluationRatingLevelDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationRatingLevelDescriptor.GetHashCode();
                }
                if (this.MaxRating != null)
                {
                    hashCode = (hashCode * 59) + this.MaxRating.GetHashCode();
                }
                if (this.MinRating != null)
                {
                    hashCode = (hashCode * 59) + this.MinRating.GetHashCode();
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
            // EvaluationRatingLevelDescriptor (string) maxLength
            if (this.EvaluationRatingLevelDescriptor != null && this.EvaluationRatingLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationRatingLevelDescriptor, length must be less than 306.", new [] { "EvaluationRatingLevelDescriptor" });
            }

            yield break;
        }
    }

}
