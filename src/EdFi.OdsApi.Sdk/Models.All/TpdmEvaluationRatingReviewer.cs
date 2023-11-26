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
    /// TpdmEvaluationRatingReviewer
    /// </summary>
    [DataContract(Name = "tpdm_evaluationRatingReviewer")]
    public partial class TpdmEvaluationRatingReviewer : IEquatable<TpdmEvaluationRatingReviewer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationRatingReviewer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluationRatingReviewer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationRatingReviewer" /> class.
        /// </summary>
        /// <param name="firstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (required).</param>
        /// <param name="lastSurname">The name borne in common by members of a family. (required).</param>
        /// <param name="reviewerPersonReference">reviewerPersonReference.</param>
        /// <param name="receivedTraining">receivedTraining.</param>
        public TpdmEvaluationRatingReviewer(string firstName = default(string), string lastSurname = default(string), EdFiPersonReference reviewerPersonReference = default(EdFiPersonReference), TpdmEvaluationRatingReviewerReceivedTraining receivedTraining = default(TpdmEvaluationRatingReviewerReceivedTraining))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for TpdmEvaluationRatingReviewer and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastSurname" is required (not null)
            if (lastSurname == null)
            {
                throw new ArgumentNullException("lastSurname is a required property for TpdmEvaluationRatingReviewer and cannot be null");
            }
            this.LastSurname = lastSurname;
            this.ReviewerPersonReference = reviewerPersonReference;
            this.ReceivedTraining = receivedTraining;
        }

        /// <summary>
        /// A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.
        /// </summary>
        /// <value>A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.</value>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The name borne in common by members of a family.
        /// </summary>
        /// <value>The name borne in common by members of a family.</value>
        [DataMember(Name = "lastSurname", IsRequired = true, EmitDefaultValue = true)]
        public string LastSurname { get; set; }

        /// <summary>
        /// Gets or Sets ReviewerPersonReference
        /// </summary>
        [DataMember(Name = "reviewerPersonReference", EmitDefaultValue = false)]
        public EdFiPersonReference ReviewerPersonReference { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedTraining
        /// </summary>
        [DataMember(Name = "receivedTraining", EmitDefaultValue = false)]
        public TpdmEvaluationRatingReviewerReceivedTraining ReceivedTraining { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TpdmEvaluationRatingReviewer {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastSurname: ").Append(LastSurname).Append("\n");
            sb.Append("  ReviewerPersonReference: ").Append(ReviewerPersonReference).Append("\n");
            sb.Append("  ReceivedTraining: ").Append(ReceivedTraining).Append("\n");
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
            return this.Equals(input as TpdmEvaluationRatingReviewer);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationRatingReviewer instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationRatingReviewer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationRatingReviewer input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastSurname == input.LastSurname ||
                    (this.LastSurname != null &&
                    this.LastSurname.Equals(input.LastSurname))
                ) && 
                (
                    this.ReviewerPersonReference == input.ReviewerPersonReference ||
                    (this.ReviewerPersonReference != null &&
                    this.ReviewerPersonReference.Equals(input.ReviewerPersonReference))
                ) && 
                (
                    this.ReceivedTraining == input.ReceivedTraining ||
                    (this.ReceivedTraining != null &&
                    this.ReceivedTraining.Equals(input.ReceivedTraining))
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
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastSurname != null)
                {
                    hashCode = (hashCode * 59) + this.LastSurname.GetHashCode();
                }
                if (this.ReviewerPersonReference != null)
                {
                    hashCode = (hashCode * 59) + this.ReviewerPersonReference.GetHashCode();
                }
                if (this.ReceivedTraining != null)
                {
                    hashCode = (hashCode * 59) + this.ReceivedTraining.GetHashCode();
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
            // FirstName (string) maxLength
            if (this.FirstName != null && this.FirstName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 75.", new [] { "FirstName" });
            }

            // FirstName (string) minLength
            if (this.FirstName != null && this.FirstName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be greater than 1.", new [] { "FirstName" });
            }

            // LastSurname (string) maxLength
            if (this.LastSurname != null && this.LastSurname.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastSurname, length must be less than 75.", new [] { "LastSurname" });
            }

            // LastSurname (string) minLength
            if (this.LastSurname != null && this.LastSurname.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastSurname, length must be greater than 1.", new [] { "LastSurname" });
            }

            yield break;
        }
    }

}
