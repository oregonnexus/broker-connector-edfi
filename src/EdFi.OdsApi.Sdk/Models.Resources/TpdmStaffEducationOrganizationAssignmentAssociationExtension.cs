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
    /// TpdmStaffEducationOrganizationAssignmentAssociationExtension
    /// </summary>
    [DataContract]
    public partial class TpdmStaffEducationOrganizationAssignmentAssociationExtension :  IEquatable<TpdmStaffEducationOrganizationAssignmentAssociationExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmStaffEducationOrganizationAssignmentAssociationExtension" /> class.
        /// </summary>
        /// <param name="yearsOfExperienceAtCurrentEducationOrganization">The total number of years that an individual has previously held a teaching position in one or more education institutions..</param>
        public TpdmStaffEducationOrganizationAssignmentAssociationExtension(double? yearsOfExperienceAtCurrentEducationOrganization = default(double?))
        {
            this.YearsOfExperienceAtCurrentEducationOrganization = yearsOfExperienceAtCurrentEducationOrganization;
        }
        
        /// <summary>
        /// The total number of years that an individual has previously held a teaching position in one or more education institutions.
        /// </summary>
        /// <value>The total number of years that an individual has previously held a teaching position in one or more education institutions.</value>
        [DataMember(Name="yearsOfExperienceAtCurrentEducationOrganization", EmitDefaultValue=false)]
        public double? YearsOfExperienceAtCurrentEducationOrganization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmStaffEducationOrganizationAssignmentAssociationExtension {\n");
            sb.Append("  YearsOfExperienceAtCurrentEducationOrganization: ").Append(YearsOfExperienceAtCurrentEducationOrganization).Append("\n");
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
            return this.Equals(input as TpdmStaffEducationOrganizationAssignmentAssociationExtension);
        }

        /// <summary>
        /// Returns true if TpdmStaffEducationOrganizationAssignmentAssociationExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmStaffEducationOrganizationAssignmentAssociationExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmStaffEducationOrganizationAssignmentAssociationExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.YearsOfExperienceAtCurrentEducationOrganization == input.YearsOfExperienceAtCurrentEducationOrganization ||
                    (this.YearsOfExperienceAtCurrentEducationOrganization != null &&
                    this.YearsOfExperienceAtCurrentEducationOrganization.Equals(input.YearsOfExperienceAtCurrentEducationOrganization))
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
                if (this.YearsOfExperienceAtCurrentEducationOrganization != null)
                    hashCode = hashCode * 59 + this.YearsOfExperienceAtCurrentEducationOrganization.GetHashCode();
                return hashCode;
            }
        }
    }

}
