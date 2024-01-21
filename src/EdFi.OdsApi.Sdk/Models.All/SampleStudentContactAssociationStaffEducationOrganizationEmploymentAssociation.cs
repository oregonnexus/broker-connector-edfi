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
    /// SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation
    /// </summary>
    [DataContract(Name = "sample_studentContactAssociationStaffEducationOrganizationEmploymentAssociation")]
    public partial class SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation : IEquatable<SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation" /> class.
        /// </summary>
        /// <param name="staffEducationOrganizationEmploymentAssociationReference">staffEducationOrganizationEmploymentAssociationReference (required).</param>
        public SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation(EdFiStaffEducationOrganizationEmploymentAssociationReference staffEducationOrganizationEmploymentAssociationReference = default(EdFiStaffEducationOrganizationEmploymentAssociationReference))
        {
            // to ensure "staffEducationOrganizationEmploymentAssociationReference" is required (not null)
            if (staffEducationOrganizationEmploymentAssociationReference == null)
            {
                throw new ArgumentNullException("staffEducationOrganizationEmploymentAssociationReference is a required property for SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation and cannot be null");
            }
            this.StaffEducationOrganizationEmploymentAssociationReference = staffEducationOrganizationEmploymentAssociationReference;
        }

        /// <summary>
        /// Gets or Sets StaffEducationOrganizationEmploymentAssociationReference
        /// </summary>
        [DataMember(Name = "staffEducationOrganizationEmploymentAssociationReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStaffEducationOrganizationEmploymentAssociationReference StaffEducationOrganizationEmploymentAssociationReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation {\n");
            sb.Append("  StaffEducationOrganizationEmploymentAssociationReference: ").Append(StaffEducationOrganizationEmploymentAssociationReference).Append("\n");
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
            return this.Equals(input as SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation);
        }

        /// <summary>
        /// Returns true if SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentContactAssociationStaffEducationOrganizationEmploymentAssociation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StaffEducationOrganizationEmploymentAssociationReference == input.StaffEducationOrganizationEmploymentAssociationReference ||
                    (this.StaffEducationOrganizationEmploymentAssociationReference != null &&
                    this.StaffEducationOrganizationEmploymentAssociationReference.Equals(input.StaffEducationOrganizationEmploymentAssociationReference))
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
                if (this.StaffEducationOrganizationEmploymentAssociationReference != null)
                {
                    hashCode = (hashCode * 59) + this.StaffEducationOrganizationEmploymentAssociationReference.GetHashCode();
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
            yield break;
        }
    }

}
