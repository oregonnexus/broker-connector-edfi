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
    /// SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed
    /// </summary>
    [DataContract(Name = "sample_studentEducationOrganizationAssociationStudentCharacteristicStudentNeed")]
    public partial class SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed : IEquatable<SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed" /> class.
        /// </summary>
        /// <param name="beginDate">The month, day, and year for the start of the period. (required).</param>
        /// <param name="endDate">The month, day, and year for the end of the period..</param>
        /// <param name="primaryStudentNeedIndicator">Indicates the parent characteristic is a primary student need..</param>
        public SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed(DateTime beginDate = default(DateTime), DateTime? endDate = default(DateTime?), bool? primaryStudentNeedIndicator = default(bool?))
        {
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            this.PrimaryStudentNeedIndicator = primaryStudentNeedIndicator;
        }

        /// <summary>
        /// The month, day, and year for the start of the period.
        /// </summary>
        /// <value>The month, day, and year for the start of the period.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// The month, day, and year for the end of the period.
        /// </summary>
        /// <value>The month, day, and year for the end of the period.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Indicates the parent characteristic is a primary student need.
        /// </summary>
        /// <value>Indicates the parent characteristic is a primary student need.</value>
        [DataMember(Name = "primaryStudentNeedIndicator", EmitDefaultValue = true)]
        public bool? PrimaryStudentNeedIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed {\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PrimaryStudentNeedIndicator: ").Append(PrimaryStudentNeedIndicator).Append("\n");
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
            return this.Equals(input as SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed);
        }

        /// <summary>
        /// Returns true if SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.PrimaryStudentNeedIndicator == input.PrimaryStudentNeedIndicator ||
                    (this.PrimaryStudentNeedIndicator != null &&
                    this.PrimaryStudentNeedIndicator.Equals(input.PrimaryStudentNeedIndicator))
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
                if (this.BeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.PrimaryStudentNeedIndicator != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryStudentNeedIndicator.GetHashCode();
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
