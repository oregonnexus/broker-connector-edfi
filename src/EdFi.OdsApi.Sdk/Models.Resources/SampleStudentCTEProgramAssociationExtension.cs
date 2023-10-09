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
    /// SampleStudentCTEProgramAssociationExtension
    /// </summary>
    [DataContract]
    public partial class SampleStudentCTEProgramAssociationExtension :  IEquatable<SampleStudentCTEProgramAssociationExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentCTEProgramAssociationExtension" /> class.
        /// </summary>
        /// <param name="analysisCompleted">A unique identification code used to identify the student&#39;s artwork produced in the program..</param>
        /// <param name="analysisDate">The date and time the CTEProgram analysis was completed..</param>
        public SampleStudentCTEProgramAssociationExtension(bool? analysisCompleted = default(bool?), DateTime? analysisDate = default(DateTime?))
        {
            this.AnalysisCompleted = analysisCompleted;
            this.AnalysisDate = analysisDate;
        }
        
        /// <summary>
        /// A unique identification code used to identify the student&#39;s artwork produced in the program.
        /// </summary>
        /// <value>A unique identification code used to identify the student&#39;s artwork produced in the program.</value>
        [DataMember(Name="analysisCompleted", EmitDefaultValue=false)]
        public bool? AnalysisCompleted { get; set; }

        /// <summary>
        /// The date and time the CTEProgram analysis was completed.
        /// </summary>
        /// <value>The date and time the CTEProgram analysis was completed.</value>
        [DataMember(Name="analysisDate", EmitDefaultValue=false)]
        public DateTime? AnalysisDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleStudentCTEProgramAssociationExtension {\n");
            sb.Append("  AnalysisCompleted: ").Append(AnalysisCompleted).Append("\n");
            sb.Append("  AnalysisDate: ").Append(AnalysisDate).Append("\n");
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
            return this.Equals(input as SampleStudentCTEProgramAssociationExtension);
        }

        /// <summary>
        /// Returns true if SampleStudentCTEProgramAssociationExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentCTEProgramAssociationExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentCTEProgramAssociationExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AnalysisCompleted == input.AnalysisCompleted ||
                    (this.AnalysisCompleted != null &&
                    this.AnalysisCompleted.Equals(input.AnalysisCompleted))
                ) && 
                (
                    this.AnalysisDate == input.AnalysisDate ||
                    (this.AnalysisDate != null &&
                    this.AnalysisDate.Equals(input.AnalysisDate))
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
                if (this.AnalysisCompleted != null)
                    hashCode = hashCode * 59 + this.AnalysisCompleted.GetHashCode();
                if (this.AnalysisDate != null)
                    hashCode = hashCode * 59 + this.AnalysisDate.GetHashCode();
                return hashCode;
            }
        }
    }

}
