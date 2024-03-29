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
    /// SampleStudentPetPreference
    /// </summary>
    [DataContract(Name = "sample_studentPetPreference")]
    public partial class SampleStudentPetPreference : IEquatable<SampleStudentPetPreference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentPetPreference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentPetPreference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentPetPreference" /> class.
        /// </summary>
        /// <param name="maximumWeight">The preferred maximum weight of a household pet. (required).</param>
        /// <param name="minimumWeight">The preferred minimum weight of a household pet. (required).</param>
        public SampleStudentPetPreference(int maximumWeight = default(int), int minimumWeight = default(int))
        {
            this.MaximumWeight = maximumWeight;
            this.MinimumWeight = minimumWeight;
        }

        /// <summary>
        /// The preferred maximum weight of a household pet.
        /// </summary>
        /// <value>The preferred maximum weight of a household pet.</value>
        [DataMember(Name = "maximumWeight", IsRequired = true, EmitDefaultValue = true)]
        public int MaximumWeight { get; set; }

        /// <summary>
        /// The preferred minimum weight of a household pet.
        /// </summary>
        /// <value>The preferred minimum weight of a household pet.</value>
        [DataMember(Name = "minimumWeight", IsRequired = true, EmitDefaultValue = true)]
        public int MinimumWeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SampleStudentPetPreference {\n");
            sb.Append("  MaximumWeight: ").Append(MaximumWeight).Append("\n");
            sb.Append("  MinimumWeight: ").Append(MinimumWeight).Append("\n");
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
            return this.Equals(input as SampleStudentPetPreference);
        }

        /// <summary>
        /// Returns true if SampleStudentPetPreference instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentPetPreference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentPetPreference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaximumWeight == input.MaximumWeight ||
                    this.MaximumWeight.Equals(input.MaximumWeight)
                ) && 
                (
                    this.MinimumWeight == input.MinimumWeight ||
                    this.MinimumWeight.Equals(input.MinimumWeight)
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
                hashCode = (hashCode * 59) + this.MaximumWeight.GetHashCode();
                hashCode = (hashCode * 59) + this.MinimumWeight.GetHashCode();
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
