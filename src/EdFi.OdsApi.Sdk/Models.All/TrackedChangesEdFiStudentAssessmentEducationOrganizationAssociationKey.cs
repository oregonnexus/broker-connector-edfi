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
    /// TrackedChangesEdFiStudentAssessmentEducationOrganizationAssociationKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_studentAssessmentEducationOrganizationAssociationKey")]
    public partial class TrackedChangesEdFiStudentAssessmentEducationOrganizationAssociationKey : IEquatable<TrackedChangesEdFiStudentAssessmentEducationOrganizationAssociationKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStudentAssessmentEducationOrganizationAssociationKey" /> class.
        /// </summary>
        /// <param name="educationOrganizationAssociationTypeDescriptor">The type of association being represented..</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="assessmentIdentifier">A unique number or alphanumeric code assigned to an assessment..</param>
        /// <param name="_namespace">Namespace for the assessment..</param>
        /// <param name="studentAssessmentIdentifier">A unique number or alphanumeric code assigned to an assessment administered to a student..</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student..</param>
        public TrackedChangesEdFiStudentAssessmentEducationOrganizationAssociationKey(string educationOrganizationAssociationTypeDescriptor = default(string), long educationOrganizationId = default(long), string assessmentIdentifier = default(string), string _namespace = default(string), string studentAssessmentIdentifier = default(string), string studentUniqueId = default(string))
        {
            this.EducationOrganizationAssociationTypeDescriptor = educationOrganizationAssociationTypeDescriptor;
            this.EducationOrganizationId = educationOrganizationId;
            this.AssessmentIdentifier = assessmentIdentifier;
            this.Namespace = _namespace;
            this.StudentAssessmentIdentifier = studentAssessmentIdentifier;
            this.StudentUniqueId = studentUniqueId;
        }

        /// <summary>
        /// The type of association being represented.
        /// </summary>
        /// <value>The type of association being represented.</value>
        [DataMember(Name = "educationOrganizationAssociationTypeDescriptor", EmitDefaultValue = false)]
        public string EducationOrganizationAssociationTypeDescriptor { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = false)]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to an assessment.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an assessment.</value>
        [DataMember(Name = "assessmentIdentifier", EmitDefaultValue = false)]
        public string AssessmentIdentifier { get; set; }

        /// <summary>
        /// Namespace for the assessment.
        /// </summary>
        /// <value>Namespace for the assessment.</value>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to an assessment administered to a student.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an assessment administered to a student.</value>
        [DataMember(Name = "studentAssessmentIdentifier", EmitDefaultValue = false)]
        public string StudentAssessmentIdentifier { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name = "studentUniqueId", EmitDefaultValue = false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiStudentAssessmentEducationOrganizationAssociationKey {\n");
            sb.Append("  EducationOrganizationAssociationTypeDescriptor: ").Append(EducationOrganizationAssociationTypeDescriptor).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  AssessmentIdentifier: ").Append(AssessmentIdentifier).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  StudentAssessmentIdentifier: ").Append(StudentAssessmentIdentifier).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiStudentAssessmentEducationOrganizationAssociationKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiStudentAssessmentEducationOrganizationAssociationKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiStudentAssessmentEducationOrganizationAssociationKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiStudentAssessmentEducationOrganizationAssociationKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EducationOrganizationAssociationTypeDescriptor == input.EducationOrganizationAssociationTypeDescriptor ||
                    (this.EducationOrganizationAssociationTypeDescriptor != null &&
                    this.EducationOrganizationAssociationTypeDescriptor.Equals(input.EducationOrganizationAssociationTypeDescriptor))
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId)
                ) && 
                (
                    this.AssessmentIdentifier == input.AssessmentIdentifier ||
                    (this.AssessmentIdentifier != null &&
                    this.AssessmentIdentifier.Equals(input.AssessmentIdentifier))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.StudentAssessmentIdentifier == input.StudentAssessmentIdentifier ||
                    (this.StudentAssessmentIdentifier != null &&
                    this.StudentAssessmentIdentifier.Equals(input.StudentAssessmentIdentifier))
                ) && 
                (
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
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
                if (this.EducationOrganizationAssociationTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.EducationOrganizationAssociationTypeDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
                if (this.AssessmentIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.AssessmentIdentifier.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.StudentAssessmentIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.StudentAssessmentIdentifier.GetHashCode();
                }
                if (this.StudentUniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.StudentUniqueId.GetHashCode();
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
            // EducationOrganizationAssociationTypeDescriptor (string) maxLength
            if (this.EducationOrganizationAssociationTypeDescriptor != null && this.EducationOrganizationAssociationTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducationOrganizationAssociationTypeDescriptor, length must be less than 306.", new [] { "EducationOrganizationAssociationTypeDescriptor" });
            }

            // AssessmentIdentifier (string) maxLength
            if (this.AssessmentIdentifier != null && this.AssessmentIdentifier.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentIdentifier, length must be less than 60.", new [] { "AssessmentIdentifier" });
            }

            // AssessmentIdentifier (string) minLength
            if (this.AssessmentIdentifier != null && this.AssessmentIdentifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentIdentifier, length must be greater than 1.", new [] { "AssessmentIdentifier" });
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

            // StudentAssessmentIdentifier (string) maxLength
            if (this.StudentAssessmentIdentifier != null && this.StudentAssessmentIdentifier.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentAssessmentIdentifier, length must be less than 60.", new [] { "StudentAssessmentIdentifier" });
            }

            // StudentAssessmentIdentifier (string) minLength
            if (this.StudentAssessmentIdentifier != null && this.StudentAssessmentIdentifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentAssessmentIdentifier, length must be greater than 1.", new [] { "StudentAssessmentIdentifier" });
            }

            // StudentUniqueId (string) maxLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            // StudentUniqueId (string) minLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be greater than 1.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

}
