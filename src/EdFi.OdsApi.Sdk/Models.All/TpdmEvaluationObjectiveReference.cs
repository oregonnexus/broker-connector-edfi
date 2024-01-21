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
    /// TpdmEvaluationObjectiveReference
    /// </summary>
    [DataContract(Name = "tpdm_evaluationObjectiveReference")]
    public partial class TpdmEvaluationObjectiveReference : IEquatable<TpdmEvaluationObjectiveReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationObjectiveReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluationObjectiveReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationObjectiveReference" /> class.
        /// </summary>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="evaluationObjectiveTitle">The name or title of the evaluation Objective. (required).</param>
        /// <param name="evaluationPeriodDescriptor">The period for the evaluation. (required).</param>
        /// <param name="evaluationTitle">The name or title of the evaluation. (required).</param>
        /// <param name="performanceEvaluationTitle">An assigned unique identifier for the performance evaluation. (required).</param>
        /// <param name="performanceEvaluationTypeDescriptor">The type of performance evaluation conducted. (required).</param>
        /// <param name="schoolYear">The identifier for the school year. (required).</param>
        /// <param name="termDescriptor">The term for the session during the school year. (required).</param>
        /// <param name="link">link.</param>
        public TpdmEvaluationObjectiveReference(long educationOrganizationId = default(long), string evaluationObjectiveTitle = default(string), string evaluationPeriodDescriptor = default(string), string evaluationTitle = default(string), string performanceEvaluationTitle = default(string), string performanceEvaluationTypeDescriptor = default(string), int schoolYear = default(int), string termDescriptor = default(string), Link link = default(Link))
        {
            this.EducationOrganizationId = educationOrganizationId;
            // to ensure "evaluationObjectiveTitle" is required (not null)
            if (evaluationObjectiveTitle == null)
            {
                throw new ArgumentNullException("evaluationObjectiveTitle is a required property for TpdmEvaluationObjectiveReference and cannot be null");
            }
            this.EvaluationObjectiveTitle = evaluationObjectiveTitle;
            // to ensure "evaluationPeriodDescriptor" is required (not null)
            if (evaluationPeriodDescriptor == null)
            {
                throw new ArgumentNullException("evaluationPeriodDescriptor is a required property for TpdmEvaluationObjectiveReference and cannot be null");
            }
            this.EvaluationPeriodDescriptor = evaluationPeriodDescriptor;
            // to ensure "evaluationTitle" is required (not null)
            if (evaluationTitle == null)
            {
                throw new ArgumentNullException("evaluationTitle is a required property for TpdmEvaluationObjectiveReference and cannot be null");
            }
            this.EvaluationTitle = evaluationTitle;
            // to ensure "performanceEvaluationTitle" is required (not null)
            if (performanceEvaluationTitle == null)
            {
                throw new ArgumentNullException("performanceEvaluationTitle is a required property for TpdmEvaluationObjectiveReference and cannot be null");
            }
            this.PerformanceEvaluationTitle = performanceEvaluationTitle;
            // to ensure "performanceEvaluationTypeDescriptor" is required (not null)
            if (performanceEvaluationTypeDescriptor == null)
            {
                throw new ArgumentNullException("performanceEvaluationTypeDescriptor is a required property for TpdmEvaluationObjectiveReference and cannot be null");
            }
            this.PerformanceEvaluationTypeDescriptor = performanceEvaluationTypeDescriptor;
            this.SchoolYear = schoolYear;
            // to ensure "termDescriptor" is required (not null)
            if (termDescriptor == null)
            {
                throw new ArgumentNullException("termDescriptor is a required property for TpdmEvaluationObjectiveReference and cannot be null");
            }
            this.TermDescriptor = termDescriptor;
            this.Link = link;
        }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", IsRequired = true, EmitDefaultValue = true)]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// The name or title of the evaluation Objective.
        /// </summary>
        /// <value>The name or title of the evaluation Objective.</value>
        [DataMember(Name = "evaluationObjectiveTitle", IsRequired = true, EmitDefaultValue = true)]
        public string EvaluationObjectiveTitle { get; set; }

        /// <summary>
        /// The period for the evaluation.
        /// </summary>
        /// <value>The period for the evaluation.</value>
        [DataMember(Name = "evaluationPeriodDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string EvaluationPeriodDescriptor { get; set; }

        /// <summary>
        /// The name or title of the evaluation.
        /// </summary>
        /// <value>The name or title of the evaluation.</value>
        [DataMember(Name = "evaluationTitle", IsRequired = true, EmitDefaultValue = true)]
        public string EvaluationTitle { get; set; }

        /// <summary>
        /// An assigned unique identifier for the performance evaluation.
        /// </summary>
        /// <value>An assigned unique identifier for the performance evaluation.</value>
        [DataMember(Name = "performanceEvaluationTitle", IsRequired = true, EmitDefaultValue = true)]
        public string PerformanceEvaluationTitle { get; set; }

        /// <summary>
        /// The type of performance evaluation conducted.
        /// </summary>
        /// <value>The type of performance evaluation conducted.</value>
        [DataMember(Name = "performanceEvaluationTypeDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string PerformanceEvaluationTypeDescriptor { get; set; }

        /// <summary>
        /// The identifier for the school year.
        /// </summary>
        /// <value>The identifier for the school year.</value>
        [DataMember(Name = "schoolYear", IsRequired = true, EmitDefaultValue = true)]
        public int SchoolYear { get; set; }

        /// <summary>
        /// The term for the session during the school year.
        /// </summary>
        /// <value>The term for the session during the school year.</value>
        [DataMember(Name = "termDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string TermDescriptor { get; set; }

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
            sb.Append("class TpdmEvaluationObjectiveReference {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  EvaluationObjectiveTitle: ").Append(EvaluationObjectiveTitle).Append("\n");
            sb.Append("  EvaluationPeriodDescriptor: ").Append(EvaluationPeriodDescriptor).Append("\n");
            sb.Append("  EvaluationTitle: ").Append(EvaluationTitle).Append("\n");
            sb.Append("  PerformanceEvaluationTitle: ").Append(PerformanceEvaluationTitle).Append("\n");
            sb.Append("  PerformanceEvaluationTypeDescriptor: ").Append(PerformanceEvaluationTypeDescriptor).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
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
            return this.Equals(input as TpdmEvaluationObjectiveReference);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationObjectiveReference instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationObjectiveReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationObjectiveReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId)
                ) && 
                (
                    this.EvaluationObjectiveTitle == input.EvaluationObjectiveTitle ||
                    (this.EvaluationObjectiveTitle != null &&
                    this.EvaluationObjectiveTitle.Equals(input.EvaluationObjectiveTitle))
                ) && 
                (
                    this.EvaluationPeriodDescriptor == input.EvaluationPeriodDescriptor ||
                    (this.EvaluationPeriodDescriptor != null &&
                    this.EvaluationPeriodDescriptor.Equals(input.EvaluationPeriodDescriptor))
                ) && 
                (
                    this.EvaluationTitle == input.EvaluationTitle ||
                    (this.EvaluationTitle != null &&
                    this.EvaluationTitle.Equals(input.EvaluationTitle))
                ) && 
                (
                    this.PerformanceEvaluationTitle == input.PerformanceEvaluationTitle ||
                    (this.PerformanceEvaluationTitle != null &&
                    this.PerformanceEvaluationTitle.Equals(input.PerformanceEvaluationTitle))
                ) && 
                (
                    this.PerformanceEvaluationTypeDescriptor == input.PerformanceEvaluationTypeDescriptor ||
                    (this.PerformanceEvaluationTypeDescriptor != null &&
                    this.PerformanceEvaluationTypeDescriptor.Equals(input.PerformanceEvaluationTypeDescriptor))
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    this.SchoolYear.Equals(input.SchoolYear)
                ) && 
                (
                    this.TermDescriptor == input.TermDescriptor ||
                    (this.TermDescriptor != null &&
                    this.TermDescriptor.Equals(input.TermDescriptor))
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
                hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
                if (this.EvaluationObjectiveTitle != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationObjectiveTitle.GetHashCode();
                }
                if (this.EvaluationPeriodDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationPeriodDescriptor.GetHashCode();
                }
                if (this.EvaluationTitle != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationTitle.GetHashCode();
                }
                if (this.PerformanceEvaluationTitle != null)
                {
                    hashCode = (hashCode * 59) + this.PerformanceEvaluationTitle.GetHashCode();
                }
                if (this.PerformanceEvaluationTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.PerformanceEvaluationTypeDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchoolYear.GetHashCode();
                if (this.TermDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.TermDescriptor.GetHashCode();
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

            // EvaluationPeriodDescriptor (string) maxLength
            if (this.EvaluationPeriodDescriptor != null && this.EvaluationPeriodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationPeriodDescriptor, length must be less than 306.", new [] { "EvaluationPeriodDescriptor" });
            }

            // EvaluationTitle (string) maxLength
            if (this.EvaluationTitle != null && this.EvaluationTitle.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationTitle, length must be less than 50.", new [] { "EvaluationTitle" });
            }

            // EvaluationTitle (string) minLength
            if (this.EvaluationTitle != null && this.EvaluationTitle.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationTitle, length must be greater than 1.", new [] { "EvaluationTitle" });
            }

            // PerformanceEvaluationTitle (string) maxLength
            if (this.PerformanceEvaluationTitle != null && this.PerformanceEvaluationTitle.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerformanceEvaluationTitle, length must be less than 50.", new [] { "PerformanceEvaluationTitle" });
            }

            // PerformanceEvaluationTitle (string) minLength
            if (this.PerformanceEvaluationTitle != null && this.PerformanceEvaluationTitle.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerformanceEvaluationTitle, length must be greater than 1.", new [] { "PerformanceEvaluationTitle" });
            }

            // PerformanceEvaluationTypeDescriptor (string) maxLength
            if (this.PerformanceEvaluationTypeDescriptor != null && this.PerformanceEvaluationTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerformanceEvaluationTypeDescriptor, length must be less than 306.", new [] { "PerformanceEvaluationTypeDescriptor" });
            }

            // TermDescriptor (string) maxLength
            if (this.TermDescriptor != null && this.TermDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TermDescriptor, length must be less than 306.", new [] { "TermDescriptor" });
            }

            yield break;
        }
    }

}
