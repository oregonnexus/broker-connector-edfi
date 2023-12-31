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
    /// OpenStaffPositionExtensions
    /// </summary>
    [DataContract]
    public partial class OpenStaffPositionExtensions :  IEquatable<OpenStaffPositionExtensions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenStaffPositionExtensions" /> class.
        /// </summary>
        /// <param name="tPDM">tPDM.</param>
        public OpenStaffPositionExtensions(TpdmOpenStaffPositionExtension tPDM = default(TpdmOpenStaffPositionExtension))
        {
            this.TPDM = tPDM;
        }
        
        /// <summary>
        /// Gets or Sets TPDM
        /// </summary>
        [DataMember(Name="TPDM", EmitDefaultValue=false)]
        public TpdmOpenStaffPositionExtension TPDM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenStaffPositionExtensions {\n");
            sb.Append("  TPDM: ").Append(TPDM).Append("\n");
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
            return this.Equals(input as OpenStaffPositionExtensions);
        }

        /// <summary>
        /// Returns true if OpenStaffPositionExtensions instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenStaffPositionExtensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenStaffPositionExtensions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TPDM == input.TPDM ||
                    (this.TPDM != null &&
                    this.TPDM.Equals(input.TPDM))
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
                if (this.TPDM != null)
                    hashCode = hashCode * 59 + this.TPDM.GetHashCode();
                return hashCode;
            }
        }
    }

}
