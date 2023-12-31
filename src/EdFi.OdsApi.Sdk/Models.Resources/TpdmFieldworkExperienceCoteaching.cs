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
    /// TpdmFieldworkExperienceCoteaching
    /// </summary>
    [DataContract]
    public partial class TpdmFieldworkExperienceCoteaching :  IEquatable<TpdmFieldworkExperienceCoteaching>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmFieldworkExperienceCoteaching" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmFieldworkExperienceCoteaching() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmFieldworkExperienceCoteaching" /> class.
        /// </summary>
        /// <param name="coteachingBeginDate">The month, day, and year on which the teacher candidate first starts co-teaching. (required).</param>
        /// <param name="coteachingEndDate">The month, day, and year on which the teacher candidate stopped co-teaching..</param>
        public TpdmFieldworkExperienceCoteaching(DateTime? coteachingBeginDate = default(DateTime?), DateTime? coteachingEndDate = default(DateTime?))
        {
            // to ensure "coteachingBeginDate" is required (not null)
            if (coteachingBeginDate == null)
            {
                throw new InvalidDataException("coteachingBeginDate is a required property for TpdmFieldworkExperienceCoteaching and cannot be null");
            }
            else
            {
                this.CoteachingBeginDate = coteachingBeginDate;
            }
            this.CoteachingEndDate = coteachingEndDate;
        }
        
        /// <summary>
        /// The month, day, and year on which the teacher candidate first starts co-teaching.
        /// </summary>
        /// <value>The month, day, and year on which the teacher candidate first starts co-teaching.</value>
        [DataMember(Name="coteachingBeginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? CoteachingBeginDate { get; set; }

        /// <summary>
        /// The month, day, and year on which the teacher candidate stopped co-teaching.
        /// </summary>
        /// <value>The month, day, and year on which the teacher candidate stopped co-teaching.</value>
        [DataMember(Name="coteachingEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? CoteachingEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmFieldworkExperienceCoteaching {\n");
            sb.Append("  CoteachingBeginDate: ").Append(CoteachingBeginDate).Append("\n");
            sb.Append("  CoteachingEndDate: ").Append(CoteachingEndDate).Append("\n");
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
            return this.Equals(input as TpdmFieldworkExperienceCoteaching);
        }

        /// <summary>
        /// Returns true if TpdmFieldworkExperienceCoteaching instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmFieldworkExperienceCoteaching to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmFieldworkExperienceCoteaching input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CoteachingBeginDate == input.CoteachingBeginDate ||
                    (this.CoteachingBeginDate != null &&
                    this.CoteachingBeginDate.Equals(input.CoteachingBeginDate))
                ) && 
                (
                    this.CoteachingEndDate == input.CoteachingEndDate ||
                    (this.CoteachingEndDate != null &&
                    this.CoteachingEndDate.Equals(input.CoteachingEndDate))
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
                if (this.CoteachingBeginDate != null)
                    hashCode = hashCode * 59 + this.CoteachingBeginDate.GetHashCode();
                if (this.CoteachingEndDate != null)
                    hashCode = hashCode * 59 + this.CoteachingEndDate.GetHashCode();
                return hashCode;
            }
        }
    }

}
