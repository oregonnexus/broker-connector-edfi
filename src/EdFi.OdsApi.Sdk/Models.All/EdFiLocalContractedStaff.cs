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
    /// EdFiLocalContractedStaff
    /// </summary>
    [DataContract(Name = "edFi_localContractedStaff")]
    public partial class EdFiLocalContractedStaff : IEquatable<EdFiLocalContractedStaff>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalContractedStaff" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLocalContractedStaff() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalContractedStaff" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="asOfDate">The date of the reported amount for the account. (required).</param>
        /// <param name="localAccountReference">localAccountReference (required).</param>
        /// <param name="staffReference">staffReference (required).</param>
        /// <param name="amount">Current balance for the account. (required).</param>
        /// <param name="financialCollectionDescriptor">The accounting period or grouping for which the amount is collected..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiLocalContractedStaff(string id = default(string), DateTime asOfDate = default(DateTime), EdFiLocalAccountReference localAccountReference = default(EdFiLocalAccountReference), EdFiStaffReference staffReference = default(EdFiStaffReference), double amount = default(double), string financialCollectionDescriptor = default(string), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            this.AsOfDate = asOfDate;
            // to ensure "localAccountReference" is required (not null)
            if (localAccountReference == null)
            {
                throw new ArgumentNullException("localAccountReference is a required property for EdFiLocalContractedStaff and cannot be null");
            }
            this.LocalAccountReference = localAccountReference;
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new ArgumentNullException("staffReference is a required property for EdFiLocalContractedStaff and cannot be null");
            }
            this.StaffReference = staffReference;
            this.Amount = amount;
            this.Id = id;
            this.FinancialCollectionDescriptor = financialCollectionDescriptor;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The date of the reported amount for the account.
        /// </summary>
        /// <value>The date of the reported amount for the account.</value>
        [DataMember(Name = "asOfDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime AsOfDate { get; set; }

        /// <summary>
        /// Gets or Sets LocalAccountReference
        /// </summary>
        [DataMember(Name = "localAccountReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiLocalAccountReference LocalAccountReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name = "staffReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// Current balance for the account.
        /// </summary>
        /// <value>Current balance for the account.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public double Amount { get; set; }

        /// <summary>
        /// The accounting period or grouping for which the amount is collected.
        /// </summary>
        /// <value>The accounting period or grouping for which the amount is collected.</value>
        [DataMember(Name = "financialCollectionDescriptor", EmitDefaultValue = true)]
        public string FinancialCollectionDescriptor { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// The date and time the resource was last modified.
        /// </summary>
        /// <value>The date and time the resource was last modified.</value>
        [DataMember(Name = "_lastModifiedDate", EmitDefaultValue = false)]
        public DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiLocalContractedStaff {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
            sb.Append("  LocalAccountReference: ").Append(LocalAccountReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  FinancialCollectionDescriptor: ").Append(FinancialCollectionDescriptor).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
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
            return this.Equals(input as EdFiLocalContractedStaff);
        }

        /// <summary>
        /// Returns true if EdFiLocalContractedStaff instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLocalContractedStaff to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLocalContractedStaff input)
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
                    this.AsOfDate == input.AsOfDate ||
                    (this.AsOfDate != null &&
                    this.AsOfDate.Equals(input.AsOfDate))
                ) && 
                (
                    this.LocalAccountReference == input.LocalAccountReference ||
                    (this.LocalAccountReference != null &&
                    this.LocalAccountReference.Equals(input.LocalAccountReference))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.FinancialCollectionDescriptor == input.FinancialCollectionDescriptor ||
                    (this.FinancialCollectionDescriptor != null &&
                    this.FinancialCollectionDescriptor.Equals(input.FinancialCollectionDescriptor))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
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
                if (this.AsOfDate != null)
                {
                    hashCode = (hashCode * 59) + this.AsOfDate.GetHashCode();
                }
                if (this.LocalAccountReference != null)
                {
                    hashCode = (hashCode * 59) + this.LocalAccountReference.GetHashCode();
                }
                if (this.StaffReference != null)
                {
                    hashCode = (hashCode * 59) + this.StaffReference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.FinancialCollectionDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.FinancialCollectionDescriptor.GetHashCode();
                }
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
                }
                if (this.LastModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedDate.GetHashCode();
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
            // FinancialCollectionDescriptor (string) maxLength
            if (this.FinancialCollectionDescriptor != null && this.FinancialCollectionDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FinancialCollectionDescriptor, length must be less than 306.", new [] { "FinancialCollectionDescriptor" });
            }

            yield break;
        }
    }

}
