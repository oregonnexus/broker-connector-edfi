/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Resources
{
    /// <summary>
    /// TpdmEvaluation
    /// </summary>
    [DataContract]
    public partial class TpdmEvaluation :  IEquatable<TpdmEvaluation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="evaluationTitle">The name or title of the evaluation. (required).</param>
        /// <param name="performanceEvaluationReference">performanceEvaluationReference (required).</param>
        /// <param name="evaluationTypeDescriptor">The type of the evaluation (e.g., observation, principal, peer, student survey, student growth)..</param>
        /// <param name="interRaterReliabilityScore">A score indicating how much homogeneity, or consensus, there is in the ratings given by judges..</param>
        /// <param name="maxRating">The maximum summary numerical rating or score for the evaluation..</param>
        /// <param name="minRating">The minimum summary numerical rating or score for the evaluation. If omitted, assumed to be 0.0..</param>
        /// <param name="ratingLevels">An unordered collection of evaluationRatingLevels. The descriptive level(s) of ratings (cut scores) for the evaluation..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmEvaluation(string id = default(string), string evaluationTitle = default(string), TpdmPerformanceEvaluationReference performanceEvaluationReference = default(TpdmPerformanceEvaluationReference), string evaluationTypeDescriptor = default(string), int? interRaterReliabilityScore = default(int?), double? maxRating = default(double?), double? minRating = default(double?), List<TpdmEvaluationRatingLevel> ratingLevels = default(List<TpdmEvaluationRatingLevel>), string etag = default(string))
        {
            // to ensure "evaluationTitle" is required (not null)
            if (evaluationTitle == null)
            {
                throw new InvalidDataException("evaluationTitle is a required property for TpdmEvaluation and cannot be null");
            }
            else
            {
                this.EvaluationTitle = evaluationTitle;
            }
            // to ensure "performanceEvaluationReference" is required (not null)
            if (performanceEvaluationReference == null)
            {
                throw new InvalidDataException("performanceEvaluationReference is a required property for TpdmEvaluation and cannot be null");
            }
            else
            {
                this.PerformanceEvaluationReference = performanceEvaluationReference;
            }
            this.Id = id;
            this.EvaluationTypeDescriptor = evaluationTypeDescriptor;
            this.InterRaterReliabilityScore = interRaterReliabilityScore;
            this.MaxRating = maxRating;
            this.MinRating = minRating;
            this.RatingLevels = ratingLevels;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name or title of the evaluation.
        /// </summary>
        /// <value>The name or title of the evaluation.</value>
        [DataMember(Name="evaluationTitle", EmitDefaultValue=false)]
        public string EvaluationTitle { get; set; }

        /// <summary>
        /// Gets or Sets PerformanceEvaluationReference
        /// </summary>
        [DataMember(Name="performanceEvaluationReference", EmitDefaultValue=false)]
        public TpdmPerformanceEvaluationReference PerformanceEvaluationReference { get; set; }

        /// <summary>
        /// The type of the evaluation (e.g., observation, principal, peer, student survey, student growth).
        /// </summary>
        /// <value>The type of the evaluation (e.g., observation, principal, peer, student survey, student growth).</value>
        [DataMember(Name="evaluationTypeDescriptor", EmitDefaultValue=false)]
        public string EvaluationTypeDescriptor { get; set; }

        /// <summary>
        /// A score indicating how much homogeneity, or consensus, there is in the ratings given by judges.
        /// </summary>
        /// <value>A score indicating how much homogeneity, or consensus, there is in the ratings given by judges.</value>
        [DataMember(Name="interRaterReliabilityScore", EmitDefaultValue=false)]
        public int? InterRaterReliabilityScore { get; set; }

        /// <summary>
        /// The maximum summary numerical rating or score for the evaluation.
        /// </summary>
        /// <value>The maximum summary numerical rating or score for the evaluation.</value>
        [DataMember(Name="maxRating", EmitDefaultValue=false)]
        public double? MaxRating { get; set; }

        /// <summary>
        /// The minimum summary numerical rating or score for the evaluation. If omitted, assumed to be 0.0.
        /// </summary>
        /// <value>The minimum summary numerical rating or score for the evaluation. If omitted, assumed to be 0.0.</value>
        [DataMember(Name="minRating", EmitDefaultValue=false)]
        public double? MinRating { get; set; }

        /// <summary>
        /// An unordered collection of evaluationRatingLevels. The descriptive level(s) of ratings (cut scores) for the evaluation.
        /// </summary>
        /// <value>An unordered collection of evaluationRatingLevels. The descriptive level(s) of ratings (cut scores) for the evaluation.</value>
        [DataMember(Name="ratingLevels", EmitDefaultValue=false)]
        public List<TpdmEvaluationRatingLevel> RatingLevels { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmEvaluation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EvaluationTitle: ").Append(EvaluationTitle).Append("\n");
            sb.Append("  PerformanceEvaluationReference: ").Append(PerformanceEvaluationReference).Append("\n");
            sb.Append("  EvaluationTypeDescriptor: ").Append(EvaluationTypeDescriptor).Append("\n");
            sb.Append("  InterRaterReliabilityScore: ").Append(InterRaterReliabilityScore).Append("\n");
            sb.Append("  MaxRating: ").Append(MaxRating).Append("\n");
            sb.Append("  MinRating: ").Append(MinRating).Append("\n");
            sb.Append("  RatingLevels: ").Append(RatingLevels).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TpdmEvaluation);
        }

        /// <summary>
        /// Returns true if TpdmEvaluation instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EvaluationTitle == input.EvaluationTitle ||
                    (this.EvaluationTitle != null &&
                    this.EvaluationTitle.Equals(input.EvaluationTitle))
                ) && 
                (
                    this.PerformanceEvaluationReference == input.PerformanceEvaluationReference ||
                    (this.PerformanceEvaluationReference != null &&
                    this.PerformanceEvaluationReference.Equals(input.PerformanceEvaluationReference))
                ) && 
                (
                    this.EvaluationTypeDescriptor == input.EvaluationTypeDescriptor ||
                    (this.EvaluationTypeDescriptor != null &&
                    this.EvaluationTypeDescriptor.Equals(input.EvaluationTypeDescriptor))
                ) && 
                (
                    this.InterRaterReliabilityScore == input.InterRaterReliabilityScore ||
                    (this.InterRaterReliabilityScore != null &&
                    this.InterRaterReliabilityScore.Equals(input.InterRaterReliabilityScore))
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
                    this.RatingLevels.SequenceEqual(input.RatingLevels)
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EvaluationTitle != null)
                    hashCode = hashCode * 59 + this.EvaluationTitle.GetHashCode();
                if (this.PerformanceEvaluationReference != null)
                    hashCode = hashCode * 59 + this.PerformanceEvaluationReference.GetHashCode();
                if (this.EvaluationTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.EvaluationTypeDescriptor.GetHashCode();
                if (this.InterRaterReliabilityScore != null)
                    hashCode = hashCode * 59 + this.InterRaterReliabilityScore.GetHashCode();
                if (this.MaxRating != null)
                    hashCode = hashCode * 59 + this.MaxRating.GetHashCode();
                if (this.MinRating != null)
                    hashCode = hashCode * 59 + this.MinRating.GetHashCode();
                if (this.RatingLevels != null)
                    hashCode = hashCode * 59 + this.RatingLevels.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
