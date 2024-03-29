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
    /// TrackedChangesEdFiEducationOrganizationNetworkAssociationKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_educationOrganizationNetworkAssociationKey")]
    public partial class TrackedChangesEdFiEducationOrganizationNetworkAssociationKey : IEquatable<TrackedChangesEdFiEducationOrganizationNetworkAssociationKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiEducationOrganizationNetworkAssociationKey" /> class.
        /// </summary>
        /// <param name="memberEducationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="educationOrganizationNetworkId">The identifier assigned to a network of education organizations..</param>
        public TrackedChangesEdFiEducationOrganizationNetworkAssociationKey(long memberEducationOrganizationId = default(long), long educationOrganizationNetworkId = default(long))
        {
            this.MemberEducationOrganizationId = memberEducationOrganizationId;
            this.EducationOrganizationNetworkId = educationOrganizationNetworkId;
        }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "memberEducationOrganizationId", EmitDefaultValue = false)]
        public long MemberEducationOrganizationId { get; set; }

        /// <summary>
        /// The identifier assigned to a network of education organizations.
        /// </summary>
        /// <value>The identifier assigned to a network of education organizations.</value>
        [DataMember(Name = "educationOrganizationNetworkId", EmitDefaultValue = false)]
        public long EducationOrganizationNetworkId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiEducationOrganizationNetworkAssociationKey {\n");
            sb.Append("  MemberEducationOrganizationId: ").Append(MemberEducationOrganizationId).Append("\n");
            sb.Append("  EducationOrganizationNetworkId: ").Append(EducationOrganizationNetworkId).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiEducationOrganizationNetworkAssociationKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiEducationOrganizationNetworkAssociationKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiEducationOrganizationNetworkAssociationKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiEducationOrganizationNetworkAssociationKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MemberEducationOrganizationId == input.MemberEducationOrganizationId ||
                    this.MemberEducationOrganizationId.Equals(input.MemberEducationOrganizationId)
                ) && 
                (
                    this.EducationOrganizationNetworkId == input.EducationOrganizationNetworkId ||
                    this.EducationOrganizationNetworkId.Equals(input.EducationOrganizationNetworkId)
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
                hashCode = (hashCode * 59) + this.MemberEducationOrganizationId.GetHashCode();
                hashCode = (hashCode * 59) + this.EducationOrganizationNetworkId.GetHashCode();
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
