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
    /// TpdmSurveySectionAggregateResponse
    /// </summary>
    [DataContract]
    public partial class TpdmSurveySectionAggregateResponse :  IEquatable<TpdmSurveySectionAggregateResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmSurveySectionAggregateResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmSurveySectionAggregateResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmSurveySectionAggregateResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="evaluationElementRatingReference">evaluationElementRatingReference (required).</param>
        /// <param name="surveySectionReference">surveySectionReference (required).</param>
        /// <param name="scoreValue">The score value for the aggregate survey section response. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmSurveySectionAggregateResponse(string id = default(string), TpdmEvaluationElementRatingReference evaluationElementRatingReference = default(TpdmEvaluationElementRatingReference), EdFiSurveySectionReference surveySectionReference = default(EdFiSurveySectionReference), double? scoreValue = default(double?), string etag = default(string))
        {
            // to ensure "evaluationElementRatingReference" is required (not null)
            if (evaluationElementRatingReference == null)
            {
                throw new InvalidDataException("evaluationElementRatingReference is a required property for TpdmSurveySectionAggregateResponse and cannot be null");
            }
            else
            {
                this.EvaluationElementRatingReference = evaluationElementRatingReference;
            }
            // to ensure "surveySectionReference" is required (not null)
            if (surveySectionReference == null)
            {
                throw new InvalidDataException("surveySectionReference is a required property for TpdmSurveySectionAggregateResponse and cannot be null");
            }
            else
            {
                this.SurveySectionReference = surveySectionReference;
            }
            // to ensure "scoreValue" is required (not null)
            if (scoreValue == null)
            {
                throw new InvalidDataException("scoreValue is a required property for TpdmSurveySectionAggregateResponse and cannot be null");
            }
            else
            {
                this.ScoreValue = scoreValue;
            }
            this.Id = id;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EvaluationElementRatingReference
        /// </summary>
        [DataMember(Name="evaluationElementRatingReference", EmitDefaultValue=false)]
        public TpdmEvaluationElementRatingReference EvaluationElementRatingReference { get; set; }

        /// <summary>
        /// Gets or Sets SurveySectionReference
        /// </summary>
        [DataMember(Name="surveySectionReference", EmitDefaultValue=false)]
        public EdFiSurveySectionReference SurveySectionReference { get; set; }

        /// <summary>
        /// The score value for the aggregate survey section response.
        /// </summary>
        /// <value>The score value for the aggregate survey section response.</value>
        [DataMember(Name="scoreValue", EmitDefaultValue=false)]
        public double? ScoreValue { get; set; }

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
            sb.Append("class TpdmSurveySectionAggregateResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EvaluationElementRatingReference: ").Append(EvaluationElementRatingReference).Append("\n");
            sb.Append("  SurveySectionReference: ").Append(SurveySectionReference).Append("\n");
            sb.Append("  ScoreValue: ").Append(ScoreValue).Append("\n");
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
            return this.Equals(input as TpdmSurveySectionAggregateResponse);
        }

        /// <summary>
        /// Returns true if TpdmSurveySectionAggregateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmSurveySectionAggregateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmSurveySectionAggregateResponse input)
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
                    this.EvaluationElementRatingReference == input.EvaluationElementRatingReference ||
                    (this.EvaluationElementRatingReference != null &&
                    this.EvaluationElementRatingReference.Equals(input.EvaluationElementRatingReference))
                ) && 
                (
                    this.SurveySectionReference == input.SurveySectionReference ||
                    (this.SurveySectionReference != null &&
                    this.SurveySectionReference.Equals(input.SurveySectionReference))
                ) && 
                (
                    this.ScoreValue == input.ScoreValue ||
                    (this.ScoreValue != null &&
                    this.ScoreValue.Equals(input.ScoreValue))
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
                if (this.EvaluationElementRatingReference != null)
                    hashCode = hashCode * 59 + this.EvaluationElementRatingReference.GetHashCode();
                if (this.SurveySectionReference != null)
                    hashCode = hashCode * 59 + this.SurveySectionReference.GetHashCode();
                if (this.ScoreValue != null)
                    hashCode = hashCode * 59 + this.ScoreValue.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
