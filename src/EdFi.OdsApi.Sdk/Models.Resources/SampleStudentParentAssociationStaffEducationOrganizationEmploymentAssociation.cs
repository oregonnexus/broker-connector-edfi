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
    /// SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation
    /// </summary>
    [DataContract]
    public partial class SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation :  IEquatable<SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation" /> class.
        /// </summary>
        /// <param name="staffEducationOrganizationEmploymentAssociationReference">staffEducationOrganizationEmploymentAssociationReference (required).</param>
        public SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation(EdFiStaffEducationOrganizationEmploymentAssociationReference staffEducationOrganizationEmploymentAssociationReference = default(EdFiStaffEducationOrganizationEmploymentAssociationReference))
        {
            // to ensure "staffEducationOrganizationEmploymentAssociationReference" is required (not null)
            if (staffEducationOrganizationEmploymentAssociationReference == null)
            {
                throw new InvalidDataException("staffEducationOrganizationEmploymentAssociationReference is a required property for SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation and cannot be null");
            }
            else
            {
                this.StaffEducationOrganizationEmploymentAssociationReference = staffEducationOrganizationEmploymentAssociationReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets StaffEducationOrganizationEmploymentAssociationReference
        /// </summary>
        [DataMember(Name="staffEducationOrganizationEmploymentAssociationReference", EmitDefaultValue=false)]
        public EdFiStaffEducationOrganizationEmploymentAssociationReference StaffEducationOrganizationEmploymentAssociationReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation);
        }

        /// <summary>
        /// Returns true if SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentParentAssociationStaffEducationOrganizationEmploymentAssociation input)
        {
            if (input == null)
                return false;

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
                    hashCode = hashCode * 59 + this.StaffEducationOrganizationEmploymentAssociationReference.GetHashCode();
                return hashCode;
            }
        }
    }

}
