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
    /// TpdmStaffProspectAssociation
    /// </summary>
    [DataContract]
    public partial class TpdmStaffProspectAssociation :  IEquatable<TpdmStaffProspectAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmStaffProspectAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmStaffProspectAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmStaffProspectAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="prospectReference">prospectReference (required).</param>
        /// <param name="staffReference">staffReference (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmStaffProspectAssociation(string id = default(string), TpdmProspectReference prospectReference = default(TpdmProspectReference), EdFiStaffReference staffReference = default(EdFiStaffReference), string etag = default(string))
        {
            // to ensure "prospectReference" is required (not null)
            if (prospectReference == null)
            {
                throw new InvalidDataException("prospectReference is a required property for TpdmStaffProspectAssociation and cannot be null");
            }
            else
            {
                this.ProspectReference = prospectReference;
            }
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new InvalidDataException("staffReference is a required property for TpdmStaffProspectAssociation and cannot be null");
            }
            else
            {
                this.StaffReference = staffReference;
            }
            this.Id = id;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProspectReference
        /// </summary>
        [DataMember(Name="prospectReference", EmitDefaultValue=false)]
        public TpdmProspectReference ProspectReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name="staffReference", EmitDefaultValue=false)]
        public EdFiStaffReference StaffReference { get; set; }

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
            sb.Append("class TpdmStaffProspectAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProspectReference: ").Append(ProspectReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
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
            return this.Equals(input as TpdmStaffProspectAssociation);
        }

        /// <summary>
        /// Returns true if TpdmStaffProspectAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmStaffProspectAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmStaffProspectAssociation input)
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
                    this.ProspectReference == input.ProspectReference ||
                    (this.ProspectReference != null &&
                    this.ProspectReference.Equals(input.ProspectReference))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
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
                if (this.ProspectReference != null)
                    hashCode = hashCode * 59 + this.ProspectReference.GetHashCode();
                if (this.StaffReference != null)
                    hashCode = hashCode * 59 + this.StaffReference.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
