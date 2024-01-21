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
    /// EdFiReportCard
    /// </summary>
    [DataContract(Name = "edFi_reportCard")]
    public partial class EdFiReportCard : IEquatable<EdFiReportCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiReportCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCard" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="gradingPeriodReference">gradingPeriodReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="gradePointAverages">An unordered collection of reportCardGradePointAverages. A measure of average performance for courses taken by an individual..</param>
        /// <param name="grades">An unordered collection of reportCardGrades. Grades for the classes attended by the student for this grading period..</param>
        /// <param name="numberOfDaysAbsent">The number of days an individual is absent when school is in session during a given reporting period..</param>
        /// <param name="numberOfDaysInAttendance">The number of days an individual is present when school is in session during a given reporting period..</param>
        /// <param name="numberOfDaysTardy">The number of days an individual is tardy during a given reporting period..</param>
        /// <param name="studentCompetencyObjectives">An unordered collection of reportCardStudentCompetencyObjectives. The student competency evaluations associated for this grading period..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiReportCard(string id = default(string), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiGradingPeriodReference gradingPeriodReference = default(EdFiGradingPeriodReference), EdFiStudentReference studentReference = default(EdFiStudentReference), List<EdFiReportCardGradePointAverage> gradePointAverages = default(List<EdFiReportCardGradePointAverage>), List<EdFiReportCardGrade> grades = default(List<EdFiReportCardGrade>), double? numberOfDaysAbsent = default(double?), double? numberOfDaysInAttendance = default(double?), int? numberOfDaysTardy = default(int?), List<EdFiReportCardStudentCompetencyObjective> studentCompetencyObjectives = default(List<EdFiReportCardStudentCompetencyObjective>), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new ArgumentNullException("educationOrganizationReference is a required property for EdFiReportCard and cannot be null");
            }
            this.EducationOrganizationReference = educationOrganizationReference;
            // to ensure "gradingPeriodReference" is required (not null)
            if (gradingPeriodReference == null)
            {
                throw new ArgumentNullException("gradingPeriodReference is a required property for EdFiReportCard and cannot be null");
            }
            this.GradingPeriodReference = gradingPeriodReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for EdFiReportCard and cannot be null");
            }
            this.StudentReference = studentReference;
            this.Id = id;
            this.GradePointAverages = gradePointAverages;
            this.Grades = grades;
            this.NumberOfDaysAbsent = numberOfDaysAbsent;
            this.NumberOfDaysInAttendance = numberOfDaysInAttendance;
            this.NumberOfDaysTardy = numberOfDaysTardy;
            this.StudentCompetencyObjectives = studentCompetencyObjectives;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name = "educationOrganizationReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets GradingPeriodReference
        /// </summary>
        [DataMember(Name = "gradingPeriodReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiGradingPeriodReference GradingPeriodReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// An unordered collection of reportCardGradePointAverages. A measure of average performance for courses taken by an individual.
        /// </summary>
        /// <value>An unordered collection of reportCardGradePointAverages. A measure of average performance for courses taken by an individual.</value>
        [DataMember(Name = "gradePointAverages", EmitDefaultValue = false)]
        public List<EdFiReportCardGradePointAverage> GradePointAverages { get; set; }

        /// <summary>
        /// An unordered collection of reportCardGrades. Grades for the classes attended by the student for this grading period.
        /// </summary>
        /// <value>An unordered collection of reportCardGrades. Grades for the classes attended by the student for this grading period.</value>
        [DataMember(Name = "grades", EmitDefaultValue = false)]
        public List<EdFiReportCardGrade> Grades { get; set; }

        /// <summary>
        /// The number of days an individual is absent when school is in session during a given reporting period.
        /// </summary>
        /// <value>The number of days an individual is absent when school is in session during a given reporting period.</value>
        [DataMember(Name = "numberOfDaysAbsent", EmitDefaultValue = true)]
        public double? NumberOfDaysAbsent { get; set; }

        /// <summary>
        /// The number of days an individual is present when school is in session during a given reporting period.
        /// </summary>
        /// <value>The number of days an individual is present when school is in session during a given reporting period.</value>
        [DataMember(Name = "numberOfDaysInAttendance", EmitDefaultValue = true)]
        public double? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// The number of days an individual is tardy during a given reporting period.
        /// </summary>
        /// <value>The number of days an individual is tardy during a given reporting period.</value>
        [DataMember(Name = "numberOfDaysTardy", EmitDefaultValue = true)]
        public int? NumberOfDaysTardy { get; set; }

        /// <summary>
        /// An unordered collection of reportCardStudentCompetencyObjectives. The student competency evaluations associated for this grading period.
        /// </summary>
        /// <value>An unordered collection of reportCardStudentCompetencyObjectives. The student competency evaluations associated for this grading period.</value>
        [DataMember(Name = "studentCompetencyObjectives", EmitDefaultValue = false)]
        public List<EdFiReportCardStudentCompetencyObjective> StudentCompetencyObjectives { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiReportCard {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  GradingPeriodReference: ").Append(GradingPeriodReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  GradePointAverages: ").Append(GradePointAverages).Append("\n");
            sb.Append("  Grades: ").Append(Grades).Append("\n");
            sb.Append("  NumberOfDaysAbsent: ").Append(NumberOfDaysAbsent).Append("\n");
            sb.Append("  NumberOfDaysInAttendance: ").Append(NumberOfDaysInAttendance).Append("\n");
            sb.Append("  NumberOfDaysTardy: ").Append(NumberOfDaysTardy).Append("\n");
            sb.Append("  StudentCompetencyObjectives: ").Append(StudentCompetencyObjectives).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
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
            return this.Equals(input as EdFiReportCard);
        }

        /// <summary>
        /// Returns true if EdFiReportCard instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiReportCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiReportCard input)
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
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.GradingPeriodReference == input.GradingPeriodReference ||
                    (this.GradingPeriodReference != null &&
                    this.GradingPeriodReference.Equals(input.GradingPeriodReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.GradePointAverages == input.GradePointAverages ||
                    this.GradePointAverages != null &&
                    input.GradePointAverages != null &&
                    this.GradePointAverages.SequenceEqual(input.GradePointAverages)
                ) && 
                (
                    this.Grades == input.Grades ||
                    this.Grades != null &&
                    input.Grades != null &&
                    this.Grades.SequenceEqual(input.Grades)
                ) && 
                (
                    this.NumberOfDaysAbsent == input.NumberOfDaysAbsent ||
                    (this.NumberOfDaysAbsent != null &&
                    this.NumberOfDaysAbsent.Equals(input.NumberOfDaysAbsent))
                ) && 
                (
                    this.NumberOfDaysInAttendance == input.NumberOfDaysInAttendance ||
                    (this.NumberOfDaysInAttendance != null &&
                    this.NumberOfDaysInAttendance.Equals(input.NumberOfDaysInAttendance))
                ) && 
                (
                    this.NumberOfDaysTardy == input.NumberOfDaysTardy ||
                    (this.NumberOfDaysTardy != null &&
                    this.NumberOfDaysTardy.Equals(input.NumberOfDaysTardy))
                ) && 
                (
                    this.StudentCompetencyObjectives == input.StudentCompetencyObjectives ||
                    this.StudentCompetencyObjectives != null &&
                    input.StudentCompetencyObjectives != null &&
                    this.StudentCompetencyObjectives.SequenceEqual(input.StudentCompetencyObjectives)
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
                if (this.EducationOrganizationReference != null)
                {
                    hashCode = (hashCode * 59) + this.EducationOrganizationReference.GetHashCode();
                }
                if (this.GradingPeriodReference != null)
                {
                    hashCode = (hashCode * 59) + this.GradingPeriodReference.GetHashCode();
                }
                if (this.StudentReference != null)
                {
                    hashCode = (hashCode * 59) + this.StudentReference.GetHashCode();
                }
                if (this.GradePointAverages != null)
                {
                    hashCode = (hashCode * 59) + this.GradePointAverages.GetHashCode();
                }
                if (this.Grades != null)
                {
                    hashCode = (hashCode * 59) + this.Grades.GetHashCode();
                }
                if (this.NumberOfDaysAbsent != null)
                {
                    hashCode = (hashCode * 59) + this.NumberOfDaysAbsent.GetHashCode();
                }
                if (this.NumberOfDaysInAttendance != null)
                {
                    hashCode = (hashCode * 59) + this.NumberOfDaysInAttendance.GetHashCode();
                }
                if (this.NumberOfDaysTardy != null)
                {
                    hashCode = (hashCode * 59) + this.NumberOfDaysTardy.GetHashCode();
                }
                if (this.StudentCompetencyObjectives != null)
                {
                    hashCode = (hashCode * 59) + this.StudentCompetencyObjectives.GetHashCode();
                }
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
                }
                if (this.LastModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedDate.GetHashCode();
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
            // NumberOfDaysAbsent (double?) minimum
            if (this.NumberOfDaysAbsent < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfDaysAbsent, must be a value greater than or equal to 0.", new [] { "NumberOfDaysAbsent" });
            }

            // NumberOfDaysInAttendance (double?) minimum
            if (this.NumberOfDaysInAttendance < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfDaysInAttendance, must be a value greater than or equal to 0.", new [] { "NumberOfDaysInAttendance" });
            }

            // NumberOfDaysTardy (int?) minimum
            if (this.NumberOfDaysTardy < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfDaysTardy, must be a value greater than or equal to 0.", new [] { "NumberOfDaysTardy" });
            }

            yield break;
        }
    }

}
