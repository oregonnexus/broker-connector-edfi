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
    /// SampleStudentSchoolAssociationExtension
    /// </summary>
    [DataContract(Name = "sample_studentSchoolAssociationExtension")]
    public partial class SampleStudentSchoolAssociationExtension : IEquatable<SampleStudentSchoolAssociationExtension>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentSchoolAssociationExtension" /> class.
        /// </summary>
        /// <param name="membershipTypeDescriptor">Membership Type identifies whether a school has primary responsibility for managing a specific student&#39;s curriculum or not..</param>
        public SampleStudentSchoolAssociationExtension(string membershipTypeDescriptor = default(string))
        {
            this.MembershipTypeDescriptor = membershipTypeDescriptor;
        }

        /// <summary>
        /// Membership Type identifies whether a school has primary responsibility for managing a specific student&#39;s curriculum or not.
        /// </summary>
        /// <value>Membership Type identifies whether a school has primary responsibility for managing a specific student&#39;s curriculum or not.</value>
        [DataMember(Name = "membershipTypeDescriptor", EmitDefaultValue = true)]
        public string MembershipTypeDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SampleStudentSchoolAssociationExtension {\n");
            sb.Append("  MembershipTypeDescriptor: ").Append(MembershipTypeDescriptor).Append("\n");
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
            return this.Equals(input as SampleStudentSchoolAssociationExtension);
        }

        /// <summary>
        /// Returns true if SampleStudentSchoolAssociationExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentSchoolAssociationExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentSchoolAssociationExtension input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MembershipTypeDescriptor == input.MembershipTypeDescriptor ||
                    (this.MembershipTypeDescriptor != null &&
                    this.MembershipTypeDescriptor.Equals(input.MembershipTypeDescriptor))
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
                if (this.MembershipTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.MembershipTypeDescriptor.GetHashCode();
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
            // MembershipTypeDescriptor (string) maxLength
            if (this.MembershipTypeDescriptor != null && this.MembershipTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MembershipTypeDescriptor, length must be less than 306.", new [] { "MembershipTypeDescriptor" });
            }

            yield break;
        }
    }

}
