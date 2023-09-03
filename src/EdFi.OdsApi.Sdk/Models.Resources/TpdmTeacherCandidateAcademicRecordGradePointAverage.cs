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
    /// TpdmTeacherCandidateAcademicRecordGradePointAverage
    /// </summary>
    [DataContract]
    public partial class TpdmTeacherCandidateAcademicRecordGradePointAverage :  IEquatable<TpdmTeacherCandidateAcademicRecordGradePointAverage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmTeacherCandidateAcademicRecordGradePointAverage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmTeacherCandidateAcademicRecordGradePointAverage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmTeacherCandidateAcademicRecordGradePointAverage" /> class.
        /// </summary>
        /// <param name="gradePointAverageTypeDescriptor">The system used for calculating the grade point average for an individual. (required).</param>
        /// <param name="gradePointAverageValue">The value of the grade points earned divided by the number of credits attempted. (required).</param>
        /// <param name="isCumulative">Indicator of whether or not the Grade Point Average value is cumulative..</param>
        /// <param name="maxGradePointAverageValue">The maximum value for the grade point average..</param>
        public TpdmTeacherCandidateAcademicRecordGradePointAverage(string gradePointAverageTypeDescriptor = default(string), double? gradePointAverageValue = default(double?), bool? isCumulative = default(bool?), double? maxGradePointAverageValue = default(double?))
        {
            // to ensure "gradePointAverageTypeDescriptor" is required (not null)
            if (gradePointAverageTypeDescriptor == null)
            {
                throw new InvalidDataException("gradePointAverageTypeDescriptor is a required property for TpdmTeacherCandidateAcademicRecordGradePointAverage and cannot be null");
            }
            else
            {
                this.GradePointAverageTypeDescriptor = gradePointAverageTypeDescriptor;
            }
            // to ensure "gradePointAverageValue" is required (not null)
            if (gradePointAverageValue == null)
            {
                throw new InvalidDataException("gradePointAverageValue is a required property for TpdmTeacherCandidateAcademicRecordGradePointAverage and cannot be null");
            }
            else
            {
                this.GradePointAverageValue = gradePointAverageValue;
            }
            this.IsCumulative = isCumulative;
            this.MaxGradePointAverageValue = maxGradePointAverageValue;
        }
        
        /// <summary>
        /// The system used for calculating the grade point average for an individual.
        /// </summary>
        /// <value>The system used for calculating the grade point average for an individual.</value>
        [DataMember(Name="gradePointAverageTypeDescriptor", EmitDefaultValue=false)]
        public string GradePointAverageTypeDescriptor { get; set; }

        /// <summary>
        /// The value of the grade points earned divided by the number of credits attempted.
        /// </summary>
        /// <value>The value of the grade points earned divided by the number of credits attempted.</value>
        [DataMember(Name="gradePointAverageValue", EmitDefaultValue=false)]
        public double? GradePointAverageValue { get; set; }

        /// <summary>
        /// Indicator of whether or not the Grade Point Average value is cumulative.
        /// </summary>
        /// <value>Indicator of whether or not the Grade Point Average value is cumulative.</value>
        [DataMember(Name="isCumulative", EmitDefaultValue=false)]
        public bool? IsCumulative { get; set; }

        /// <summary>
        /// The maximum value for the grade point average.
        /// </summary>
        /// <value>The maximum value for the grade point average.</value>
        [DataMember(Name="maxGradePointAverageValue", EmitDefaultValue=false)]
        public double? MaxGradePointAverageValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmTeacherCandidateAcademicRecordGradePointAverage {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TpdmTeacherCandidateAcademicRecordGradePointAverage);
        }

        /// <summary>
        /// Returns true if TpdmTeacherCandidateAcademicRecordGradePointAverage instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmTeacherCandidateAcademicRecordGradePointAverage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmTeacherCandidateAcademicRecordGradePointAverage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GradePointAverageTypeDescriptor == input.GradePointAverageTypeDescriptor ||
                    (this.GradePointAverageTypeDescriptor != null &&
                    this.GradePointAverageTypeDescriptor.Equals(input.GradePointAverageTypeDescriptor))
                ) && 
                (
                    this.GradePointAverageValue == input.GradePointAverageValue ||
                    (this.GradePointAverageValue != null &&
                    this.GradePointAverageValue.Equals(input.GradePointAverageValue))
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
                    hashCode = hashCode * 59 + this.GradePointAverageTypeDescriptor.GetHashCode();
                if (this.GradePointAverageValue != null)
                    hashCode = hashCode * 59 + this.GradePointAverageValue.GetHashCode();
                if (this.IsCumulative != null)
                    hashCode = hashCode * 59 + this.IsCumulative.GetHashCode();
                if (this.MaxGradePointAverageValue != null)
                    hashCode = hashCode * 59 + this.MaxGradePointAverageValue.GetHashCode();
                return hashCode;
            }
        }
    }

}
