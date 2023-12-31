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
    /// TpdmStaffStudentGrowthMeasure
    /// </summary>
    [DataContract]
    public partial class TpdmStaffStudentGrowthMeasure :  IEquatable<TpdmStaffStudentGrowthMeasure>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmStaffStudentGrowthMeasure" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmStaffStudentGrowthMeasure() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmStaffStudentGrowthMeasure" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="factAsOfDate">The date for which the data element is relevant (required).</param>
        /// <param name="staffStudentGrowthMeasureIdentifier">Assigned unique identifier for the student growth measure. (required).</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference (required).</param>
        /// <param name="staffReference">staffReference (required).</param>
        /// <param name="academicSubjects">An unordered collection of staffStudentGrowthMeasureAcademicSubjects. This descriptor holds the description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language)..</param>
        /// <param name="gradeLevels">An unordered collection of staffStudentGrowthMeasureGradeLevels. This descriptor defines the set of grade levels..</param>
        /// <param name="resultDatatypeTypeDescriptor">The datatype of the result. The results can be expressed as a number, percentile, range, level, etc..</param>
        /// <param name="standardError">Standard error for growth score measurement..</param>
        /// <param name="studentGrowthActualScore">The actual score a group of students receives on their student growth assessment (required).</param>
        /// <param name="studentGrowthMeasureDate">The date for which the student growth is measured.</param>
        /// <param name="studentGrowthMet">Identifies if the student has met the student growth target score (required).</param>
        /// <param name="studentGrowthNCount">The number of students included in the average score result..</param>
        /// <param name="studentGrowthTargetScore">The target score that has been set for the group of students as it pertains to their student growth..</param>
        /// <param name="studentGrowthTypeDescriptor">Identification of the type of score that was used to determine student growth.</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmStaffStudentGrowthMeasure(string id = default(string), DateTime? factAsOfDate = default(DateTime?), string staffStudentGrowthMeasureIdentifier = default(string), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference), EdFiStaffReference staffReference = default(EdFiStaffReference), List<TpdmStaffStudentGrowthMeasureAcademicSubject> academicSubjects = default(List<TpdmStaffStudentGrowthMeasureAcademicSubject>), List<TpdmStaffStudentGrowthMeasureGradeLevel> gradeLevels = default(List<TpdmStaffStudentGrowthMeasureGradeLevel>), string resultDatatypeTypeDescriptor = default(string), double? standardError = default(double?), int? studentGrowthActualScore = default(int?), DateTime? studentGrowthMeasureDate = default(DateTime?), bool? studentGrowthMet = default(bool?), int? studentGrowthNCount = default(int?), int? studentGrowthTargetScore = default(int?), string studentGrowthTypeDescriptor = default(string), string etag = default(string))
        {
            // to ensure "factAsOfDate" is required (not null)
            if (factAsOfDate == null)
            {
                throw new InvalidDataException("factAsOfDate is a required property for TpdmStaffStudentGrowthMeasure and cannot be null");
            }
            else
            {
                this.FactAsOfDate = factAsOfDate;
            }
            // to ensure "staffStudentGrowthMeasureIdentifier" is required (not null)
            if (staffStudentGrowthMeasureIdentifier == null)
            {
                throw new InvalidDataException("staffStudentGrowthMeasureIdentifier is a required property for TpdmStaffStudentGrowthMeasure and cannot be null");
            }
            else
            {
                this.StaffStudentGrowthMeasureIdentifier = staffStudentGrowthMeasureIdentifier;
            }
            // to ensure "schoolYearTypeReference" is required (not null)
            if (schoolYearTypeReference == null)
            {
                throw new InvalidDataException("schoolYearTypeReference is a required property for TpdmStaffStudentGrowthMeasure and cannot be null");
            }
            else
            {
                this.SchoolYearTypeReference = schoolYearTypeReference;
            }
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new InvalidDataException("staffReference is a required property for TpdmStaffStudentGrowthMeasure and cannot be null");
            }
            else
            {
                this.StaffReference = staffReference;
            }
            // to ensure "studentGrowthActualScore" is required (not null)
            if (studentGrowthActualScore == null)
            {
                throw new InvalidDataException("studentGrowthActualScore is a required property for TpdmStaffStudentGrowthMeasure and cannot be null");
            }
            else
            {
                this.StudentGrowthActualScore = studentGrowthActualScore;
            }
            // to ensure "studentGrowthMet" is required (not null)
            if (studentGrowthMet == null)
            {
                throw new InvalidDataException("studentGrowthMet is a required property for TpdmStaffStudentGrowthMeasure and cannot be null");
            }
            else
            {
                this.StudentGrowthMet = studentGrowthMet;
            }
            this.Id = id;
            this.AcademicSubjects = academicSubjects;
            this.GradeLevels = gradeLevels;
            this.ResultDatatypeTypeDescriptor = resultDatatypeTypeDescriptor;
            this.StandardError = standardError;
            this.StudentGrowthMeasureDate = studentGrowthMeasureDate;
            this.StudentGrowthNCount = studentGrowthNCount;
            this.StudentGrowthTargetScore = studentGrowthTargetScore;
            this.StudentGrowthTypeDescriptor = studentGrowthTypeDescriptor;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The date for which the data element is relevant
        /// </summary>
        /// <value>The date for which the data element is relevant</value>
        [DataMember(Name="factAsOfDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FactAsOfDate { get; set; }

        /// <summary>
        /// Assigned unique identifier for the student growth measure.
        /// </summary>
        /// <value>Assigned unique identifier for the student growth measure.</value>
        [DataMember(Name="staffStudentGrowthMeasureIdentifier", EmitDefaultValue=false)]
        public string StaffStudentGrowthMeasureIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name="schoolYearTypeReference", EmitDefaultValue=false)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name="staffReference", EmitDefaultValue=false)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// An unordered collection of staffStudentGrowthMeasureAcademicSubjects. This descriptor holds the description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language).
        /// </summary>
        /// <value>An unordered collection of staffStudentGrowthMeasureAcademicSubjects. This descriptor holds the description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language).</value>
        [DataMember(Name="academicSubjects", EmitDefaultValue=false)]
        public List<TpdmStaffStudentGrowthMeasureAcademicSubject> AcademicSubjects { get; set; }

        /// <summary>
        /// An unordered collection of staffStudentGrowthMeasureGradeLevels. This descriptor defines the set of grade levels.
        /// </summary>
        /// <value>An unordered collection of staffStudentGrowthMeasureGradeLevels. This descriptor defines the set of grade levels.</value>
        [DataMember(Name="gradeLevels", EmitDefaultValue=false)]
        public List<TpdmStaffStudentGrowthMeasureGradeLevel> GradeLevels { get; set; }

        /// <summary>
        /// The datatype of the result. The results can be expressed as a number, percentile, range, level, etc.
        /// </summary>
        /// <value>The datatype of the result. The results can be expressed as a number, percentile, range, level, etc.</value>
        [DataMember(Name="resultDatatypeTypeDescriptor", EmitDefaultValue=false)]
        public string ResultDatatypeTypeDescriptor { get; set; }

        /// <summary>
        /// Standard error for growth score measurement.
        /// </summary>
        /// <value>Standard error for growth score measurement.</value>
        [DataMember(Name="standardError", EmitDefaultValue=false)]
        public double? StandardError { get; set; }

        /// <summary>
        /// The actual score a group of students receives on their student growth assessment
        /// </summary>
        /// <value>The actual score a group of students receives on their student growth assessment</value>
        [DataMember(Name="studentGrowthActualScore", EmitDefaultValue=false)]
        public int? StudentGrowthActualScore { get; set; }

        /// <summary>
        /// The date for which the student growth is measured
        /// </summary>
        /// <value>The date for which the student growth is measured</value>
        [DataMember(Name="studentGrowthMeasureDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? StudentGrowthMeasureDate { get; set; }

        /// <summary>
        /// Identifies if the student has met the student growth target score
        /// </summary>
        /// <value>Identifies if the student has met the student growth target score</value>
        [DataMember(Name="studentGrowthMet", EmitDefaultValue=false)]
        public bool? StudentGrowthMet { get; set; }

        /// <summary>
        /// The number of students included in the average score result.
        /// </summary>
        /// <value>The number of students included in the average score result.</value>
        [DataMember(Name="studentGrowthNCount", EmitDefaultValue=false)]
        public int? StudentGrowthNCount { get; set; }

        /// <summary>
        /// The target score that has been set for the group of students as it pertains to their student growth.
        /// </summary>
        /// <value>The target score that has been set for the group of students as it pertains to their student growth.</value>
        [DataMember(Name="studentGrowthTargetScore", EmitDefaultValue=false)]
        public int? StudentGrowthTargetScore { get; set; }

        /// <summary>
        /// Identification of the type of score that was used to determine student growth
        /// </summary>
        /// <value>Identification of the type of score that was used to determine student growth</value>
        [DataMember(Name="studentGrowthTypeDescriptor", EmitDefaultValue=false)]
        public string StudentGrowthTypeDescriptor { get; set; }

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
            sb.Append("class TpdmStaffStudentGrowthMeasure {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FactAsOfDate: ").Append(FactAsOfDate).Append("\n");
            sb.Append("  StaffStudentGrowthMeasureIdentifier: ").Append(StaffStudentGrowthMeasureIdentifier).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  AcademicSubjects: ").Append(AcademicSubjects).Append("\n");
            sb.Append("  GradeLevels: ").Append(GradeLevels).Append("\n");
            sb.Append("  ResultDatatypeTypeDescriptor: ").Append(ResultDatatypeTypeDescriptor).Append("\n");
            sb.Append("  StandardError: ").Append(StandardError).Append("\n");
            sb.Append("  StudentGrowthActualScore: ").Append(StudentGrowthActualScore).Append("\n");
            sb.Append("  StudentGrowthMeasureDate: ").Append(StudentGrowthMeasureDate).Append("\n");
            sb.Append("  StudentGrowthMet: ").Append(StudentGrowthMet).Append("\n");
            sb.Append("  StudentGrowthNCount: ").Append(StudentGrowthNCount).Append("\n");
            sb.Append("  StudentGrowthTargetScore: ").Append(StudentGrowthTargetScore).Append("\n");
            sb.Append("  StudentGrowthTypeDescriptor: ").Append(StudentGrowthTypeDescriptor).Append("\n");
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
            return this.Equals(input as TpdmStaffStudentGrowthMeasure);
        }

        /// <summary>
        /// Returns true if TpdmStaffStudentGrowthMeasure instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmStaffStudentGrowthMeasure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmStaffStudentGrowthMeasure input)
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
                    this.FactAsOfDate == input.FactAsOfDate ||
                    (this.FactAsOfDate != null &&
                    this.FactAsOfDate.Equals(input.FactAsOfDate))
                ) && 
                (
                    this.StaffStudentGrowthMeasureIdentifier == input.StaffStudentGrowthMeasureIdentifier ||
                    (this.StaffStudentGrowthMeasureIdentifier != null &&
                    this.StaffStudentGrowthMeasureIdentifier.Equals(input.StaffStudentGrowthMeasureIdentifier))
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
                ) && 
                (
                    this.AcademicSubjects == input.AcademicSubjects ||
                    this.AcademicSubjects != null &&
                    this.AcademicSubjects.SequenceEqual(input.AcademicSubjects)
                ) && 
                (
                    this.GradeLevels == input.GradeLevels ||
                    this.GradeLevels != null &&
                    this.GradeLevels.SequenceEqual(input.GradeLevels)
                ) && 
                (
                    this.ResultDatatypeTypeDescriptor == input.ResultDatatypeTypeDescriptor ||
                    (this.ResultDatatypeTypeDescriptor != null &&
                    this.ResultDatatypeTypeDescriptor.Equals(input.ResultDatatypeTypeDescriptor))
                ) && 
                (
                    this.StandardError == input.StandardError ||
                    (this.StandardError != null &&
                    this.StandardError.Equals(input.StandardError))
                ) && 
                (
                    this.StudentGrowthActualScore == input.StudentGrowthActualScore ||
                    (this.StudentGrowthActualScore != null &&
                    this.StudentGrowthActualScore.Equals(input.StudentGrowthActualScore))
                ) && 
                (
                    this.StudentGrowthMeasureDate == input.StudentGrowthMeasureDate ||
                    (this.StudentGrowthMeasureDate != null &&
                    this.StudentGrowthMeasureDate.Equals(input.StudentGrowthMeasureDate))
                ) && 
                (
                    this.StudentGrowthMet == input.StudentGrowthMet ||
                    (this.StudentGrowthMet != null &&
                    this.StudentGrowthMet.Equals(input.StudentGrowthMet))
                ) && 
                (
                    this.StudentGrowthNCount == input.StudentGrowthNCount ||
                    (this.StudentGrowthNCount != null &&
                    this.StudentGrowthNCount.Equals(input.StudentGrowthNCount))
                ) && 
                (
                    this.StudentGrowthTargetScore == input.StudentGrowthTargetScore ||
                    (this.StudentGrowthTargetScore != null &&
                    this.StudentGrowthTargetScore.Equals(input.StudentGrowthTargetScore))
                ) && 
                (
                    this.StudentGrowthTypeDescriptor == input.StudentGrowthTypeDescriptor ||
                    (this.StudentGrowthTypeDescriptor != null &&
                    this.StudentGrowthTypeDescriptor.Equals(input.StudentGrowthTypeDescriptor))
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
                if (this.FactAsOfDate != null)
                    hashCode = hashCode * 59 + this.FactAsOfDate.GetHashCode();
                if (this.StaffStudentGrowthMeasureIdentifier != null)
                    hashCode = hashCode * 59 + this.StaffStudentGrowthMeasureIdentifier.GetHashCode();
                if (this.SchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.SchoolYearTypeReference.GetHashCode();
                if (this.StaffReference != null)
                    hashCode = hashCode * 59 + this.StaffReference.GetHashCode();
                if (this.AcademicSubjects != null)
                    hashCode = hashCode * 59 + this.AcademicSubjects.GetHashCode();
                if (this.GradeLevels != null)
                    hashCode = hashCode * 59 + this.GradeLevels.GetHashCode();
                if (this.ResultDatatypeTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.ResultDatatypeTypeDescriptor.GetHashCode();
                if (this.StandardError != null)
                    hashCode = hashCode * 59 + this.StandardError.GetHashCode();
                if (this.StudentGrowthActualScore != null)
                    hashCode = hashCode * 59 + this.StudentGrowthActualScore.GetHashCode();
                if (this.StudentGrowthMeasureDate != null)
                    hashCode = hashCode * 59 + this.StudentGrowthMeasureDate.GetHashCode();
                if (this.StudentGrowthMet != null)
                    hashCode = hashCode * 59 + this.StudentGrowthMet.GetHashCode();
                if (this.StudentGrowthNCount != null)
                    hashCode = hashCode * 59 + this.StudentGrowthNCount.GetHashCode();
                if (this.StudentGrowthTargetScore != null)
                    hashCode = hashCode * 59 + this.StudentGrowthTargetScore.GetHashCode();
                if (this.StudentGrowthTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.StudentGrowthTypeDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
