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
    /// TpdmCandidateEducatorPreparationProgramAssociationCohortYear
    /// </summary>
    [DataContract(Name = "tpdm_candidateEducatorPreparationProgramAssociationCohortYear")]
    public partial class TpdmCandidateEducatorPreparationProgramAssociationCohortYear : IEquatable<TpdmCandidateEducatorPreparationProgramAssociationCohortYear>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidateEducatorPreparationProgramAssociationCohortYear" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmCandidateEducatorPreparationProgramAssociationCohortYear() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidateEducatorPreparationProgramAssociationCohortYear" /> class.
        /// </summary>
        /// <param name="cohortYearTypeDescriptor">The type of cohort year (9th grade, graduation). (required).</param>
        /// <param name="termDescriptor">The term associated with the cohort year; for example, the intended term of graduation..</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference (required).</param>
        public TpdmCandidateEducatorPreparationProgramAssociationCohortYear(string cohortYearTypeDescriptor = default(string), string termDescriptor = default(string), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference))
        {
            // to ensure "cohortYearTypeDescriptor" is required (not null)
            if (cohortYearTypeDescriptor == null)
            {
                throw new ArgumentNullException("cohortYearTypeDescriptor is a required property for TpdmCandidateEducatorPreparationProgramAssociationCohortYear and cannot be null");
            }
            this.CohortYearTypeDescriptor = cohortYearTypeDescriptor;
            // to ensure "schoolYearTypeReference" is required (not null)
            if (schoolYearTypeReference == null)
            {
                throw new ArgumentNullException("schoolYearTypeReference is a required property for TpdmCandidateEducatorPreparationProgramAssociationCohortYear and cannot be null");
            }
            this.SchoolYearTypeReference = schoolYearTypeReference;
            this.TermDescriptor = termDescriptor;
        }

        /// <summary>
        /// The type of cohort year (9th grade, graduation).
        /// </summary>
        /// <value>The type of cohort year (9th grade, graduation).</value>
        [DataMember(Name = "cohortYearTypeDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string CohortYearTypeDescriptor { get; set; }

        /// <summary>
        /// The term associated with the cohort year; for example, the intended term of graduation.
        /// </summary>
        /// <value>The term associated with the cohort year; for example, the intended term of graduation.</value>
        [DataMember(Name = "termDescriptor", EmitDefaultValue = true)]
        public string TermDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name = "schoolYearTypeReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TpdmCandidateEducatorPreparationProgramAssociationCohortYear {\n");
            sb.Append("  CohortYearTypeDescriptor: ").Append(CohortYearTypeDescriptor).Append("\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
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
            return this.Equals(input as TpdmCandidateEducatorPreparationProgramAssociationCohortYear);
        }

        /// <summary>
        /// Returns true if TpdmCandidateEducatorPreparationProgramAssociationCohortYear instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmCandidateEducatorPreparationProgramAssociationCohortYear to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmCandidateEducatorPreparationProgramAssociationCohortYear input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CohortYearTypeDescriptor == input.CohortYearTypeDescriptor ||
                    (this.CohortYearTypeDescriptor != null &&
                    this.CohortYearTypeDescriptor.Equals(input.CohortYearTypeDescriptor))
                ) && 
                (
                    this.TermDescriptor == input.TermDescriptor ||
                    (this.TermDescriptor != null &&
                    this.TermDescriptor.Equals(input.TermDescriptor))
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
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
                if (this.CohortYearTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.CohortYearTypeDescriptor.GetHashCode();
                }
                if (this.TermDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.TermDescriptor.GetHashCode();
                }
                if (this.SchoolYearTypeReference != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolYearTypeReference.GetHashCode();
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
            // CohortYearTypeDescriptor (string) maxLength
            if (this.CohortYearTypeDescriptor != null && this.CohortYearTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CohortYearTypeDescriptor, length must be less than 306.", new [] { "CohortYearTypeDescriptor" });
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
