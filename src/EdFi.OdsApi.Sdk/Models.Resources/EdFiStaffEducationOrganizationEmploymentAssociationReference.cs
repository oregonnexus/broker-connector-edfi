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
    /// EdFiStaffEducationOrganizationEmploymentAssociationReference
    /// </summary>
    [DataContract]
    public partial class EdFiStaffEducationOrganizationEmploymentAssociationReference :  IEquatable<EdFiStaffEducationOrganizationEmploymentAssociationReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffEducationOrganizationEmploymentAssociationReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffEducationOrganizationEmploymentAssociationReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffEducationOrganizationEmploymentAssociationReference" /> class.
        /// </summary>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="employmentStatusDescriptor">Reflects the type of employment or contract; for example:          Probationary          Contractual          Substitute/temporary          Tenured or permanent          Volunteer/no contract          ... (required).</param>
        /// <param name="hireDate">The month, day, and year on which an individual was hired for a position. (required).</param>
        /// <param name="staffUniqueId">A unique alphanumeric code assigned to a staff. (required).</param>
        /// <param name="link">link.</param>
        public EdFiStaffEducationOrganizationEmploymentAssociationReference(int? educationOrganizationId = default(int?), string employmentStatusDescriptor = default(string), DateTime? hireDate = default(DateTime?), string staffUniqueId = default(string), Link link = default(Link))
        {
            // to ensure "educationOrganizationId" is required (not null)
            if (educationOrganizationId == null)
            {
                throw new InvalidDataException("educationOrganizationId is a required property for EdFiStaffEducationOrganizationEmploymentAssociationReference and cannot be null");
            }
            else
            {
                this.EducationOrganizationId = educationOrganizationId;
            }
            // to ensure "employmentStatusDescriptor" is required (not null)
            if (employmentStatusDescriptor == null)
            {
                throw new InvalidDataException("employmentStatusDescriptor is a required property for EdFiStaffEducationOrganizationEmploymentAssociationReference and cannot be null");
            }
            else
            {
                this.EmploymentStatusDescriptor = employmentStatusDescriptor;
            }
            // to ensure "hireDate" is required (not null)
            if (hireDate == null)
            {
                throw new InvalidDataException("hireDate is a required property for EdFiStaffEducationOrganizationEmploymentAssociationReference and cannot be null");
            }
            else
            {
                this.HireDate = hireDate;
            }
            // to ensure "staffUniqueId" is required (not null)
            if (staffUniqueId == null)
            {
                throw new InvalidDataException("staffUniqueId is a required property for EdFiStaffEducationOrganizationEmploymentAssociationReference and cannot be null");
            }
            else
            {
                this.StaffUniqueId = staffUniqueId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name="educationOrganizationId", EmitDefaultValue=false)]
        public int? EducationOrganizationId { get; set; }

        /// <summary>
        /// Reflects the type of employment or contract; for example:          Probationary          Contractual          Substitute/temporary          Tenured or permanent          Volunteer/no contract          ...
        /// </summary>
        /// <value>Reflects the type of employment or contract; for example:          Probationary          Contractual          Substitute/temporary          Tenured or permanent          Volunteer/no contract          ...</value>
        [DataMember(Name="employmentStatusDescriptor", EmitDefaultValue=false)]
        public string EmploymentStatusDescriptor { get; set; }

        /// <summary>
        /// The month, day, and year on which an individual was hired for a position.
        /// </summary>
        /// <value>The month, day, and year on which an individual was hired for a position.</value>
        [DataMember(Name="hireDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a staff.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a staff.</value>
        [DataMember(Name="staffUniqueId", EmitDefaultValue=false)]
        public string StaffUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStaffEducationOrganizationEmploymentAssociationReference {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  EmploymentStatusDescriptor: ").Append(EmploymentStatusDescriptor).Append("\n");
            sb.Append("  HireDate: ").Append(HireDate).Append("\n");
            sb.Append("  StaffUniqueId: ").Append(StaffUniqueId).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiStaffEducationOrganizationEmploymentAssociationReference);
        }

        /// <summary>
        /// Returns true if EdFiStaffEducationOrganizationEmploymentAssociationReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffEducationOrganizationEmploymentAssociationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffEducationOrganizationEmploymentAssociationReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    (this.EducationOrganizationId != null &&
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId))
                ) && 
                (
                    this.EmploymentStatusDescriptor == input.EmploymentStatusDescriptor ||
                    (this.EmploymentStatusDescriptor != null &&
                    this.EmploymentStatusDescriptor.Equals(input.EmploymentStatusDescriptor))
                ) && 
                (
                    this.HireDate == input.HireDate ||
                    (this.HireDate != null &&
                    this.HireDate.Equals(input.HireDate))
                ) && 
                (
                    this.StaffUniqueId == input.StaffUniqueId ||
                    (this.StaffUniqueId != null &&
                    this.StaffUniqueId.Equals(input.StaffUniqueId))
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
                if (this.EducationOrganizationId != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationId.GetHashCode();
                if (this.EmploymentStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.EmploymentStatusDescriptor.GetHashCode();
                if (this.HireDate != null)
                    hashCode = hashCode * 59 + this.HireDate.GetHashCode();
                if (this.StaffUniqueId != null)
                    hashCode = hashCode * 59 + this.StaffUniqueId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
