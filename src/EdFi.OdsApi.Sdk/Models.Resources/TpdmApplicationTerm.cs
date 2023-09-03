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
    /// TpdmApplicationTerm
    /// </summary>
    [DataContract]
    public partial class TpdmApplicationTerm :  IEquatable<TpdmApplicationTerm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmApplicationTerm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmApplicationTerm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmApplicationTerm" /> class.
        /// </summary>
        /// <param name="termDescriptor">The intended term of enrollment for which the application is being submitted. (required).</param>
        public TpdmApplicationTerm(string termDescriptor = default(string))
        {
            // to ensure "termDescriptor" is required (not null)
            if (termDescriptor == null)
            {
                throw new InvalidDataException("termDescriptor is a required property for TpdmApplicationTerm and cannot be null");
            }
            else
            {
                this.TermDescriptor = termDescriptor;
            }
        }
        
        /// <summary>
        /// The intended term of enrollment for which the application is being submitted.
        /// </summary>
        /// <value>The intended term of enrollment for which the application is being submitted.</value>
        [DataMember(Name="termDescriptor", EmitDefaultValue=false)]
        public string TermDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmApplicationTerm {\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
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
            return this.Equals(input as TpdmApplicationTerm);
        }

        /// <summary>
        /// Returns true if TpdmApplicationTerm instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmApplicationTerm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmApplicationTerm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TermDescriptor == input.TermDescriptor ||
                    (this.TermDescriptor != null &&
                    this.TermDescriptor.Equals(input.TermDescriptor))
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
                if (this.TermDescriptor != null)
                    hashCode = hashCode * 59 + this.TermDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
