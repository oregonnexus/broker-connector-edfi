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
    /// EdFiCourseReference
    /// </summary>
    [DataContract]
    public partial class EdFiCourseReference :  IEquatable<EdFiCourseReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseReference" /> class.
        /// </summary>
        /// <param name="courseCode">A unique alphanumeric code assigned to a course. (required).</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="link">link.</param>
        public EdFiCourseReference(string courseCode = default(string), int? educationOrganizationId = default(int?), Link link = default(Link))
        {
            // to ensure "courseCode" is required (not null)
            if (courseCode == null)
            {
                throw new InvalidDataException("courseCode is a required property for EdFiCourseReference and cannot be null");
            }
            else
            {
                this.CourseCode = courseCode;
            }
            // to ensure "educationOrganizationId" is required (not null)
            if (educationOrganizationId == null)
            {
                throw new InvalidDataException("educationOrganizationId is a required property for EdFiCourseReference and cannot be null");
            }
            else
            {
                this.EducationOrganizationId = educationOrganizationId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// A unique alphanumeric code assigned to a course.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a course.</value>
        [DataMember(Name="courseCode", EmitDefaultValue=false)]
        public string CourseCode { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name="educationOrganizationId", EmitDefaultValue=false)]
        public int? EducationOrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCourseReference {\n");
            sb.Append("  CourseCode: ").Append(CourseCode).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiCourseReference);
        }

        /// <summary>
        /// Returns true if EdFiCourseReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourseReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourseReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CourseCode == input.CourseCode ||
                    (this.CourseCode != null &&
                    this.CourseCode.Equals(input.CourseCode))
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    (this.EducationOrganizationId != null &&
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.CourseCode != null)
                    hashCode = hashCode * 59 + this.CourseCode.GetHashCode();
                if (this.EducationOrganizationId != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
