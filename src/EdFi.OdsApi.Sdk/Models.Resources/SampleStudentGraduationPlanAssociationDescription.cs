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
    /// SampleStudentGraduationPlanAssociationDescription
    /// </summary>
    [DataContract]
    public partial class SampleStudentGraduationPlanAssociationDescription :  IEquatable<SampleStudentGraduationPlanAssociationDescription>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentGraduationPlanAssociationDescription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentGraduationPlanAssociationDescription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentGraduationPlanAssociationDescription" /> class.
        /// </summary>
        /// <param name="description">A description of the graduation plan. (required).</param>
        public SampleStudentGraduationPlanAssociationDescription(string description = default(string))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for SampleStudentGraduationPlanAssociationDescription and cannot be null");
            }
            else
            {
                this.Description = description;
            }
        }
        
        /// <summary>
        /// A description of the graduation plan.
        /// </summary>
        /// <value>A description of the graduation plan.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleStudentGraduationPlanAssociationDescription {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as SampleStudentGraduationPlanAssociationDescription);
        }

        /// <summary>
        /// Returns true if SampleStudentGraduationPlanAssociationDescription instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentGraduationPlanAssociationDescription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentGraduationPlanAssociationDescription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }

}
