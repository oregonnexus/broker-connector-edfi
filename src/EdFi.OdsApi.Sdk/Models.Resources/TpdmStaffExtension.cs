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
    /// TpdmStaffExtension
    /// </summary>
    [DataContract]
    public partial class TpdmStaffExtension :  IEquatable<TpdmStaffExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmStaffExtension" /> class.
        /// </summary>
        /// <param name="genderDescriptor">The gender with which a person associates..</param>
        /// <param name="probationCompleteDate">The date the probation period ended or is scheduled to end..</param>
        /// <param name="tenured">Indicator of whether the staff member is tenured..</param>
        /// <param name="tenureTrack">An indication that the staff is on track for tenure..</param>
        /// <param name="backgroundChecks">An unordered collection of staffBackgroundChecks. Staff background check history and disposition..</param>
        /// <param name="highlyQualifiedAcademicSubjects">An unordered collection of staffHighlyQualifiedAcademicSubjects. The academic subject(s) in which the staff is deemed to be \&quot;highly qualified\&quot;..</param>
        /// <param name="seniorities">An unordered collection of staffSeniorities. Entries of job experience contributing to computations of seniority..</param>
        /// <param name="teacherPreparationPrograms">An unordered collection of staffTeacherPreparationPrograms. The Teacher Preparation Program(s) completed by the teacher..</param>
        /// <param name="salary">salary.</param>
        /// <param name="teacherEducatorResearch">teacherEducatorResearch.</param>
        public TpdmStaffExtension(string genderDescriptor = default(string), DateTime? probationCompleteDate = default(DateTime?), bool? tenured = default(bool?), bool? tenureTrack = default(bool?), List<TpdmStaffBackgroundCheck> backgroundChecks = default(List<TpdmStaffBackgroundCheck>), List<TpdmStaffHighlyQualifiedAcademicSubject> highlyQualifiedAcademicSubjects = default(List<TpdmStaffHighlyQualifiedAcademicSubject>), List<TpdmStaffSeniority> seniorities = default(List<TpdmStaffSeniority>), List<TpdmStaffTeacherPreparationProgram> teacherPreparationPrograms = default(List<TpdmStaffTeacherPreparationProgram>), TpdmStaffSalary salary = default(TpdmStaffSalary), TpdmStaffTeacherEducatorResearch teacherEducatorResearch = default(TpdmStaffTeacherEducatorResearch))
        {
            this.GenderDescriptor = genderDescriptor;
            this.ProbationCompleteDate = probationCompleteDate;
            this.Tenured = tenured;
            this.TenureTrack = tenureTrack;
            this.BackgroundChecks = backgroundChecks;
            this.HighlyQualifiedAcademicSubjects = highlyQualifiedAcademicSubjects;
            this.Seniorities = seniorities;
            this.TeacherPreparationPrograms = teacherPreparationPrograms;
            this.Salary = salary;
            this.TeacherEducatorResearch = teacherEducatorResearch;
        }
        
        /// <summary>
        /// The gender with which a person associates.
        /// </summary>
        /// <value>The gender with which a person associates.</value>
        [DataMember(Name="genderDescriptor", EmitDefaultValue=false)]
        public string GenderDescriptor { get; set; }

        /// <summary>
        /// The date the probation period ended or is scheduled to end.
        /// </summary>
        /// <value>The date the probation period ended or is scheduled to end.</value>
        [DataMember(Name="probationCompleteDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ProbationCompleteDate { get; set; }

        /// <summary>
        /// Indicator of whether the staff member is tenured.
        /// </summary>
        /// <value>Indicator of whether the staff member is tenured.</value>
        [DataMember(Name="tenured", EmitDefaultValue=false)]
        public bool? Tenured { get; set; }

        /// <summary>
        /// An indication that the staff is on track for tenure.
        /// </summary>
        /// <value>An indication that the staff is on track for tenure.</value>
        [DataMember(Name="tenureTrack", EmitDefaultValue=false)]
        public bool? TenureTrack { get; set; }

        /// <summary>
        /// An unordered collection of staffBackgroundChecks. Staff background check history and disposition.
        /// </summary>
        /// <value>An unordered collection of staffBackgroundChecks. Staff background check history and disposition.</value>
        [DataMember(Name="backgroundChecks", EmitDefaultValue=false)]
        public List<TpdmStaffBackgroundCheck> BackgroundChecks { get; set; }

        /// <summary>
        /// An unordered collection of staffHighlyQualifiedAcademicSubjects. The academic subject(s) in which the staff is deemed to be \&quot;highly qualified\&quot;.
        /// </summary>
        /// <value>An unordered collection of staffHighlyQualifiedAcademicSubjects. The academic subject(s) in which the staff is deemed to be \&quot;highly qualified\&quot;.</value>
        [DataMember(Name="highlyQualifiedAcademicSubjects", EmitDefaultValue=false)]
        public List<TpdmStaffHighlyQualifiedAcademicSubject> HighlyQualifiedAcademicSubjects { get; set; }

        /// <summary>
        /// An unordered collection of staffSeniorities. Entries of job experience contributing to computations of seniority.
        /// </summary>
        /// <value>An unordered collection of staffSeniorities. Entries of job experience contributing to computations of seniority.</value>
        [DataMember(Name="seniorities", EmitDefaultValue=false)]
        public List<TpdmStaffSeniority> Seniorities { get; set; }

        /// <summary>
        /// An unordered collection of staffTeacherPreparationPrograms. The Teacher Preparation Program(s) completed by the teacher.
        /// </summary>
        /// <value>An unordered collection of staffTeacherPreparationPrograms. The Teacher Preparation Program(s) completed by the teacher.</value>
        [DataMember(Name="teacherPreparationPrograms", EmitDefaultValue=false)]
        public List<TpdmStaffTeacherPreparationProgram> TeacherPreparationPrograms { get; set; }

        /// <summary>
        /// Gets or Sets Salary
        /// </summary>
        [DataMember(Name="salary", EmitDefaultValue=false)]
        public TpdmStaffSalary Salary { get; set; }

        /// <summary>
        /// Gets or Sets TeacherEducatorResearch
        /// </summary>
        [DataMember(Name="teacherEducatorResearch", EmitDefaultValue=false)]
        public TpdmStaffTeacherEducatorResearch TeacherEducatorResearch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmStaffExtension {\n");
            sb.Append("  GenderDescriptor: ").Append(GenderDescriptor).Append("\n");
            sb.Append("  ProbationCompleteDate: ").Append(ProbationCompleteDate).Append("\n");
            sb.Append("  Tenured: ").Append(Tenured).Append("\n");
            sb.Append("  TenureTrack: ").Append(TenureTrack).Append("\n");
            sb.Append("  BackgroundChecks: ").Append(BackgroundChecks).Append("\n");
            sb.Append("  HighlyQualifiedAcademicSubjects: ").Append(HighlyQualifiedAcademicSubjects).Append("\n");
            sb.Append("  Seniorities: ").Append(Seniorities).Append("\n");
            sb.Append("  TeacherPreparationPrograms: ").Append(TeacherPreparationPrograms).Append("\n");
            sb.Append("  Salary: ").Append(Salary).Append("\n");
            sb.Append("  TeacherEducatorResearch: ").Append(TeacherEducatorResearch).Append("\n");
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
            return this.Equals(input as TpdmStaffExtension);
        }

        /// <summary>
        /// Returns true if TpdmStaffExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmStaffExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmStaffExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GenderDescriptor == input.GenderDescriptor ||
                    (this.GenderDescriptor != null &&
                    this.GenderDescriptor.Equals(input.GenderDescriptor))
                ) && 
                (
                    this.ProbationCompleteDate == input.ProbationCompleteDate ||
                    (this.ProbationCompleteDate != null &&
                    this.ProbationCompleteDate.Equals(input.ProbationCompleteDate))
                ) && 
                (
                    this.Tenured == input.Tenured ||
                    (this.Tenured != null &&
                    this.Tenured.Equals(input.Tenured))
                ) && 
                (
                    this.TenureTrack == input.TenureTrack ||
                    (this.TenureTrack != null &&
                    this.TenureTrack.Equals(input.TenureTrack))
                ) && 
                (
                    this.BackgroundChecks == input.BackgroundChecks ||
                    this.BackgroundChecks != null &&
                    this.BackgroundChecks.SequenceEqual(input.BackgroundChecks)
                ) && 
                (
                    this.HighlyQualifiedAcademicSubjects == input.HighlyQualifiedAcademicSubjects ||
                    this.HighlyQualifiedAcademicSubjects != null &&
                    this.HighlyQualifiedAcademicSubjects.SequenceEqual(input.HighlyQualifiedAcademicSubjects)
                ) && 
                (
                    this.Seniorities == input.Seniorities ||
                    this.Seniorities != null &&
                    this.Seniorities.SequenceEqual(input.Seniorities)
                ) && 
                (
                    this.TeacherPreparationPrograms == input.TeacherPreparationPrograms ||
                    this.TeacherPreparationPrograms != null &&
                    this.TeacherPreparationPrograms.SequenceEqual(input.TeacherPreparationPrograms)
                ) && 
                (
                    this.Salary == input.Salary ||
                    (this.Salary != null &&
                    this.Salary.Equals(input.Salary))
                ) && 
                (
                    this.TeacherEducatorResearch == input.TeacherEducatorResearch ||
                    (this.TeacherEducatorResearch != null &&
                    this.TeacherEducatorResearch.Equals(input.TeacherEducatorResearch))
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
                if (this.GenderDescriptor != null)
                    hashCode = hashCode * 59 + this.GenderDescriptor.GetHashCode();
                if (this.ProbationCompleteDate != null)
                    hashCode = hashCode * 59 + this.ProbationCompleteDate.GetHashCode();
                if (this.Tenured != null)
                    hashCode = hashCode * 59 + this.Tenured.GetHashCode();
                if (this.TenureTrack != null)
                    hashCode = hashCode * 59 + this.TenureTrack.GetHashCode();
                if (this.BackgroundChecks != null)
                    hashCode = hashCode * 59 + this.BackgroundChecks.GetHashCode();
                if (this.HighlyQualifiedAcademicSubjects != null)
                    hashCode = hashCode * 59 + this.HighlyQualifiedAcademicSubjects.GetHashCode();
                if (this.Seniorities != null)
                    hashCode = hashCode * 59 + this.Seniorities.GetHashCode();
                if (this.TeacherPreparationPrograms != null)
                    hashCode = hashCode * 59 + this.TeacherPreparationPrograms.GetHashCode();
                if (this.Salary != null)
                    hashCode = hashCode * 59 + this.Salary.GetHashCode();
                if (this.TeacherEducatorResearch != null)
                    hashCode = hashCode * 59 + this.TeacherEducatorResearch.GetHashCode();
                return hashCode;
            }
        }
    }

}
