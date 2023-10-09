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
    /// TpdmGraduationPlanExtension
    /// </summary>
    [DataContract]
    public partial class TpdmGraduationPlanExtension :  IEquatable<TpdmGraduationPlanExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmGraduationPlanExtension" /> class.
        /// </summary>
        /// <param name="requiredCertifications">An unordered collection of graduationPlanRequiredCertifications. The title or reference to the certifiation(s) required for graduation..</param>
        public TpdmGraduationPlanExtension(List<TpdmGraduationPlanRequiredCertification> requiredCertifications = default(List<TpdmGraduationPlanRequiredCertification>))
        {
            this.RequiredCertifications = requiredCertifications;
        }
        
        /// <summary>
        /// An unordered collection of graduationPlanRequiredCertifications. The title or reference to the certifiation(s) required for graduation.
        /// </summary>
        /// <value>An unordered collection of graduationPlanRequiredCertifications. The title or reference to the certifiation(s) required for graduation.</value>
        [DataMember(Name="requiredCertifications", EmitDefaultValue=false)]
        public List<TpdmGraduationPlanRequiredCertification> RequiredCertifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmGraduationPlanExtension {\n");
            sb.Append("  RequiredCertifications: ").Append(RequiredCertifications).Append("\n");
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
            return this.Equals(input as TpdmGraduationPlanExtension);
        }

        /// <summary>
        /// Returns true if TpdmGraduationPlanExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmGraduationPlanExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmGraduationPlanExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequiredCertifications == input.RequiredCertifications ||
                    this.RequiredCertifications != null &&
                    this.RequiredCertifications.SequenceEqual(input.RequiredCertifications)
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
                if (this.RequiredCertifications != null)
                    hashCode = hashCode * 59 + this.RequiredCertifications.GetHashCode();
                return hashCode;
            }
        }
    }

}
