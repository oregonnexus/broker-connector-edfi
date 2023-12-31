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
    /// TpdmSurveySectionExtension
    /// </summary>
    [DataContract]
    public partial class TpdmSurveySectionExtension :  IEquatable<TpdmSurveySectionExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmSurveySectionExtension" /> class.
        /// </summary>
        /// <param name="evaluationElementReference">evaluationElementReference.</param>
        public TpdmSurveySectionExtension(TpdmEvaluationElementReference evaluationElementReference = default(TpdmEvaluationElementReference))
        {
            this.EvaluationElementReference = evaluationElementReference;
        }
        
        /// <summary>
        /// Gets or Sets EvaluationElementReference
        /// </summary>
        [DataMember(Name="evaluationElementReference", EmitDefaultValue=false)]
        public TpdmEvaluationElementReference EvaluationElementReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmSurveySectionExtension {\n");
            sb.Append("  EvaluationElementReference: ").Append(EvaluationElementReference).Append("\n");
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
            return this.Equals(input as TpdmSurveySectionExtension);
        }

        /// <summary>
        /// Returns true if TpdmSurveySectionExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmSurveySectionExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmSurveySectionExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EvaluationElementReference == input.EvaluationElementReference ||
                    (this.EvaluationElementReference != null &&
                    this.EvaluationElementReference.Equals(input.EvaluationElementReference))
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
                if (this.EvaluationElementReference != null)
                    hashCode = hashCode * 59 + this.EvaluationElementReference.GetHashCode();
                return hashCode;
            }
        }
    }

}
