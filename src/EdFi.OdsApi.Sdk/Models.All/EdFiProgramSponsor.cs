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
    /// EdFiProgramSponsor
    /// </summary>
    [DataContract(Name = "edFi_programSponsor")]
    public partial class EdFiProgramSponsor : IEquatable<EdFiProgramSponsor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiProgramSponsor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiProgramSponsor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiProgramSponsor" /> class.
        /// </summary>
        /// <param name="programSponsorDescriptor">Ultimate and intermediate providers of funds for a particular educational or service program or activity, or for an individual&#39;s participation in the program or activity (e.g., Federal, State, ESC, District, School, Private Organization). (required).</param>
        public EdFiProgramSponsor(string programSponsorDescriptor = default(string))
        {
            // to ensure "programSponsorDescriptor" is required (not null)
            if (programSponsorDescriptor == null)
            {
                throw new ArgumentNullException("programSponsorDescriptor is a required property for EdFiProgramSponsor and cannot be null");
            }
            this.ProgramSponsorDescriptor = programSponsorDescriptor;
        }

        /// <summary>
        /// Ultimate and intermediate providers of funds for a particular educational or service program or activity, or for an individual&#39;s participation in the program or activity (e.g., Federal, State, ESC, District, School, Private Organization).
        /// </summary>
        /// <value>Ultimate and intermediate providers of funds for a particular educational or service program or activity, or for an individual&#39;s participation in the program or activity (e.g., Federal, State, ESC, District, School, Private Organization).</value>
        [DataMember(Name = "programSponsorDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string ProgramSponsorDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiProgramSponsor {\n");
            sb.Append("  ProgramSponsorDescriptor: ").Append(ProgramSponsorDescriptor).Append("\n");
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
            return this.Equals(input as EdFiProgramSponsor);
        }

        /// <summary>
        /// Returns true if EdFiProgramSponsor instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiProgramSponsor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiProgramSponsor input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProgramSponsorDescriptor == input.ProgramSponsorDescriptor ||
                    (this.ProgramSponsorDescriptor != null &&
                    this.ProgramSponsorDescriptor.Equals(input.ProgramSponsorDescriptor))
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
                if (this.ProgramSponsorDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramSponsorDescriptor.GetHashCode();
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
            // ProgramSponsorDescriptor (string) maxLength
            if (this.ProgramSponsorDescriptor != null && this.ProgramSponsorDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramSponsorDescriptor, length must be less than 306.", new [] { "ProgramSponsorDescriptor" });
            }

            yield break;
        }
    }

}
