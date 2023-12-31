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
    /// TpdmApplicantVisa
    /// </summary>
    [DataContract]
    public partial class TpdmApplicantVisa :  IEquatable<TpdmApplicantVisa>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmApplicantVisa" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmApplicantVisa() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmApplicantVisa" /> class.
        /// </summary>
        /// <param name="visaDescriptor">An indicator of a non-US citizen&#39;s Visa type. (required).</param>
        public TpdmApplicantVisa(string visaDescriptor = default(string))
        {
            // to ensure "visaDescriptor" is required (not null)
            if (visaDescriptor == null)
            {
                throw new InvalidDataException("visaDescriptor is a required property for TpdmApplicantVisa and cannot be null");
            }
            else
            {
                this.VisaDescriptor = visaDescriptor;
            }
        }
        
        /// <summary>
        /// An indicator of a non-US citizen&#39;s Visa type.
        /// </summary>
        /// <value>An indicator of a non-US citizen&#39;s Visa type.</value>
        [DataMember(Name="visaDescriptor", EmitDefaultValue=false)]
        public string VisaDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmApplicantVisa {\n");
            sb.Append("  VisaDescriptor: ").Append(VisaDescriptor).Append("\n");
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
            return this.Equals(input as TpdmApplicantVisa);
        }

        /// <summary>
        /// Returns true if TpdmApplicantVisa instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmApplicantVisa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmApplicantVisa input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VisaDescriptor == input.VisaDescriptor ||
                    (this.VisaDescriptor != null &&
                    this.VisaDescriptor.Equals(input.VisaDescriptor))
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
                if (this.VisaDescriptor != null)
                    hashCode = hashCode * 59 + this.VisaDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
