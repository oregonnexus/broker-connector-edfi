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
    /// EdFiStaffLanguage
    /// </summary>
    [DataContract(Name = "edFi_staffLanguage")]
    public partial class EdFiStaffLanguage : IEquatable<EdFiStaffLanguage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffLanguage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffLanguage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffLanguage" /> class.
        /// </summary>
        /// <param name="languageDescriptor">A specification of which written or spoken communication is being used. (required).</param>
        /// <param name="uses">An unordered collection of staffLanguageUses. A description of how the language is used (e.g. Home Language, Native Language, Spoken Language)..</param>
        public EdFiStaffLanguage(string languageDescriptor = default(string), List<EdFiStaffLanguageUse> uses = default(List<EdFiStaffLanguageUse>))
        {
            // to ensure "languageDescriptor" is required (not null)
            if (languageDescriptor == null)
            {
                throw new ArgumentNullException("languageDescriptor is a required property for EdFiStaffLanguage and cannot be null");
            }
            this.LanguageDescriptor = languageDescriptor;
            this.Uses = uses;
        }

        /// <summary>
        /// A specification of which written or spoken communication is being used.
        /// </summary>
        /// <value>A specification of which written or spoken communication is being used.</value>
        [DataMember(Name = "languageDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string LanguageDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of staffLanguageUses. A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).
        /// </summary>
        /// <value>An unordered collection of staffLanguageUses. A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).</value>
        [DataMember(Name = "uses", EmitDefaultValue = false)]
        public List<EdFiStaffLanguageUse> Uses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStaffLanguage {\n");
            sb.Append("  LanguageDescriptor: ").Append(LanguageDescriptor).Append("\n");
            sb.Append("  Uses: ").Append(Uses).Append("\n");
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
            return this.Equals(input as EdFiStaffLanguage);
        }

        /// <summary>
        /// Returns true if EdFiStaffLanguage instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffLanguage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffLanguage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LanguageDescriptor == input.LanguageDescriptor ||
                    (this.LanguageDescriptor != null &&
                    this.LanguageDescriptor.Equals(input.LanguageDescriptor))
                ) && 
                (
                    this.Uses == input.Uses ||
                    this.Uses != null &&
                    input.Uses != null &&
                    this.Uses.SequenceEqual(input.Uses)
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
                if (this.LanguageDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageDescriptor.GetHashCode();
                }
                if (this.Uses != null)
                {
                    hashCode = (hashCode * 59) + this.Uses.GetHashCode();
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
            // LanguageDescriptor (string) maxLength
            if (this.LanguageDescriptor != null && this.LanguageDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LanguageDescriptor, length must be less than 306.", new [] { "LanguageDescriptor" });
            }

            yield break;
        }
    }

}
