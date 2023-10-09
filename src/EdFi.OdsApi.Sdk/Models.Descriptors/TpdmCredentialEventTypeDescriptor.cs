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

namespace EdFi.OdsApi.Sdk.Models.Descriptors
{
    /// <summary>
    /// TpdmCredentialEventTypeDescriptor
    /// </summary>
    [DataContract]
    public partial class TpdmCredentialEventTypeDescriptor :  IEquatable<TpdmCredentialEventTypeDescriptor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCredentialEventTypeDescriptor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmCredentialEventTypeDescriptor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCredentialEventTypeDescriptor" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="credentialEventTypeDescriptorId">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table..</param>
        /// <param name="codeValue">A code or abbreviation that is used to refer to the descriptor. (required).</param>
        /// <param name="description">The description of the descriptor..</param>
        /// <param name="effectiveBeginDate">The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness..</param>
        /// <param name="effectiveEndDate">The end date of the period when the descriptor is in effect..</param>
        /// <param name="_namespace">A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary. (required).</param>
        /// <param name="priorDescriptorId">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table..</param>
        /// <param name="shortDescription">A shortened description for the descriptor. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmCredentialEventTypeDescriptor(string id = default(string), int? credentialEventTypeDescriptorId = default(int?), string codeValue = default(string), string description = default(string), DateTime? effectiveBeginDate = default(DateTime?), DateTime? effectiveEndDate = default(DateTime?), string _namespace = default(string), int? priorDescriptorId = default(int?), string shortDescription = default(string), string etag = default(string))
        {
            // to ensure "codeValue" is required (not null)
            if (codeValue == null)
            {
                throw new InvalidDataException("codeValue is a required property for TpdmCredentialEventTypeDescriptor and cannot be null");
            }
            else
            {
                this.CodeValue = codeValue;
            }
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new InvalidDataException("_namespace is a required property for TpdmCredentialEventTypeDescriptor and cannot be null");
            }
            else
            {
                this.Namespace = _namespace;
            }
            // to ensure "shortDescription" is required (not null)
            if (shortDescription == null)
            {
                throw new InvalidDataException("shortDescription is a required property for TpdmCredentialEventTypeDescriptor and cannot be null");
            }
            else
            {
                this.ShortDescription = shortDescription;
            }
            this.Id = id;
            this.CredentialEventTypeDescriptorId = credentialEventTypeDescriptorId;
            this.Description = description;
            this.EffectiveBeginDate = effectiveBeginDate;
            this.EffectiveEndDate = effectiveEndDate;
            this.PriorDescriptorId = priorDescriptorId;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        /// <value>A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</value>
        [DataMember(Name="credentialEventTypeDescriptorId", EmitDefaultValue=false)]
        public int? CredentialEventTypeDescriptorId { get; set; }

        /// <summary>
        /// A code or abbreviation that is used to refer to the descriptor.
        /// </summary>
        /// <value>A code or abbreviation that is used to refer to the descriptor.</value>
        [DataMember(Name="codeValue", EmitDefaultValue=false)]
        public string CodeValue { get; set; }

        /// <summary>
        /// The description of the descriptor.
        /// </summary>
        /// <value>The description of the descriptor.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness.
        /// </summary>
        /// <value>The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness.</value>
        [DataMember(Name="effectiveBeginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EffectiveBeginDate { get; set; }

        /// <summary>
        /// The end date of the period when the descriptor is in effect.
        /// </summary>
        /// <value>The end date of the period when the descriptor is in effect.</value>
        [DataMember(Name="effectiveEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EffectiveEndDate { get; set; }

        /// <summary>
        /// A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary.
        /// </summary>
        /// <value>A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        /// <value>A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</value>
        [DataMember(Name="priorDescriptorId", EmitDefaultValue=false)]
        public int? PriorDescriptorId { get; set; }

        /// <summary>
        /// A shortened description for the descriptor.
        /// </summary>
        /// <value>A shortened description for the descriptor.</value>
        [DataMember(Name="shortDescription", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmCredentialEventTypeDescriptor {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CredentialEventTypeDescriptorId: ").Append(CredentialEventTypeDescriptorId).Append("\n");
            sb.Append("  CodeValue: ").Append(CodeValue).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EffectiveBeginDate: ").Append(EffectiveBeginDate).Append("\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  PriorDescriptorId: ").Append(PriorDescriptorId).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as TpdmCredentialEventTypeDescriptor);
        }

        /// <summary>
        /// Returns true if TpdmCredentialEventTypeDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmCredentialEventTypeDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmCredentialEventTypeDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CredentialEventTypeDescriptorId == input.CredentialEventTypeDescriptorId ||
                    (this.CredentialEventTypeDescriptorId != null &&
                    this.CredentialEventTypeDescriptorId.Equals(input.CredentialEventTypeDescriptorId))
                ) && 
                (
                    this.CodeValue == input.CodeValue ||
                    (this.CodeValue != null &&
                    this.CodeValue.Equals(input.CodeValue))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EffectiveBeginDate == input.EffectiveBeginDate ||
                    (this.EffectiveBeginDate != null &&
                    this.EffectiveBeginDate.Equals(input.EffectiveBeginDate))
                ) && 
                (
                    this.EffectiveEndDate == input.EffectiveEndDate ||
                    (this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.PriorDescriptorId == input.PriorDescriptorId ||
                    (this.PriorDescriptorId != null &&
                    this.PriorDescriptorId.Equals(input.PriorDescriptorId))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CredentialEventTypeDescriptorId != null)
                    hashCode = hashCode * 59 + this.CredentialEventTypeDescriptorId.GetHashCode();
                if (this.CodeValue != null)
                    hashCode = hashCode * 59 + this.CodeValue.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EffectiveBeginDate != null)
                    hashCode = hashCode * 59 + this.EffectiveBeginDate.GetHashCode();
                if (this.EffectiveEndDate != null)
                    hashCode = hashCode * 59 + this.EffectiveEndDate.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.PriorDescriptorId != null)
                    hashCode = hashCode * 59 + this.PriorDescriptorId.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
