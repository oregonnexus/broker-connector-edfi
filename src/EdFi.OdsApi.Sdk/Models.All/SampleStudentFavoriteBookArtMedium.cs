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
    /// SampleStudentFavoriteBookArtMedium
    /// </summary>
    [DataContract(Name = "sample_studentFavoriteBookArtMedium")]
    public partial class SampleStudentFavoriteBookArtMedium : IEquatable<SampleStudentFavoriteBookArtMedium>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentFavoriteBookArtMedium" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentFavoriteBookArtMedium() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentFavoriteBookArtMedium" /> class.
        /// </summary>
        /// <param name="artMediumDescriptor">This is documentation. (required).</param>
        /// <param name="artPieces">This is documentation..</param>
        public SampleStudentFavoriteBookArtMedium(string artMediumDescriptor = default(string), int? artPieces = default(int?))
        {
            // to ensure "artMediumDescriptor" is required (not null)
            if (artMediumDescriptor == null)
            {
                throw new ArgumentNullException("artMediumDescriptor is a required property for SampleStudentFavoriteBookArtMedium and cannot be null");
            }
            this.ArtMediumDescriptor = artMediumDescriptor;
            this.ArtPieces = artPieces;
        }

        /// <summary>
        /// This is documentation.
        /// </summary>
        /// <value>This is documentation.</value>
        [DataMember(Name = "artMediumDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string ArtMediumDescriptor { get; set; }

        /// <summary>
        /// This is documentation.
        /// </summary>
        /// <value>This is documentation.</value>
        [DataMember(Name = "artPieces", EmitDefaultValue = true)]
        public int? ArtPieces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SampleStudentFavoriteBookArtMedium {\n");
            sb.Append("  ArtMediumDescriptor: ").Append(ArtMediumDescriptor).Append("\n");
            sb.Append("  ArtPieces: ").Append(ArtPieces).Append("\n");
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
            return this.Equals(input as SampleStudentFavoriteBookArtMedium);
        }

        /// <summary>
        /// Returns true if SampleStudentFavoriteBookArtMedium instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentFavoriteBookArtMedium to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentFavoriteBookArtMedium input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ArtMediumDescriptor == input.ArtMediumDescriptor ||
                    (this.ArtMediumDescriptor != null &&
                    this.ArtMediumDescriptor.Equals(input.ArtMediumDescriptor))
                ) && 
                (
                    this.ArtPieces == input.ArtPieces ||
                    (this.ArtPieces != null &&
                    this.ArtPieces.Equals(input.ArtPieces))
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
                if (this.ArtMediumDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ArtMediumDescriptor.GetHashCode();
                }
                if (this.ArtPieces != null)
                {
                    hashCode = (hashCode * 59) + this.ArtPieces.GetHashCode();
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
            // ArtMediumDescriptor (string) maxLength
            if (this.ArtMediumDescriptor != null && this.ArtMediumDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ArtMediumDescriptor, length must be less than 306.", new [] { "ArtMediumDescriptor" });
            }

            // ArtPieces (int?) maximum
            if (this.ArtPieces > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ArtPieces, must be a value less than or equal to 100.", new [] { "ArtPieces" });
            }

            // ArtPieces (int?) minimum
            if (this.ArtPieces < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ArtPieces, must be a value greater than or equal to 0.", new [] { "ArtPieces" });
            }

            yield break;
        }
    }

}
