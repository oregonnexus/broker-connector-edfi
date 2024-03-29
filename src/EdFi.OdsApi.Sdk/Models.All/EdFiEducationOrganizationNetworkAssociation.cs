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
    /// EdFiEducationOrganizationNetworkAssociation
    /// </summary>
    [DataContract(Name = "edFi_educationOrganizationNetworkAssociation")]
    public partial class EdFiEducationOrganizationNetworkAssociation : IEquatable<EdFiEducationOrganizationNetworkAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationNetworkAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationOrganizationNetworkAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationNetworkAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="educationOrganizationNetworkReference">educationOrganizationNetworkReference (required).</param>
        /// <param name="memberEducationOrganizationReference">memberEducationOrganizationReference (required).</param>
        /// <param name="beginDate">The date on which the education organization joined this network..</param>
        /// <param name="endDate">The date on which the education organization left this network..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiEducationOrganizationNetworkAssociation(string id = default(string), EdFiEducationOrganizationNetworkReference educationOrganizationNetworkReference = default(EdFiEducationOrganizationNetworkReference), EdFiEducationOrganizationReference memberEducationOrganizationReference = default(EdFiEducationOrganizationReference), DateTime? beginDate = default(DateTime?), DateTime? endDate = default(DateTime?), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "educationOrganizationNetworkReference" is required (not null)
            if (educationOrganizationNetworkReference == null)
            {
                throw new ArgumentNullException("educationOrganizationNetworkReference is a required property for EdFiEducationOrganizationNetworkAssociation and cannot be null");
            }
            this.EducationOrganizationNetworkReference = educationOrganizationNetworkReference;
            // to ensure "memberEducationOrganizationReference" is required (not null)
            if (memberEducationOrganizationReference == null)
            {
                throw new ArgumentNullException("memberEducationOrganizationReference is a required property for EdFiEducationOrganizationNetworkAssociation and cannot be null");
            }
            this.MemberEducationOrganizationReference = memberEducationOrganizationReference;
            this.Id = id;
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationNetworkReference
        /// </summary>
        [DataMember(Name = "educationOrganizationNetworkReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiEducationOrganizationNetworkReference EducationOrganizationNetworkReference { get; set; }

        /// <summary>
        /// Gets or Sets MemberEducationOrganizationReference
        /// </summary>
        [DataMember(Name = "memberEducationOrganizationReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiEducationOrganizationReference MemberEducationOrganizationReference { get; set; }

        /// <summary>
        /// The date on which the education organization joined this network.
        /// </summary>
        /// <value>The date on which the education organization joined this network.</value>
        [DataMember(Name = "beginDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The date on which the education organization left this network.
        /// </summary>
        /// <value>The date on which the education organization left this network.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

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
            sb.Append("class EdFiEducationOrganizationNetworkAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationNetworkReference: ").Append(EducationOrganizationNetworkReference).Append("\n");
            sb.Append("  MemberEducationOrganizationReference: ").Append(MemberEducationOrganizationReference).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as EdFiEducationOrganizationNetworkAssociation);
        }

        /// <summary>
        /// Returns true if EdFiEducationOrganizationNetworkAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiEducationOrganizationNetworkAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiEducationOrganizationNetworkAssociation input)
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
                    this.EducationOrganizationNetworkReference == input.EducationOrganizationNetworkReference ||
                    (this.EducationOrganizationNetworkReference != null &&
                    this.EducationOrganizationNetworkReference.Equals(input.EducationOrganizationNetworkReference))
                ) && 
                (
                    this.MemberEducationOrganizationReference == input.MemberEducationOrganizationReference ||
                    (this.MemberEducationOrganizationReference != null &&
                    this.MemberEducationOrganizationReference.Equals(input.MemberEducationOrganizationReference))
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                if (this.EducationOrganizationNetworkReference != null)
                {
                    hashCode = (hashCode * 59) + this.EducationOrganizationNetworkReference.GetHashCode();
                }
                if (this.MemberEducationOrganizationReference != null)
                {
                    hashCode = (hashCode * 59) + this.MemberEducationOrganizationReference.GetHashCode();
                }
                if (this.BeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
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
            yield break;
        }
    }

}
