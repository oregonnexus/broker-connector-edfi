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
    /// SampleStudentGraduationPlanAssociationYearsAttended
    /// </summary>
    [DataContract]
    public partial class SampleStudentGraduationPlanAssociationYearsAttended :  IEquatable<SampleStudentGraduationPlanAssociationYearsAttended>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentGraduationPlanAssociationYearsAttended" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentGraduationPlanAssociationYearsAttended() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentGraduationPlanAssociationYearsAttended" /> class.
        /// </summary>
        /// <param name="yearsAttended">The number of years the student will have attended high school by the time of graduation. (required).</param>
        public SampleStudentGraduationPlanAssociationYearsAttended(int? yearsAttended = default(int?))
        {
            // to ensure "yearsAttended" is required (not null)
            if (yearsAttended == null)
            {
                throw new InvalidDataException("yearsAttended is a required property for SampleStudentGraduationPlanAssociationYearsAttended and cannot be null");
            }
            else
            {
                this.YearsAttended = yearsAttended;
            }
        }
        
        /// <summary>
        /// The number of years the student will have attended high school by the time of graduation.
        /// </summary>
        /// <value>The number of years the student will have attended high school by the time of graduation.</value>
        [DataMember(Name="yearsAttended", EmitDefaultValue=false)]
        public int? YearsAttended { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleStudentGraduationPlanAssociationYearsAttended {\n");
            sb.Append("  YearsAttended: ").Append(YearsAttended).Append("\n");
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
            return this.Equals(input as SampleStudentGraduationPlanAssociationYearsAttended);
        }

        /// <summary>
        /// Returns true if SampleStudentGraduationPlanAssociationYearsAttended instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentGraduationPlanAssociationYearsAttended to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentGraduationPlanAssociationYearsAttended input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.YearsAttended == input.YearsAttended ||
                    (this.YearsAttended != null &&
                    this.YearsAttended.Equals(input.YearsAttended))
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
                if (this.YearsAttended != null)
                    hashCode = hashCode * 59 + this.YearsAttended.GetHashCode();
                return hashCode;
            }
        }
    }

}
