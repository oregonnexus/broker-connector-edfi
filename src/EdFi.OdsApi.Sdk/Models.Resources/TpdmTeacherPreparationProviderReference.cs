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
    /// TpdmTeacherPreparationProviderReference
    /// </summary>
    [DataContract]
    public partial class TpdmTeacherPreparationProviderReference :  IEquatable<TpdmTeacherPreparationProviderReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmTeacherPreparationProviderReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmTeacherPreparationProviderReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmTeacherPreparationProviderReference" /> class.
        /// </summary>
        /// <param name="teacherPreparationProviderId">The unique identification code for the Teacher Preparation Provider (required).</param>
        /// <param name="link">link.</param>
        public TpdmTeacherPreparationProviderReference(int? teacherPreparationProviderId = default(int?), Link link = default(Link))
        {
            // to ensure "teacherPreparationProviderId" is required (not null)
            if (teacherPreparationProviderId == null)
            {
                throw new InvalidDataException("teacherPreparationProviderId is a required property for TpdmTeacherPreparationProviderReference and cannot be null");
            }
            else
            {
                this.TeacherPreparationProviderId = teacherPreparationProviderId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The unique identification code for the Teacher Preparation Provider
        /// </summary>
        /// <value>The unique identification code for the Teacher Preparation Provider</value>
        [DataMember(Name="teacherPreparationProviderId", EmitDefaultValue=false)]
        public int? TeacherPreparationProviderId { get; set; }

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
            sb.Append("class TpdmTeacherPreparationProviderReference {\n");
            sb.Append("  TeacherPreparationProviderId: ").Append(TeacherPreparationProviderId).Append("\n");
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
            return this.Equals(input as TpdmTeacherPreparationProviderReference);
        }

        /// <summary>
        /// Returns true if TpdmTeacherPreparationProviderReference instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmTeacherPreparationProviderReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmTeacherPreparationProviderReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TeacherPreparationProviderId == input.TeacherPreparationProviderId ||
                    (this.TeacherPreparationProviderId != null &&
                    this.TeacherPreparationProviderId.Equals(input.TeacherPreparationProviderId))
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
                if (this.TeacherPreparationProviderId != null)
                    hashCode = hashCode * 59 + this.TeacherPreparationProviderId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
