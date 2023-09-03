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

namespace EdFi.OdsApi.Sdk.Models.EnrollmentComposites
{
    /// <summary>
    /// SchoolLocalEducationAgency
    /// </summary>
    [DataContract]
    public partial class SchoolLocalEducationAgency :  IEquatable<SchoolLocalEducationAgency>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolLocalEducationAgency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SchoolLocalEducationAgency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolLocalEducationAgency" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="localEducationAgencyId">The identifier assigned to a local education agency. (required).</param>
        public SchoolLocalEducationAgency(string id = default(string), int? localEducationAgencyId = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SchoolLocalEducationAgency and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "localEducationAgencyId" is required (not null)
            if (localEducationAgencyId == null)
            {
                throw new InvalidDataException("localEducationAgencyId is a required property for SchoolLocalEducationAgency and cannot be null");
            }
            else
            {
                this.LocalEducationAgencyId = localEducationAgencyId;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier assigned to a local education agency.
        /// </summary>
        /// <value>The identifier assigned to a local education agency.</value>
        [DataMember(Name="localEducationAgencyId", EmitDefaultValue=false)]
        public int? LocalEducationAgencyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolLocalEducationAgency {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocalEducationAgencyId: ").Append(LocalEducationAgencyId).Append("\n");
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
            return this.Equals(input as SchoolLocalEducationAgency);
        }

        /// <summary>
        /// Returns true if SchoolLocalEducationAgency instances are equal
        /// </summary>
        /// <param name="input">Instance of SchoolLocalEducationAgency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolLocalEducationAgency input)
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
                    this.LocalEducationAgencyId == input.LocalEducationAgencyId ||
                    (this.LocalEducationAgencyId != null &&
                    this.LocalEducationAgencyId.Equals(input.LocalEducationAgencyId))
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
                if (this.LocalEducationAgencyId != null)
                    hashCode = hashCode * 59 + this.LocalEducationAgencyId.GetHashCode();
                return hashCode;
            }
        }
    }

}
