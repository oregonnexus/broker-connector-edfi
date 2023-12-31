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
    /// SampleStudentArtProgramAssociationArtMedium
    /// </summary>
    [DataContract]
    public partial class SampleStudentArtProgramAssociationArtMedium :  IEquatable<SampleStudentArtProgramAssociationArtMedium>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentArtProgramAssociationArtMedium" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentArtProgramAssociationArtMedium() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentArtProgramAssociationArtMedium" /> class.
        /// </summary>
        /// <param name="artMediumDescriptor">The art mediums used in the program (i.e., paint, pencils, clay, etc.). (required).</param>
        public SampleStudentArtProgramAssociationArtMedium(string artMediumDescriptor = default(string))
        {
            // to ensure "artMediumDescriptor" is required (not null)
            if (artMediumDescriptor == null)
            {
                throw new InvalidDataException("artMediumDescriptor is a required property for SampleStudentArtProgramAssociationArtMedium and cannot be null");
            }
            else
            {
                this.ArtMediumDescriptor = artMediumDescriptor;
            }
        }
        
        /// <summary>
        /// The art mediums used in the program (i.e., paint, pencils, clay, etc.).
        /// </summary>
        /// <value>The art mediums used in the program (i.e., paint, pencils, clay, etc.).</value>
        [DataMember(Name="artMediumDescriptor", EmitDefaultValue=false)]
        public string ArtMediumDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleStudentArtProgramAssociationArtMedium {\n");
            sb.Append("  ArtMediumDescriptor: ").Append(ArtMediumDescriptor).Append("\n");
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
            return this.Equals(input as SampleStudentArtProgramAssociationArtMedium);
        }

        /// <summary>
        /// Returns true if SampleStudentArtProgramAssociationArtMedium instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentArtProgramAssociationArtMedium to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentArtProgramAssociationArtMedium input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArtMediumDescriptor == input.ArtMediumDescriptor ||
                    (this.ArtMediumDescriptor != null &&
                    this.ArtMediumDescriptor.Equals(input.ArtMediumDescriptor))
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
                    hashCode = hashCode * 59 + this.ArtMediumDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
