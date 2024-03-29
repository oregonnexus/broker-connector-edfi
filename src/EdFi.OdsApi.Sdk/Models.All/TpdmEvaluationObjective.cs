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
    /// TpdmEvaluationObjective
    /// </summary>
    [DataContract(Name = "tpdm_evaluationObjective")]
    public partial class TpdmEvaluationObjective : IEquatable<TpdmEvaluationObjective>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationObjective" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluationObjective() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationObjective" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="evaluationObjectiveTitle">The name or title of the evaluation Objective. (required).</param>
        /// <param name="evaluationReference">evaluationReference (required).</param>
        /// <param name="evaluationObjectiveDescription">The long description of the Evaluation Objective..</param>
        /// <param name="evaluationTypeDescriptor">The type of the evaluation Objective (e.g., observation, principal, peer, student survey, student growth)..</param>
        /// <param name="maxRating">The maximum summary numerical rating or score for the evaluation Objective..</param>
        /// <param name="minRating">The minimum summary numerical rating or score for the evaluation Objective. If omitted, assumed to be 0.0..</param>
        /// <param name="ratingLevels">An unordered collection of evaluationObjectiveRatingLevels. The descriptive level(s) of ratings (cut scores) for evaluation Objective..</param>
        /// <param name="sortOrder">The sort order of this Evaluation Objective..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public TpdmEvaluationObjective(string id = default(string), string evaluationObjectiveTitle = default(string), TpdmEvaluationReference evaluationReference = default(TpdmEvaluationReference), string evaluationObjectiveDescription = default(string), string evaluationTypeDescriptor = default(string), double? maxRating = default(double?), double? minRating = default(double?), List<TpdmEvaluationObjectiveRatingLevel> ratingLevels = default(List<TpdmEvaluationObjectiveRatingLevel>), int? sortOrder = default(int?), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "evaluationObjectiveTitle" is required (not null)
            if (evaluationObjectiveTitle == null)
            {
                throw new ArgumentNullException("evaluationObjectiveTitle is a required property for TpdmEvaluationObjective and cannot be null");
            }
            this.EvaluationObjectiveTitle = evaluationObjectiveTitle;
            // to ensure "evaluationReference" is required (not null)
            if (evaluationReference == null)
            {
                throw new ArgumentNullException("evaluationReference is a required property for TpdmEvaluationObjective and cannot be null");
            }
            this.EvaluationReference = evaluationReference;
            this.Id = id;
            this.EvaluationObjectiveDescription = evaluationObjectiveDescription;
            this.EvaluationTypeDescriptor = evaluationTypeDescriptor;
            this.MaxRating = maxRating;
            this.MinRating = minRating;
            this.RatingLevels = ratingLevels;
            this.SortOrder = sortOrder;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name or title of the evaluation Objective.
        /// </summary>
        /// <value>The name or title of the evaluation Objective.</value>
        [DataMember(Name = "evaluationObjectiveTitle", IsRequired = true, EmitDefaultValue = true)]
        public string EvaluationObjectiveTitle { get; set; }

        /// <summary>
        /// Gets or Sets EvaluationReference
        /// </summary>
        [DataMember(Name = "evaluationReference", IsRequired = true, EmitDefaultValue = true)]
        public TpdmEvaluationReference EvaluationReference { get; set; }

        /// <summary>
        /// The long description of the Evaluation Objective.
        /// </summary>
        /// <value>The long description of the Evaluation Objective.</value>
        [DataMember(Name = "evaluationObjectiveDescription", EmitDefaultValue = true)]
        public string EvaluationObjectiveDescription { get; set; }

        /// <summary>
        /// The type of the evaluation Objective (e.g., observation, principal, peer, student survey, student growth).
        /// </summary>
        /// <value>The type of the evaluation Objective (e.g., observation, principal, peer, student survey, student growth).</value>
        [DataMember(Name = "evaluationTypeDescriptor", EmitDefaultValue = true)]
        public string EvaluationTypeDescriptor { get; set; }

        /// <summary>
        /// The maximum summary numerical rating or score for the evaluation Objective.
        /// </summary>
        /// <value>The maximum summary numerical rating or score for the evaluation Objective.</value>
        [DataMember(Name = "maxRating", EmitDefaultValue = true)]
        public double? MaxRating { get; set; }

        /// <summary>
        /// The minimum summary numerical rating or score for the evaluation Objective. If omitted, assumed to be 0.0.
        /// </summary>
        /// <value>The minimum summary numerical rating or score for the evaluation Objective. If omitted, assumed to be 0.0.</value>
        [DataMember(Name = "minRating", EmitDefaultValue = true)]
        public double? MinRating { get; set; }

        /// <summary>
        /// An unordered collection of evaluationObjectiveRatingLevels. The descriptive level(s) of ratings (cut scores) for evaluation Objective.
        /// </summary>
        /// <value>An unordered collection of evaluationObjectiveRatingLevels. The descriptive level(s) of ratings (cut scores) for evaluation Objective.</value>
        [DataMember(Name = "ratingLevels", EmitDefaultValue = false)]
        public List<TpdmEvaluationObjectiveRatingLevel> RatingLevels { get; set; }

        /// <summary>
        /// The sort order of this Evaluation Objective.
        /// </summary>
        /// <value>The sort order of this Evaluation Objective.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = true)]
        public int? SortOrder { get; set; }

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
            sb.Append("class TpdmEvaluationObjective {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EvaluationObjectiveTitle: ").Append(EvaluationObjectiveTitle).Append("\n");
            sb.Append("  EvaluationReference: ").Append(EvaluationReference).Append("\n");
            sb.Append("  EvaluationObjectiveDescription: ").Append(EvaluationObjectiveDescription).Append("\n");
            sb.Append("  EvaluationTypeDescriptor: ").Append(EvaluationTypeDescriptor).Append("\n");
            sb.Append("  MaxRating: ").Append(MaxRating).Append("\n");
            sb.Append("  MinRating: ").Append(MinRating).Append("\n");
            sb.Append("  RatingLevels: ").Append(RatingLevels).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as TpdmEvaluationObjective);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationObjective instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationObjective to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationObjective input)
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
                    this.EvaluationObjectiveTitle == input.EvaluationObjectiveTitle ||
                    (this.EvaluationObjectiveTitle != null &&
                    this.EvaluationObjectiveTitle.Equals(input.EvaluationObjectiveTitle))
                ) && 
                (
                    this.EvaluationReference == input.EvaluationReference ||
                    (this.EvaluationReference != null &&
                    this.EvaluationReference.Equals(input.EvaluationReference))
                ) && 
                (
                    this.EvaluationObjectiveDescription == input.EvaluationObjectiveDescription ||
                    (this.EvaluationObjectiveDescription != null &&
                    this.EvaluationObjectiveDescription.Equals(input.EvaluationObjectiveDescription))
                ) && 
                (
                    this.EvaluationTypeDescriptor == input.EvaluationTypeDescriptor ||
                    (this.EvaluationTypeDescriptor != null &&
                    this.EvaluationTypeDescriptor.Equals(input.EvaluationTypeDescriptor))
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
                ) && 
                (
                    this.RatingLevels == input.RatingLevels ||
                    this.RatingLevels != null &&
                    input.RatingLevels != null &&
                    this.RatingLevels.SequenceEqual(input.RatingLevels)
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
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
                if (this.EvaluationObjectiveTitle != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationObjectiveTitle.GetHashCode();
                }
                if (this.EvaluationReference != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationReference.GetHashCode();
                }
                if (this.EvaluationObjectiveDescription != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationObjectiveDescription.GetHashCode();
                }
                if (this.EvaluationTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationTypeDescriptor.GetHashCode();
                }
                if (this.MaxRating != null)
                {
                    hashCode = (hashCode * 59) + this.MaxRating.GetHashCode();
                }
                if (this.MinRating != null)
                {
                    hashCode = (hashCode * 59) + this.MinRating.GetHashCode();
                }
                if (this.RatingLevels != null)
                {
                    hashCode = (hashCode * 59) + this.RatingLevels.GetHashCode();
                }
                if (this.SortOrder != null)
                {
                    hashCode = (hashCode * 59) + this.SortOrder.GetHashCode();
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
            // EvaluationObjectiveTitle (string) maxLength
            if (this.EvaluationObjectiveTitle != null && this.EvaluationObjectiveTitle.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationObjectiveTitle, length must be less than 50.", new [] { "EvaluationObjectiveTitle" });
            }

            // EvaluationObjectiveTitle (string) minLength
            if (this.EvaluationObjectiveTitle != null && this.EvaluationObjectiveTitle.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationObjectiveTitle, length must be greater than 1.", new [] { "EvaluationObjectiveTitle" });
            }

            // EvaluationObjectiveDescription (string) maxLength
            if (this.EvaluationObjectiveDescription != null && this.EvaluationObjectiveDescription.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationObjectiveDescription, length must be less than 255.", new [] { "EvaluationObjectiveDescription" });
            }

            // EvaluationTypeDescriptor (string) maxLength
            if (this.EvaluationTypeDescriptor != null && this.EvaluationTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationTypeDescriptor, length must be less than 306.", new [] { "EvaluationTypeDescriptor" });
            }

            yield break;
        }
    }

}
