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
    /// EdFiOpenStaffPositionAcademicSubject
    /// </summary>
    [DataContract(Name = "edFi_openStaffPositionAcademicSubject")]
    public partial class EdFiOpenStaffPositionAcademicSubject : IEquatable<EdFiOpenStaffPositionAcademicSubject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiOpenStaffPositionAcademicSubject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiOpenStaffPositionAcademicSubject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiOpenStaffPositionAcademicSubject" /> class.
        /// </summary>
        /// <param name="academicSubjectDescriptor">The teaching field required for the open staff position. (required).</param>
        public EdFiOpenStaffPositionAcademicSubject(string academicSubjectDescriptor = default(string))
        {
            // to ensure "academicSubjectDescriptor" is required (not null)
            if (academicSubjectDescriptor == null)
            {
                throw new ArgumentNullException("academicSubjectDescriptor is a required property for EdFiOpenStaffPositionAcademicSubject and cannot be null");
            }
            this.AcademicSubjectDescriptor = academicSubjectDescriptor;
        }

        /// <summary>
        /// The teaching field required for the open staff position.
        /// </summary>
        /// <value>The teaching field required for the open staff position.</value>
        [DataMember(Name = "academicSubjectDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiOpenStaffPositionAcademicSubject {\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
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
            return this.Equals(input as EdFiOpenStaffPositionAcademicSubject);
        }

        /// <summary>
        /// Returns true if EdFiOpenStaffPositionAcademicSubject instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiOpenStaffPositionAcademicSubject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiOpenStaffPositionAcademicSubject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
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
                if (this.AcademicSubjectDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.AcademicSubjectDescriptor.GetHashCode();
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
            // AcademicSubjectDescriptor (string) maxLength
            if (this.AcademicSubjectDescriptor != null && this.AcademicSubjectDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcademicSubjectDescriptor, length must be less than 306.", new [] { "AcademicSubjectDescriptor" });
            }

            yield break;
        }
    }

}
