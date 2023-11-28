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
    /// TrackedChangesTpdmCandidateEducatorPreparationProgramAssociationKey
    /// </summary>
    [DataContract(Name = "trackedChanges_tpdm_candidateEducatorPreparationProgramAssociationKey")]
    public partial class TrackedChangesTpdmCandidateEducatorPreparationProgramAssociationKey : IEquatable<TrackedChangesTpdmCandidateEducatorPreparationProgramAssociationKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesTpdmCandidateEducatorPreparationProgramAssociationKey" /> class.
        /// </summary>
        /// <param name="beginDate">The begin date for the association..</param>
        /// <param name="candidateIdentifier">A unique alphanumeric code assigned to a candidate..</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="programName">The name of the Educator Preparation Program..</param>
        /// <param name="programTypeDescriptor">The type of program..</param>
        public TrackedChangesTpdmCandidateEducatorPreparationProgramAssociationKey(DateTime beginDate = default(DateTime), string candidateIdentifier = default(string), long educationOrganizationId = default(long), string programName = default(string), string programTypeDescriptor = default(string))
        {
            this.BeginDate = beginDate;
            this.CandidateIdentifier = candidateIdentifier;
            this.EducationOrganizationId = educationOrganizationId;
            this.ProgramName = programName;
            this.ProgramTypeDescriptor = programTypeDescriptor;
        }

        /// <summary>
        /// The begin date for the association.
        /// </summary>
        /// <value>The begin date for the association.</value>
        [DataMember(Name = "beginDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a candidate.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a candidate.</value>
        [DataMember(Name = "candidateIdentifier", EmitDefaultValue = false)]
        public string CandidateIdentifier { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = false)]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// The name of the Educator Preparation Program.
        /// </summary>
        /// <value>The name of the Educator Preparation Program.</value>
        [DataMember(Name = "programName", EmitDefaultValue = false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// The type of program.
        /// </summary>
        /// <value>The type of program.</value>
        [DataMember(Name = "programTypeDescriptor", EmitDefaultValue = false)]
        public string ProgramTypeDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesTpdmCandidateEducatorPreparationProgramAssociationKey {\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  CandidateIdentifier: ").Append(CandidateIdentifier).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  ProgramName: ").Append(ProgramName).Append("\n");
            sb.Append("  ProgramTypeDescriptor: ").Append(ProgramTypeDescriptor).Append("\n");
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
            return this.Equals(input as TrackedChangesTpdmCandidateEducatorPreparationProgramAssociationKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesTpdmCandidateEducatorPreparationProgramAssociationKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesTpdmCandidateEducatorPreparationProgramAssociationKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesTpdmCandidateEducatorPreparationProgramAssociationKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.CandidateIdentifier == input.CandidateIdentifier ||
                    (this.CandidateIdentifier != null &&
                    this.CandidateIdentifier.Equals(input.CandidateIdentifier))
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId)
                ) && 
                (
                    this.ProgramName == input.ProgramName ||
                    (this.ProgramName != null &&
                    this.ProgramName.Equals(input.ProgramName))
                ) && 
                (
                    this.ProgramTypeDescriptor == input.ProgramTypeDescriptor ||
                    (this.ProgramTypeDescriptor != null &&
                    this.ProgramTypeDescriptor.Equals(input.ProgramTypeDescriptor))
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
                if (this.BeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                }
                if (this.CandidateIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.CandidateIdentifier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
                if (this.ProgramName != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramName.GetHashCode();
                }
                if (this.ProgramTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramTypeDescriptor.GetHashCode();
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
            // CandidateIdentifier (string) maxLength
            if (this.CandidateIdentifier != null && this.CandidateIdentifier.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CandidateIdentifier, length must be less than 32.", new [] { "CandidateIdentifier" });
            }

            // CandidateIdentifier (string) minLength
            if (this.CandidateIdentifier != null && this.CandidateIdentifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CandidateIdentifier, length must be greater than 1.", new [] { "CandidateIdentifier" });
            }

            // ProgramName (string) maxLength
            if (this.ProgramName != null && this.ProgramName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramName, length must be less than 255.", new [] { "ProgramName" });
            }

            // ProgramName (string) minLength
            if (this.ProgramName != null && this.ProgramName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramName, length must be greater than 1.", new [] { "ProgramName" });
            }

            // ProgramTypeDescriptor (string) maxLength
            if (this.ProgramTypeDescriptor != null && this.ProgramTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramTypeDescriptor, length must be less than 306.", new [] { "ProgramTypeDescriptor" });
            }

            yield break;
        }
    }

}
