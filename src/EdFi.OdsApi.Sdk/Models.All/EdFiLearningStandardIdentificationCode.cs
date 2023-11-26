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
    /// EdFiLearningStandardIdentificationCode
    /// </summary>
    [DataContract(Name = "edFi_learningStandardIdentificationCode")]
    public partial class EdFiLearningStandardIdentificationCode : IEquatable<EdFiLearningStandardIdentificationCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningStandardIdentificationCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLearningStandardIdentificationCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningStandardIdentificationCode" /> class.
        /// </summary>
        /// <param name="contentStandardName">The name of the content standard, for example Common Core. (required).</param>
        /// <param name="identificationCode">A unique number or alphanumeric code assigned to a Learning Standard. (required).</param>
        public EdFiLearningStandardIdentificationCode(string contentStandardName = default(string), string identificationCode = default(string))
        {
            // to ensure "contentStandardName" is required (not null)
            if (contentStandardName == null)
            {
                throw new ArgumentNullException("contentStandardName is a required property for EdFiLearningStandardIdentificationCode and cannot be null");
            }
            this.ContentStandardName = contentStandardName;
            // to ensure "identificationCode" is required (not null)
            if (identificationCode == null)
            {
                throw new ArgumentNullException("identificationCode is a required property for EdFiLearningStandardIdentificationCode and cannot be null");
            }
            this.IdentificationCode = identificationCode;
        }

        /// <summary>
        /// The name of the content standard, for example Common Core.
        /// </summary>
        /// <value>The name of the content standard, for example Common Core.</value>
        [DataMember(Name = "contentStandardName", IsRequired = true, EmitDefaultValue = true)]
        public string ContentStandardName { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a Learning Standard.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a Learning Standard.</value>
        [DataMember(Name = "identificationCode", IsRequired = true, EmitDefaultValue = true)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiLearningStandardIdentificationCode {\n");
            sb.Append("  ContentStandardName: ").Append(ContentStandardName).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
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
            return this.Equals(input as EdFiLearningStandardIdentificationCode);
        }

        /// <summary>
        /// Returns true if EdFiLearningStandardIdentificationCode instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLearningStandardIdentificationCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLearningStandardIdentificationCode input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentStandardName == input.ContentStandardName ||
                    (this.ContentStandardName != null &&
                    this.ContentStandardName.Equals(input.ContentStandardName))
                ) && 
                (
                    this.IdentificationCode == input.IdentificationCode ||
                    (this.IdentificationCode != null &&
                    this.IdentificationCode.Equals(input.IdentificationCode))
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
                if (this.ContentStandardName != null)
                {
                    hashCode = (hashCode * 59) + this.ContentStandardName.GetHashCode();
                }
                if (this.IdentificationCode != null)
                {
                    hashCode = (hashCode * 59) + this.IdentificationCode.GetHashCode();
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
            // ContentStandardName (string) maxLength
            if (this.ContentStandardName != null && this.ContentStandardName.Length > 65)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContentStandardName, length must be less than 65.", new [] { "ContentStandardName" });
            }

            // ContentStandardName (string) minLength
            if (this.ContentStandardName != null && this.ContentStandardName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContentStandardName, length must be greater than 1.", new [] { "ContentStandardName" });
            }

            // IdentificationCode (string) maxLength
            if (this.IdentificationCode != null && this.IdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationCode, length must be less than 60.", new [] { "IdentificationCode" });
            }

            // IdentificationCode (string) minLength
            if (this.IdentificationCode != null && this.IdentificationCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationCode, length must be greater than 1.", new [] { "IdentificationCode" });
            }

            yield break;
        }
    }

}