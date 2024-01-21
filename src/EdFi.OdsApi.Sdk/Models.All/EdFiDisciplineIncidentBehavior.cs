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
    /// EdFiDisciplineIncidentBehavior
    /// </summary>
    [DataContract(Name = "edFi_disciplineIncidentBehavior")]
    public partial class EdFiDisciplineIncidentBehavior : IEquatable<EdFiDisciplineIncidentBehavior>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineIncidentBehavior" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiDisciplineIncidentBehavior() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineIncidentBehavior" /> class.
        /// </summary>
        /// <param name="behaviorDescriptor">Describes behavior by category and provides a detailed description. (required).</param>
        /// <param name="behaviorDetailedDescription">Specifies a more granular level of detail of a behavior involved in the incident..</param>
        public EdFiDisciplineIncidentBehavior(string behaviorDescriptor = default(string), string behaviorDetailedDescription = default(string))
        {
            // to ensure "behaviorDescriptor" is required (not null)
            if (behaviorDescriptor == null)
            {
                throw new ArgumentNullException("behaviorDescriptor is a required property for EdFiDisciplineIncidentBehavior and cannot be null");
            }
            this.BehaviorDescriptor = behaviorDescriptor;
            this.BehaviorDetailedDescription = behaviorDetailedDescription;
        }

        /// <summary>
        /// Describes behavior by category and provides a detailed description.
        /// </summary>
        /// <value>Describes behavior by category and provides a detailed description.</value>
        [DataMember(Name = "behaviorDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string BehaviorDescriptor { get; set; }

        /// <summary>
        /// Specifies a more granular level of detail of a behavior involved in the incident.
        /// </summary>
        /// <value>Specifies a more granular level of detail of a behavior involved in the incident.</value>
        [DataMember(Name = "behaviorDetailedDescription", EmitDefaultValue = true)]
        public string BehaviorDetailedDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiDisciplineIncidentBehavior {\n");
            sb.Append("  BehaviorDescriptor: ").Append(BehaviorDescriptor).Append("\n");
            sb.Append("  BehaviorDetailedDescription: ").Append(BehaviorDetailedDescription).Append("\n");
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
            return this.Equals(input as EdFiDisciplineIncidentBehavior);
        }

        /// <summary>
        /// Returns true if EdFiDisciplineIncidentBehavior instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiDisciplineIncidentBehavior to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiDisciplineIncidentBehavior input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BehaviorDescriptor == input.BehaviorDescriptor ||
                    (this.BehaviorDescriptor != null &&
                    this.BehaviorDescriptor.Equals(input.BehaviorDescriptor))
                ) && 
                (
                    this.BehaviorDetailedDescription == input.BehaviorDetailedDescription ||
                    (this.BehaviorDetailedDescription != null &&
                    this.BehaviorDetailedDescription.Equals(input.BehaviorDetailedDescription))
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
                if (this.BehaviorDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.BehaviorDescriptor.GetHashCode();
                }
                if (this.BehaviorDetailedDescription != null)
                {
                    hashCode = (hashCode * 59) + this.BehaviorDetailedDescription.GetHashCode();
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
            // BehaviorDescriptor (string) maxLength
            if (this.BehaviorDescriptor != null && this.BehaviorDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BehaviorDescriptor, length must be less than 306.", new [] { "BehaviorDescriptor" });
            }

            // BehaviorDetailedDescription (string) maxLength
            if (this.BehaviorDetailedDescription != null && this.BehaviorDetailedDescription.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BehaviorDetailedDescription, length must be less than 1024.", new [] { "BehaviorDetailedDescription" });
            }

            // BehaviorDetailedDescription (string) minLength
            if (this.BehaviorDetailedDescription != null && this.BehaviorDetailedDescription.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BehaviorDetailedDescription, length must be greater than 1.", new [] { "BehaviorDetailedDescription" });
            }

            yield break;
        }
    }

}
