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
    /// EdFiGraduationPlanCreditsByCourseCourse
    /// </summary>
    [DataContract]
    public partial class EdFiGraduationPlanCreditsByCourseCourse :  IEquatable<EdFiGraduationPlanCreditsByCourseCourse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanCreditsByCourseCourse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGraduationPlanCreditsByCourseCourse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanCreditsByCourseCourse" /> class.
        /// </summary>
        /// <param name="courseReference">courseReference (required).</param>
        public EdFiGraduationPlanCreditsByCourseCourse(EdFiCourseReference courseReference = default(EdFiCourseReference))
        {
            // to ensure "courseReference" is required (not null)
            if (courseReference == null)
            {
                throw new InvalidDataException("courseReference is a required property for EdFiGraduationPlanCreditsByCourseCourse and cannot be null");
            }
            else
            {
                this.CourseReference = courseReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets CourseReference
        /// </summary>
        [DataMember(Name="courseReference", EmitDefaultValue=false)]
        public EdFiCourseReference CourseReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiGraduationPlanCreditsByCourseCourse {\n");
            sb.Append("  CourseReference: ").Append(CourseReference).Append("\n");
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
            return this.Equals(input as EdFiGraduationPlanCreditsByCourseCourse);
        }

        /// <summary>
        /// Returns true if EdFiGraduationPlanCreditsByCourseCourse instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGraduationPlanCreditsByCourseCourse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGraduationPlanCreditsByCourseCourse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CourseReference == input.CourseReference ||
                    (this.CourseReference != null &&
                    this.CourseReference.Equals(input.CourseReference))
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
                if (this.CourseReference != null)
                    hashCode = hashCode * 59 + this.CourseReference.GetHashCode();
                return hashCode;
            }
        }
    }

}
