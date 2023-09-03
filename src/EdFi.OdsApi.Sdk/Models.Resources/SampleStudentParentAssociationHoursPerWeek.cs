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
    /// SampleStudentParentAssociationHoursPerWeek
    /// </summary>
    [DataContract]
    public partial class SampleStudentParentAssociationHoursPerWeek :  IEquatable<SampleStudentParentAssociationHoursPerWeek>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentParentAssociationHoursPerWeek" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentParentAssociationHoursPerWeek() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentParentAssociationHoursPerWeek" /> class.
        /// </summary>
        /// <param name="hoursPerWeek">Total number of hours per week a student and parent dedicates to reading. (required).</param>
        public SampleStudentParentAssociationHoursPerWeek(double? hoursPerWeek = default(double?))
        {
            // to ensure "hoursPerWeek" is required (not null)
            if (hoursPerWeek == null)
            {
                throw new InvalidDataException("hoursPerWeek is a required property for SampleStudentParentAssociationHoursPerWeek and cannot be null");
            }
            else
            {
                this.HoursPerWeek = hoursPerWeek;
            }
        }
        
        /// <summary>
        /// Total number of hours per week a student and parent dedicates to reading.
        /// </summary>
        /// <value>Total number of hours per week a student and parent dedicates to reading.</value>
        [DataMember(Name="hoursPerWeek", EmitDefaultValue=false)]
        public double? HoursPerWeek { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleStudentParentAssociationHoursPerWeek {\n");
            sb.Append("  HoursPerWeek: ").Append(HoursPerWeek).Append("\n");
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
            return this.Equals(input as SampleStudentParentAssociationHoursPerWeek);
        }

        /// <summary>
        /// Returns true if SampleStudentParentAssociationHoursPerWeek instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentParentAssociationHoursPerWeek to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentParentAssociationHoursPerWeek input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HoursPerWeek == input.HoursPerWeek ||
                    (this.HoursPerWeek != null &&
                    this.HoursPerWeek.Equals(input.HoursPerWeek))
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
                if (this.HoursPerWeek != null)
                    hashCode = hashCode * 59 + this.HoursPerWeek.GetHashCode();
                return hashCode;
            }
        }
    }

}
