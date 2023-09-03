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
    /// TpdmAnonymizedStudentAssessmentCourseAssociation
    /// </summary>
    [DataContract]
    public partial class TpdmAnonymizedStudentAssessmentCourseAssociation :  IEquatable<TpdmAnonymizedStudentAssessmentCourseAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmAnonymizedStudentAssessmentCourseAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmAnonymizedStudentAssessmentCourseAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmAnonymizedStudentAssessmentCourseAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="anonymizedStudentAssessmentReference">anonymizedStudentAssessmentReference (required).</param>
        /// <param name="courseReference">courseReference (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmAnonymizedStudentAssessmentCourseAssociation(string id = default(string), TpdmAnonymizedStudentAssessmentReference anonymizedStudentAssessmentReference = default(TpdmAnonymizedStudentAssessmentReference), EdFiCourseReference courseReference = default(EdFiCourseReference), string etag = default(string))
        {
            // to ensure "anonymizedStudentAssessmentReference" is required (not null)
            if (anonymizedStudentAssessmentReference == null)
            {
                throw new InvalidDataException("anonymizedStudentAssessmentReference is a required property for TpdmAnonymizedStudentAssessmentCourseAssociation and cannot be null");
            }
            else
            {
                this.AnonymizedStudentAssessmentReference = anonymizedStudentAssessmentReference;
            }
            // to ensure "courseReference" is required (not null)
            if (courseReference == null)
            {
                throw new InvalidDataException("courseReference is a required property for TpdmAnonymizedStudentAssessmentCourseAssociation and cannot be null");
            }
            else
            {
                this.CourseReference = courseReference;
            }
            this.Id = id;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AnonymizedStudentAssessmentReference
        /// </summary>
        [DataMember(Name="anonymizedStudentAssessmentReference", EmitDefaultValue=false)]
        public TpdmAnonymizedStudentAssessmentReference AnonymizedStudentAssessmentReference { get; set; }

        /// <summary>
        /// Gets or Sets CourseReference
        /// </summary>
        [DataMember(Name="courseReference", EmitDefaultValue=false)]
        public EdFiCourseReference CourseReference { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmAnonymizedStudentAssessmentCourseAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AnonymizedStudentAssessmentReference: ").Append(AnonymizedStudentAssessmentReference).Append("\n");
            sb.Append("  CourseReference: ").Append(CourseReference).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as TpdmAnonymizedStudentAssessmentCourseAssociation);
        }

        /// <summary>
        /// Returns true if TpdmAnonymizedStudentAssessmentCourseAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmAnonymizedStudentAssessmentCourseAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmAnonymizedStudentAssessmentCourseAssociation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AnonymizedStudentAssessmentReference == input.AnonymizedStudentAssessmentReference ||
                    (this.AnonymizedStudentAssessmentReference != null &&
                    this.AnonymizedStudentAssessmentReference.Equals(input.AnonymizedStudentAssessmentReference))
                ) && 
                (
                    this.CourseReference == input.CourseReference ||
                    (this.CourseReference != null &&
                    this.CourseReference.Equals(input.CourseReference))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AnonymizedStudentAssessmentReference != null)
                    hashCode = hashCode * 59 + this.AnonymizedStudentAssessmentReference.GetHashCode();
                if (this.CourseReference != null)
                    hashCode = hashCode * 59 + this.CourseReference.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
