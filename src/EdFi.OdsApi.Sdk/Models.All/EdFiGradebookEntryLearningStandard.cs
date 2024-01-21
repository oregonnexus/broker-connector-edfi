/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// EdFiGradebookEntryLearningStandard
    /// </summary>
    [DataContract(Name = "edFi_gradebookEntryLearningStandard")]
    public partial class EdFiGradebookEntryLearningStandard : IEquatable<EdFiGradebookEntryLearningStandard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradebookEntryLearningStandard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGradebookEntryLearningStandard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradebookEntryLearningStandard" /> class.
        /// </summary>
        /// <param name="learningStandardReference">learningStandardReference (required).</param>
        public EdFiGradebookEntryLearningStandard(EdFiLearningStandardReference learningStandardReference = default(EdFiLearningStandardReference))
        {
            // to ensure "learningStandardReference" is required (not null)
            if (learningStandardReference == null)
            {
                throw new ArgumentNullException("learningStandardReference is a required property for EdFiGradebookEntryLearningStandard and cannot be null");
            }
            this.LearningStandardReference = learningStandardReference;
        }

        /// <summary>
        /// Gets or Sets LearningStandardReference
        /// </summary>
        [DataMember(Name = "learningStandardReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiLearningStandardReference LearningStandardReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiGradebookEntryLearningStandard {\n");
            sb.Append("  LearningStandardReference: ").Append(LearningStandardReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiGradebookEntryLearningStandard);
        }

        /// <summary>
        /// Returns true if EdFiGradebookEntryLearningStandard instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGradebookEntryLearningStandard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGradebookEntryLearningStandard input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LearningStandardReference == input.LearningStandardReference ||
                    (this.LearningStandardReference != null &&
                    this.LearningStandardReference.Equals(input.LearningStandardReference))
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
                if (this.LearningStandardReference != null)
                {
                    hashCode = (hashCode * 59) + this.LearningStandardReference.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
