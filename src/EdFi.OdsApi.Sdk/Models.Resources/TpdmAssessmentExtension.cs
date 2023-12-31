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
    /// TpdmAssessmentExtension
    /// </summary>
    [DataContract]
    public partial class TpdmAssessmentExtension :  IEquatable<TpdmAssessmentExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmAssessmentExtension" /> class.
        /// </summary>
        /// <param name="programGatewayDescriptor">Identifies the program gateway an assessment may be associated with for continuation in the program..</param>
        public TpdmAssessmentExtension(string programGatewayDescriptor = default(string))
        {
            this.ProgramGatewayDescriptor = programGatewayDescriptor;
        }
        
        /// <summary>
        /// Identifies the program gateway an assessment may be associated with for continuation in the program.
        /// </summary>
        /// <value>Identifies the program gateway an assessment may be associated with for continuation in the program.</value>
        [DataMember(Name="programGatewayDescriptor", EmitDefaultValue=false)]
        public string ProgramGatewayDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmAssessmentExtension {\n");
            sb.Append("  ProgramGatewayDescriptor: ").Append(ProgramGatewayDescriptor).Append("\n");
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
            return this.Equals(input as TpdmAssessmentExtension);
        }

        /// <summary>
        /// Returns true if TpdmAssessmentExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmAssessmentExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmAssessmentExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProgramGatewayDescriptor == input.ProgramGatewayDescriptor ||
                    (this.ProgramGatewayDescriptor != null &&
                    this.ProgramGatewayDescriptor.Equals(input.ProgramGatewayDescriptor))
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
                if (this.ProgramGatewayDescriptor != null)
                    hashCode = hashCode * 59 + this.ProgramGatewayDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
