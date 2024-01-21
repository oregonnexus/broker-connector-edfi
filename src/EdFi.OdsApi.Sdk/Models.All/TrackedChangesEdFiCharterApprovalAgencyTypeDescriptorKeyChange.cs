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
    /// TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKeyChange
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_charterApprovalAgencyTypeDescriptorKeyChange")]
    public partial class TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKeyChange : IEquatable<TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKeyChange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKeyChange" /> class.
        /// </summary>
        /// <param name="id">Resource identifier.</param>
        /// <param name="changeVersion">Change version.</param>
        /// <param name="oldKeyValues">oldKeyValues.</param>
        /// <param name="newKeyValues">newKeyValues.</param>
        public TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKeyChange(string id = default(string), decimal changeVersion = default(decimal), TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKey oldKeyValues = default(TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKey), TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKey newKeyValues = default(TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKey))
        {
            this.Id = id;
            this.ChangeVersion = changeVersion;
            this.OldKeyValues = oldKeyValues;
            this.NewKeyValues = newKeyValues;
        }

        /// <summary>
        /// Resource identifier
        /// </summary>
        /// <value>Resource identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Change version
        /// </summary>
        /// <value>Change version</value>
        [DataMember(Name = "changeVersion", EmitDefaultValue = false)]
        public decimal ChangeVersion { get; set; }

        /// <summary>
        /// Gets or Sets OldKeyValues
        /// </summary>
        [DataMember(Name = "oldKeyValues", EmitDefaultValue = false)]
        public TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKey OldKeyValues { get; set; }

        /// <summary>
        /// Gets or Sets NewKeyValues
        /// </summary>
        [DataMember(Name = "newKeyValues", EmitDefaultValue = false)]
        public TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKey NewKeyValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKeyChange {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChangeVersion: ").Append(ChangeVersion).Append("\n");
            sb.Append("  OldKeyValues: ").Append(OldKeyValues).Append("\n");
            sb.Append("  NewKeyValues: ").Append(NewKeyValues).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKeyChange);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKeyChange instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKeyChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiCharterApprovalAgencyTypeDescriptorKeyChange input)
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
                    this.ChangeVersion == input.ChangeVersion ||
                    this.ChangeVersion.Equals(input.ChangeVersion)
                ) && 
                (
                    this.OldKeyValues == input.OldKeyValues ||
                    (this.OldKeyValues != null &&
                    this.OldKeyValues.Equals(input.OldKeyValues))
                ) && 
                (
                    this.NewKeyValues == input.NewKeyValues ||
                    (this.NewKeyValues != null &&
                    this.NewKeyValues.Equals(input.NewKeyValues))
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
                hashCode = (hashCode * 59) + this.ChangeVersion.GetHashCode();
                if (this.OldKeyValues != null)
                {
                    hashCode = (hashCode * 59) + this.OldKeyValues.GetHashCode();
                }
                if (this.NewKeyValues != null)
                {
                    hashCode = (hashCode * 59) + this.NewKeyValues.GetHashCode();
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
