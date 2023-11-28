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
    /// TpdmPerformanceEvaluationRating
    /// </summary>
    [DataContract(Name = "tpdm_performanceEvaluationRating")]
    public partial class TpdmPerformanceEvaluationRating : IEquatable<TpdmPerformanceEvaluationRating>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmPerformanceEvaluationRating" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmPerformanceEvaluationRating() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmPerformanceEvaluationRating" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="performanceEvaluationReference">performanceEvaluationReference (required).</param>
        /// <param name="personReference">personReference (required).</param>
        /// <param name="actualDate">The month, day, and year on which the performance evaluation was conducted. (required).</param>
        /// <param name="actualDuration">The actual or estimated number of clock minutes during which the performance evaluation was conducted..</param>
        /// <param name="actualTime">An indication of the the time at which the performance evaluation was conducted..</param>
        /// <param name="announced">An indicator of whether the performance evaluation was announced or not..</param>
        /// <param name="comments">Any comments about the performance evaluation to be captured..</param>
        /// <param name="coteachingStyleObservedDescriptor">A type of co-teaching observed as part of the performance evaluation..</param>
        /// <param name="performanceEvaluationRatingLevelDescriptor">The rating level achieved based upon the rating or score..</param>
        /// <param name="results">An unordered collection of performanceEvaluationRatingResults. The numerical summary rating or score for the performance evaluation..</param>
        /// <param name="reviewers">An unordered collection of performanceEvaluationRatingReviewers. The person(s) that conducted the performance evaluation..</param>
        /// <param name="scheduleDate">The month, day, and year on which the performance evaluation was scheduled..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public TpdmPerformanceEvaluationRating(string id = default(string), TpdmPerformanceEvaluationReference performanceEvaluationReference = default(TpdmPerformanceEvaluationReference), EdFiPersonReference personReference = default(EdFiPersonReference), DateTime actualDate = default(DateTime), int? actualDuration = default(int?), string actualTime = default(string), bool? announced = default(bool?), string comments = default(string), string coteachingStyleObservedDescriptor = default(string), string performanceEvaluationRatingLevelDescriptor = default(string), List<TpdmPerformanceEvaluationRatingResult> results = default(List<TpdmPerformanceEvaluationRatingResult>), List<TpdmPerformanceEvaluationRatingReviewer> reviewers = default(List<TpdmPerformanceEvaluationRatingReviewer>), DateTime? scheduleDate = default(DateTime?), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "performanceEvaluationReference" is required (not null)
            if (performanceEvaluationReference == null)
            {
                throw new ArgumentNullException("performanceEvaluationReference is a required property for TpdmPerformanceEvaluationRating and cannot be null");
            }
            this.PerformanceEvaluationReference = performanceEvaluationReference;
            // to ensure "personReference" is required (not null)
            if (personReference == null)
            {
                throw new ArgumentNullException("personReference is a required property for TpdmPerformanceEvaluationRating and cannot be null");
            }
            this.PersonReference = personReference;
            this.ActualDate = actualDate;
            this.Id = id;
            this.ActualDuration = actualDuration;
            this.ActualTime = actualTime;
            this.Announced = announced;
            this.Comments = comments;
            this.CoteachingStyleObservedDescriptor = coteachingStyleObservedDescriptor;
            this.PerformanceEvaluationRatingLevelDescriptor = performanceEvaluationRatingLevelDescriptor;
            this.Results = results;
            this.Reviewers = reviewers;
            this.ScheduleDate = scheduleDate;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PerformanceEvaluationReference
        /// </summary>
        [DataMember(Name = "performanceEvaluationReference", IsRequired = true, EmitDefaultValue = true)]
        public TpdmPerformanceEvaluationReference PerformanceEvaluationReference { get; set; }

        /// <summary>
        /// Gets or Sets PersonReference
        /// </summary>
        [DataMember(Name = "personReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiPersonReference PersonReference { get; set; }

        /// <summary>
        /// The month, day, and year on which the performance evaluation was conducted.
        /// </summary>
        /// <value>The month, day, and year on which the performance evaluation was conducted.</value>
        [DataMember(Name = "actualDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ActualDate { get; set; }

        /// <summary>
        /// The actual or estimated number of clock minutes during which the performance evaluation was conducted.
        /// </summary>
        /// <value>The actual or estimated number of clock minutes during which the performance evaluation was conducted.</value>
        [DataMember(Name = "actualDuration", EmitDefaultValue = true)]
        public int? ActualDuration { get; set; }

        /// <summary>
        /// An indication of the the time at which the performance evaluation was conducted.
        /// </summary>
        /// <value>An indication of the the time at which the performance evaluation was conducted.</value>
        [DataMember(Name = "actualTime", EmitDefaultValue = true)]
        public string ActualTime { get; set; }

        /// <summary>
        /// An indicator of whether the performance evaluation was announced or not.
        /// </summary>
        /// <value>An indicator of whether the performance evaluation was announced or not.</value>
        [DataMember(Name = "announced", EmitDefaultValue = true)]
        public bool? Announced { get; set; }

        /// <summary>
        /// Any comments about the performance evaluation to be captured.
        /// </summary>
        /// <value>Any comments about the performance evaluation to be captured.</value>
        [DataMember(Name = "comments", EmitDefaultValue = true)]
        public string Comments { get; set; }

        /// <summary>
        /// A type of co-teaching observed as part of the performance evaluation.
        /// </summary>
        /// <value>A type of co-teaching observed as part of the performance evaluation.</value>
        [DataMember(Name = "coteachingStyleObservedDescriptor", EmitDefaultValue = true)]
        public string CoteachingStyleObservedDescriptor { get; set; }

        /// <summary>
        /// The rating level achieved based upon the rating or score.
        /// </summary>
        /// <value>The rating level achieved based upon the rating or score.</value>
        [DataMember(Name = "performanceEvaluationRatingLevelDescriptor", EmitDefaultValue = true)]
        public string PerformanceEvaluationRatingLevelDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of performanceEvaluationRatingResults. The numerical summary rating or score for the performance evaluation.
        /// </summary>
        /// <value>An unordered collection of performanceEvaluationRatingResults. The numerical summary rating or score for the performance evaluation.</value>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<TpdmPerformanceEvaluationRatingResult> Results { get; set; }

        /// <summary>
        /// An unordered collection of performanceEvaluationRatingReviewers. The person(s) that conducted the performance evaluation.
        /// </summary>
        /// <value>An unordered collection of performanceEvaluationRatingReviewers. The person(s) that conducted the performance evaluation.</value>
        [DataMember(Name = "reviewers", EmitDefaultValue = false)]
        public List<TpdmPerformanceEvaluationRatingReviewer> Reviewers { get; set; }

        /// <summary>
        /// The month, day, and year on which the performance evaluation was scheduled.
        /// </summary>
        /// <value>The month, day, and year on which the performance evaluation was scheduled.</value>
        [DataMember(Name = "scheduleDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ScheduleDate { get; set; }

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
            sb.Append("class TpdmPerformanceEvaluationRating {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PerformanceEvaluationReference: ").Append(PerformanceEvaluationReference).Append("\n");
            sb.Append("  PersonReference: ").Append(PersonReference).Append("\n");
            sb.Append("  ActualDate: ").Append(ActualDate).Append("\n");
            sb.Append("  ActualDuration: ").Append(ActualDuration).Append("\n");
            sb.Append("  ActualTime: ").Append(ActualTime).Append("\n");
            sb.Append("  Announced: ").Append(Announced).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CoteachingStyleObservedDescriptor: ").Append(CoteachingStyleObservedDescriptor).Append("\n");
            sb.Append("  PerformanceEvaluationRatingLevelDescriptor: ").Append(PerformanceEvaluationRatingLevelDescriptor).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
            sb.Append("  ScheduleDate: ").Append(ScheduleDate).Append("\n");
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
            return this.Equals(input as TpdmPerformanceEvaluationRating);
        }

        /// <summary>
        /// Returns true if TpdmPerformanceEvaluationRating instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmPerformanceEvaluationRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmPerformanceEvaluationRating input)
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
                    this.PerformanceEvaluationReference == input.PerformanceEvaluationReference ||
                    (this.PerformanceEvaluationReference != null &&
                    this.PerformanceEvaluationReference.Equals(input.PerformanceEvaluationReference))
                ) && 
                (
                    this.PersonReference == input.PersonReference ||
                    (this.PersonReference != null &&
                    this.PersonReference.Equals(input.PersonReference))
                ) && 
                (
                    this.ActualDate == input.ActualDate ||
                    (this.ActualDate != null &&
                    this.ActualDate.Equals(input.ActualDate))
                ) && 
                (
                    this.ActualDuration == input.ActualDuration ||
                    (this.ActualDuration != null &&
                    this.ActualDuration.Equals(input.ActualDuration))
                ) && 
                (
                    this.ActualTime == input.ActualTime ||
                    (this.ActualTime != null &&
                    this.ActualTime.Equals(input.ActualTime))
                ) && 
                (
                    this.Announced == input.Announced ||
                    (this.Announced != null &&
                    this.Announced.Equals(input.Announced))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.CoteachingStyleObservedDescriptor == input.CoteachingStyleObservedDescriptor ||
                    (this.CoteachingStyleObservedDescriptor != null &&
                    this.CoteachingStyleObservedDescriptor.Equals(input.CoteachingStyleObservedDescriptor))
                ) && 
                (
                    this.PerformanceEvaluationRatingLevelDescriptor == input.PerformanceEvaluationRatingLevelDescriptor ||
                    (this.PerformanceEvaluationRatingLevelDescriptor != null &&
                    this.PerformanceEvaluationRatingLevelDescriptor.Equals(input.PerformanceEvaluationRatingLevelDescriptor))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.Reviewers == input.Reviewers ||
                    this.Reviewers != null &&
                    input.Reviewers != null &&
                    this.Reviewers.SequenceEqual(input.Reviewers)
                ) && 
                (
                    this.ScheduleDate == input.ScheduleDate ||
                    (this.ScheduleDate != null &&
                    this.ScheduleDate.Equals(input.ScheduleDate))
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
                if (this.PerformanceEvaluationReference != null)
                {
                    hashCode = (hashCode * 59) + this.PerformanceEvaluationReference.GetHashCode();
                }
                if (this.PersonReference != null)
                {
                    hashCode = (hashCode * 59) + this.PersonReference.GetHashCode();
                }
                if (this.ActualDate != null)
                {
                    hashCode = (hashCode * 59) + this.ActualDate.GetHashCode();
                }
                if (this.ActualDuration != null)
                {
                    hashCode = (hashCode * 59) + this.ActualDuration.GetHashCode();
                }
                if (this.ActualTime != null)
                {
                    hashCode = (hashCode * 59) + this.ActualTime.GetHashCode();
                }
                if (this.Announced != null)
                {
                    hashCode = (hashCode * 59) + this.Announced.GetHashCode();
                }
                if (this.Comments != null)
                {
                    hashCode = (hashCode * 59) + this.Comments.GetHashCode();
                }
                if (this.CoteachingStyleObservedDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.CoteachingStyleObservedDescriptor.GetHashCode();
                }
                if (this.PerformanceEvaluationRatingLevelDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.PerformanceEvaluationRatingLevelDescriptor.GetHashCode();
                }
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
                }
                if (this.Reviewers != null)
                {
                    hashCode = (hashCode * 59) + this.Reviewers.GetHashCode();
                }
                if (this.ScheduleDate != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduleDate.GetHashCode();
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
            // ActualDuration (int?) minimum
            if (this.ActualDuration < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActualDuration, must be a value greater than or equal to 1.", new [] { "ActualDuration" });
            }

            // Comments (string) maxLength
            if (this.Comments != null && this.Comments.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comments, length must be less than 1024.", new [] { "Comments" });
            }

            // Comments (string) minLength
            if (this.Comments != null && this.Comments.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comments, length must be greater than 1.", new [] { "Comments" });
            }

            // CoteachingStyleObservedDescriptor (string) maxLength
            if (this.CoteachingStyleObservedDescriptor != null && this.CoteachingStyleObservedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CoteachingStyleObservedDescriptor, length must be less than 306.", new [] { "CoteachingStyleObservedDescriptor" });
            }

            // PerformanceEvaluationRatingLevelDescriptor (string) maxLength
            if (this.PerformanceEvaluationRatingLevelDescriptor != null && this.PerformanceEvaluationRatingLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerformanceEvaluationRatingLevelDescriptor, length must be less than 306.", new [] { "PerformanceEvaluationRatingLevelDescriptor" });
            }

            yield break;
        }
    }

}
