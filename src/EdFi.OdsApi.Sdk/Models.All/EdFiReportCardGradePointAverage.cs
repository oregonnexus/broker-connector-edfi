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
    /// EdFiReportCardGradePointAverage
    /// </summary>
    [DataContract(Name = "edFi_reportCardGradePointAverage")]
    public partial class EdFiReportCardGradePointAverage : IEquatable<EdFiReportCardGradePointAverage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCardGradePointAverage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiReportCardGradePointAverage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCardGradePointAverage" /> class.
        /// </summary>
        /// <param name="gradePointAverageTypeDescriptor">The system used for calculating the grade point average for an individual. (required).</param>
        /// <param name="gradePointAverageValue">The value of the grade points earned divided by the number of credits attempted. (required).</param>
        /// <param name="isCumulative">Indicator of whether or not the Grade Point Average value is cumulative..</param>
        /// <param name="maxGradePointAverageValue">The maximum value for the grade point average..</param>
        public EdFiReportCardGradePointAverage(string gradePointAverageTypeDescriptor = default(string), double gradePointAverageValue = default(double), bool? isCumulative = default(bool?), double? maxGradePointAverageValue = default(double?))
        {
            // to ensure "gradePointAverageTypeDescriptor" is required (not null)
            if (gradePointAverageTypeDescriptor == null)
            {
                throw new ArgumentNullException("gradePointAverageTypeDescriptor is a required property for EdFiReportCardGradePointAverage and cannot be null");
            }
            this.GradePointAverageTypeDescriptor = gradePointAverageTypeDescriptor;
            this.GradePointAverageValue = gradePointAverageValue;
            this.IsCumulative = isCumulative;
            this.MaxGradePointAverageValue = maxGradePointAverageValue;
        }

        /// <summary>
        /// The system used for calculating the grade point average for an individual.
        /// </summary>
        /// <value>The system used for calculating the grade point average for an individual.</value>
        [DataMember(Name = "gradePointAverageTypeDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string GradePointAverageTypeDescriptor { get; set; }

        /// <summary>
        /// The value of the grade points earned divided by the number of credits attempted.
        /// </summary>
        /// <value>The value of the grade points earned divided by the number of credits attempted.</value>
        [DataMember(Name = "gradePointAverageValue", IsRequired = true, EmitDefaultValue = true)]
        public double GradePointAverageValue { get; set; }

        /// <summary>
        /// Indicator of whether or not the Grade Point Average value is cumulative.
        /// </summary>
        /// <value>Indicator of whether or not the Grade Point Average value is cumulative.</value>
        [DataMember(Name = "isCumulative", EmitDefaultValue = true)]
        public bool? IsCumulative { get; set; }

        /// <summary>
        /// The maximum value for the grade point average.
        /// </summary>
        /// <value>The maximum value for the grade point average.</value>
        [DataMember(Name = "maxGradePointAverageValue", EmitDefaultValue = true)]
        public double? MaxGradePointAverageValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiReportCardGradePointAverage {\n");
            sb.Append("  GradePointAverageTypeDescriptor: ").Append(GradePointAverageTypeDescriptor).Append("\n");
            sb.Append("  GradePointAverageValue: ").Append(GradePointAverageValue).Append("\n");
            sb.Append("  IsCumulative: ").Append(IsCumulative).Append("\n");
            sb.Append("  MaxGradePointAverageValue: ").Append(MaxGradePointAverageValue).Append("\n");
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
            return this.Equals(input as EdFiReportCardGradePointAverage);
        }

        /// <summary>
        /// Returns true if EdFiReportCardGradePointAverage instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiReportCardGradePointAverage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiReportCardGradePointAverage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GradePointAverageTypeDescriptor == input.GradePointAverageTypeDescriptor ||
                    (this.GradePointAverageTypeDescriptor != null &&
                    this.GradePointAverageTypeDescriptor.Equals(input.GradePointAverageTypeDescriptor))
                ) && 
                (
                    this.GradePointAverageValue == input.GradePointAverageValue ||
                    this.GradePointAverageValue.Equals(input.GradePointAverageValue)
                ) && 
                (
                    this.IsCumulative == input.IsCumulative ||
                    (this.IsCumulative != null &&
                    this.IsCumulative.Equals(input.IsCumulative))
                ) && 
                (
                    this.MaxGradePointAverageValue == input.MaxGradePointAverageValue ||
                    (this.MaxGradePointAverageValue != null &&
                    this.MaxGradePointAverageValue.Equals(input.MaxGradePointAverageValue))
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
                if (this.GradePointAverageTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.GradePointAverageTypeDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GradePointAverageValue.GetHashCode();
                if (this.IsCumulative != null)
                {
                    hashCode = (hashCode * 59) + this.IsCumulative.GetHashCode();
                }
                if (this.MaxGradePointAverageValue != null)
                {
                    hashCode = (hashCode * 59) + this.MaxGradePointAverageValue.GetHashCode();
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
            // GradePointAverageTypeDescriptor (string) maxLength
            if (this.GradePointAverageTypeDescriptor != null && this.GradePointAverageTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradePointAverageTypeDescriptor, length must be less than 306.", new [] { "GradePointAverageTypeDescriptor" });
            }

            // GradePointAverageValue (double) minimum
            if (this.GradePointAverageValue < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradePointAverageValue, must be a value greater than or equal to 0.", new [] { "GradePointAverageValue" });
            }

            // MaxGradePointAverageValue (double?) minimum
            if (this.MaxGradePointAverageValue < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxGradePointAverageValue, must be a value greater than or equal to 0.", new [] { "MaxGradePointAverageValue" });
            }

            yield break;
        }
    }

}
