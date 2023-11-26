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
    /// EdFiStudentSectionAssociation
    /// </summary>
    [DataContract(Name = "edFi_studentSectionAssociation")]
    public partial class EdFiStudentSectionAssociation : IEquatable<EdFiStudentSectionAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSectionAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSectionAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSectionAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">Month, day, and year of the student&#39;s entry or assignment to the section. (required).</param>
        /// <param name="sectionReference">sectionReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="attemptStatusDescriptor">An indication of the student&#39;s completion status for the section..</param>
        /// <param name="endDate">Month, day, and year of the withdrawal or exit of the student from the section..</param>
        /// <param name="homeroomIndicator">Indicates the section is the student&#39;s homeroom. Homeroom period may the convention for taking daily attendance..</param>
        /// <param name="repeatIdentifierDescriptor">An indication as to whether a student has previously taken a given course..</param>
        /// <param name="teacherStudentDataLinkExclusion">Indicates that the student-section combination is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        /// <param name="ext">ext.</param>
        public EdFiStudentSectionAssociation(string id = default(string), DateTime beginDate = default(DateTime), EdFiSectionReference sectionReference = default(EdFiSectionReference), EdFiStudentReference studentReference = default(EdFiStudentReference), string attemptStatusDescriptor = default(string), DateTime? endDate = default(DateTime?), bool? homeroomIndicator = default(bool?), string repeatIdentifierDescriptor = default(string), bool? teacherStudentDataLinkExclusion = default(bool?), string etag = default(string), DateTime lastModifiedDate = default(DateTime), StudentSectionAssociationExtensions ext = default(StudentSectionAssociationExtensions))
        {
            this.BeginDate = beginDate;
            // to ensure "sectionReference" is required (not null)
            if (sectionReference == null)
            {
                throw new ArgumentNullException("sectionReference is a required property for EdFiStudentSectionAssociation and cannot be null");
            }
            this.SectionReference = sectionReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for EdFiStudentSectionAssociation and cannot be null");
            }
            this.StudentReference = studentReference;
            this.Id = id;
            this.AttemptStatusDescriptor = attemptStatusDescriptor;
            this.EndDate = endDate;
            this.HomeroomIndicator = homeroomIndicator;
            this.RepeatIdentifierDescriptor = repeatIdentifierDescriptor;
            this.TeacherStudentDataLinkExclusion = teacherStudentDataLinkExclusion;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
            this.Ext = ext;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Month, day, and year of the student&#39;s entry or assignment to the section.
        /// </summary>
        /// <value>Month, day, and year of the student&#39;s entry or assignment to the section.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets SectionReference
        /// </summary>
        [DataMember(Name = "sectionReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSectionReference SectionReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// An indication of the student&#39;s completion status for the section.
        /// </summary>
        /// <value>An indication of the student&#39;s completion status for the section.</value>
        [DataMember(Name = "attemptStatusDescriptor", EmitDefaultValue = true)]
        public string AttemptStatusDescriptor { get; set; }

        /// <summary>
        /// Month, day, and year of the withdrawal or exit of the student from the section.
        /// </summary>
        /// <value>Month, day, and year of the withdrawal or exit of the student from the section.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Indicates the section is the student&#39;s homeroom. Homeroom period may the convention for taking daily attendance.
        /// </summary>
        /// <value>Indicates the section is the student&#39;s homeroom. Homeroom period may the convention for taking daily attendance.</value>
        [DataMember(Name = "homeroomIndicator", EmitDefaultValue = true)]
        public bool? HomeroomIndicator { get; set; }

        /// <summary>
        /// An indication as to whether a student has previously taken a given course.
        /// </summary>
        /// <value>An indication as to whether a student has previously taken a given course.</value>
        [DataMember(Name = "repeatIdentifierDescriptor", EmitDefaultValue = true)]
        public string RepeatIdentifierDescriptor { get; set; }

        /// <summary>
        /// Indicates that the student-section combination is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation.
        /// </summary>
        /// <value>Indicates that the student-section combination is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation.</value>
        [DataMember(Name = "teacherStudentDataLinkExclusion", EmitDefaultValue = true)]
        public bool? TeacherStudentDataLinkExclusion { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// The date and time the resource was last modified.
        /// </summary>
        /// <value>The date and time the resource was last modified.</value>
        [DataMember(Name = "_lastModifiedDate", EmitDefaultValue = false)]
        public DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public StudentSectionAssociationExtensions Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentSectionAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  SectionReference: ").Append(SectionReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  AttemptStatusDescriptor: ").Append(AttemptStatusDescriptor).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  HomeroomIndicator: ").Append(HomeroomIndicator).Append("\n");
            sb.Append("  RepeatIdentifierDescriptor: ").Append(RepeatIdentifierDescriptor).Append("\n");
            sb.Append("  TeacherStudentDataLinkExclusion: ").Append(TeacherStudentDataLinkExclusion).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            return this.Equals(input as EdFiStudentSectionAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStudentSectionAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSectionAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSectionAssociation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.SectionReference == input.SectionReference ||
                    (this.SectionReference != null &&
                    this.SectionReference.Equals(input.SectionReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.AttemptStatusDescriptor == input.AttemptStatusDescriptor ||
                    (this.AttemptStatusDescriptor != null &&
                    this.AttemptStatusDescriptor.Equals(input.AttemptStatusDescriptor))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.HomeroomIndicator == input.HomeroomIndicator ||
                    (this.HomeroomIndicator != null &&
                    this.HomeroomIndicator.Equals(input.HomeroomIndicator))
                ) && 
                (
                    this.RepeatIdentifierDescriptor == input.RepeatIdentifierDescriptor ||
                    (this.RepeatIdentifierDescriptor != null &&
                    this.RepeatIdentifierDescriptor.Equals(input.RepeatIdentifierDescriptor))
                ) && 
                (
                    this.TeacherStudentDataLinkExclusion == input.TeacherStudentDataLinkExclusion ||
                    (this.TeacherStudentDataLinkExclusion != null &&
                    this.TeacherStudentDataLinkExclusion.Equals(input.TeacherStudentDataLinkExclusion))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.BeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                }
                if (this.SectionReference != null)
                {
                    hashCode = (hashCode * 59) + this.SectionReference.GetHashCode();
                }
                if (this.StudentReference != null)
                {
                    hashCode = (hashCode * 59) + this.StudentReference.GetHashCode();
                }
                if (this.AttemptStatusDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.AttemptStatusDescriptor.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.HomeroomIndicator != null)
                {
                    hashCode = (hashCode * 59) + this.HomeroomIndicator.GetHashCode();
                }
                if (this.RepeatIdentifierDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.RepeatIdentifierDescriptor.GetHashCode();
                }
                if (this.TeacherStudentDataLinkExclusion != null)
                {
                    hashCode = (hashCode * 59) + this.TeacherStudentDataLinkExclusion.GetHashCode();
                }
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
                }
                if (this.LastModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedDate.GetHashCode();
                }
                if (this.Ext != null)
                {
                    hashCode = (hashCode * 59) + this.Ext.GetHashCode();
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
            // AttemptStatusDescriptor (string) maxLength
            if (this.AttemptStatusDescriptor != null && this.AttemptStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AttemptStatusDescriptor, length must be less than 306.", new [] { "AttemptStatusDescriptor" });
            }

            // RepeatIdentifierDescriptor (string) maxLength
            if (this.RepeatIdentifierDescriptor != null && this.RepeatIdentifierDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RepeatIdentifierDescriptor, length must be less than 306.", new [] { "RepeatIdentifierDescriptor" });
            }

            yield break;
        }
    }

}
