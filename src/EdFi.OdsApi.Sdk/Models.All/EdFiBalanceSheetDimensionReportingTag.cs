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
    /// EdFiBalanceSheetDimensionReportingTag
    /// </summary>
    [DataContract(Name = "edFi_balanceSheetDimensionReportingTag")]
    public partial class EdFiBalanceSheetDimensionReportingTag : IEquatable<EdFiBalanceSheetDimensionReportingTag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiBalanceSheetDimensionReportingTag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiBalanceSheetDimensionReportingTag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiBalanceSheetDimensionReportingTag" /> class.
        /// </summary>
        /// <param name="reportingTagDescriptor">Optional tag for accountability reporting. (required).</param>
        public EdFiBalanceSheetDimensionReportingTag(string reportingTagDescriptor = default(string))
        {
            // to ensure "reportingTagDescriptor" is required (not null)
            if (reportingTagDescriptor == null)
            {
                throw new ArgumentNullException("reportingTagDescriptor is a required property for EdFiBalanceSheetDimensionReportingTag and cannot be null");
            }
            this.ReportingTagDescriptor = reportingTagDescriptor;
        }

        /// <summary>
        /// Optional tag for accountability reporting.
        /// </summary>
        /// <value>Optional tag for accountability reporting.</value>
        [DataMember(Name = "reportingTagDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string ReportingTagDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiBalanceSheetDimensionReportingTag {\n");
            sb.Append("  ReportingTagDescriptor: ").Append(ReportingTagDescriptor).Append("\n");
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
            return this.Equals(input as EdFiBalanceSheetDimensionReportingTag);
        }

        /// <summary>
        /// Returns true if EdFiBalanceSheetDimensionReportingTag instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiBalanceSheetDimensionReportingTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiBalanceSheetDimensionReportingTag input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReportingTagDescriptor == input.ReportingTagDescriptor ||
                    (this.ReportingTagDescriptor != null &&
                    this.ReportingTagDescriptor.Equals(input.ReportingTagDescriptor))
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
                if (this.ReportingTagDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ReportingTagDescriptor.GetHashCode();
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
            // ReportingTagDescriptor (string) maxLength
            if (this.ReportingTagDescriptor != null && this.ReportingTagDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportingTagDescriptor, length must be less than 306.", new [] { "ReportingTagDescriptor" });
            }

            yield break;
        }
    }

}