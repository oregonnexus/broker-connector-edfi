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
    /// TpdmAnonymizedStudentAssessment
    /// </summary>
    [DataContract]
    public partial class TpdmAnonymizedStudentAssessment :  IEquatable<TpdmAnonymizedStudentAssessment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmAnonymizedStudentAssessment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmAnonymizedStudentAssessment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmAnonymizedStudentAssessment" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="administrationDate">Date the assessment was administered (required).</param>
        /// <param name="assessmentIdentifier">An identifier that uniquely identifies the assessment to which the student results are associated. (required).</param>
        /// <param name="anonymizedStudentReference">anonymizedStudentReference (required).</param>
        /// <param name="takenSchoolYearTypeReference">takenSchoolYearTypeReference (required).</param>
        /// <param name="academicSubjectDescriptor">The academic subject associated with a student assessment.</param>
        /// <param name="assessmentCategoryDescriptor">The category of an assessment based on format and content. For example: Achievement test Advanced placement test Alternate assessment/grade-level standards Attitudinal test Cognitive and perceptual skills test ....</param>
        /// <param name="assessmentTitle">The title if any specific assessment given to a group.</param>
        /// <param name="gradeLevelDescriptor">Grade level for which effectiveness is measured..</param>
        /// <param name="performanceLevel">performanceLevel.</param>
        /// <param name="scoreResult">scoreResult.</param>
        /// <param name="termDescriptor">The term in which the assessment was administered.</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmAnonymizedStudentAssessment(string id = default(string), DateTime? administrationDate = default(DateTime?), string assessmentIdentifier = default(string), TpdmAnonymizedStudentReference anonymizedStudentReference = default(TpdmAnonymizedStudentReference), EdFiSchoolYearTypeReference takenSchoolYearTypeReference = default(EdFiSchoolYearTypeReference), string academicSubjectDescriptor = default(string), string assessmentCategoryDescriptor = default(string), string assessmentTitle = default(string), string gradeLevelDescriptor = default(string), TpdmAnonymizedStudentAssessmentPerformanceLevel performanceLevel = default(TpdmAnonymizedStudentAssessmentPerformanceLevel), TpdmAnonymizedStudentAssessmentScoreResult scoreResult = default(TpdmAnonymizedStudentAssessmentScoreResult), string termDescriptor = default(string), string etag = default(string))
        {
            // to ensure "administrationDate" is required (not null)
            if (administrationDate == null)
            {
                throw new InvalidDataException("administrationDate is a required property for TpdmAnonymizedStudentAssessment and cannot be null");
            }
            else
            {
                this.AdministrationDate = administrationDate;
            }
            // to ensure "assessmentIdentifier" is required (not null)
            if (assessmentIdentifier == null)
            {
                throw new InvalidDataException("assessmentIdentifier is a required property for TpdmAnonymizedStudentAssessment and cannot be null");
            }
            else
            {
                this.AssessmentIdentifier = assessmentIdentifier;
            }
            // to ensure "anonymizedStudentReference" is required (not null)
            if (anonymizedStudentReference == null)
            {
                throw new InvalidDataException("anonymizedStudentReference is a required property for TpdmAnonymizedStudentAssessment and cannot be null");
            }
            else
            {
                this.AnonymizedStudentReference = anonymizedStudentReference;
            }
            // to ensure "takenSchoolYearTypeReference" is required (not null)
            if (takenSchoolYearTypeReference == null)
            {
                throw new InvalidDataException("takenSchoolYearTypeReference is a required property for TpdmAnonymizedStudentAssessment and cannot be null");
            }
            else
            {
                this.TakenSchoolYearTypeReference = takenSchoolYearTypeReference;
            }
            this.Id = id;
            this.AcademicSubjectDescriptor = academicSubjectDescriptor;
            this.AssessmentCategoryDescriptor = assessmentCategoryDescriptor;
            this.AssessmentTitle = assessmentTitle;
            this.GradeLevelDescriptor = gradeLevelDescriptor;
            this.PerformanceLevel = performanceLevel;
            this.ScoreResult = scoreResult;
            this.TermDescriptor = termDescriptor;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Date the assessment was administered
        /// </summary>
        /// <value>Date the assessment was administered</value>
        [DataMember(Name="administrationDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? AdministrationDate { get; set; }

        /// <summary>
        /// An identifier that uniquely identifies the assessment to which the student results are associated.
        /// </summary>
        /// <value>An identifier that uniquely identifies the assessment to which the student results are associated.</value>
        [DataMember(Name="assessmentIdentifier", EmitDefaultValue=false)]
        public string AssessmentIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets AnonymizedStudentReference
        /// </summary>
        [DataMember(Name="anonymizedStudentReference", EmitDefaultValue=false)]
        public TpdmAnonymizedStudentReference AnonymizedStudentReference { get; set; }

        /// <summary>
        /// Gets or Sets TakenSchoolYearTypeReference
        /// </summary>
        [DataMember(Name="takenSchoolYearTypeReference", EmitDefaultValue=false)]
        public EdFiSchoolYearTypeReference TakenSchoolYearTypeReference { get; set; }

        /// <summary>
        /// The academic subject associated with a student assessment
        /// </summary>
        /// <value>The academic subject associated with a student assessment</value>
        [DataMember(Name="academicSubjectDescriptor", EmitDefaultValue=false)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// The category of an assessment based on format and content. For example: Achievement test Advanced placement test Alternate assessment/grade-level standards Attitudinal test Cognitive and perceptual skills test ...
        /// </summary>
        /// <value>The category of an assessment based on format and content. For example: Achievement test Advanced placement test Alternate assessment/grade-level standards Attitudinal test Cognitive and perceptual skills test ...</value>
        [DataMember(Name="assessmentCategoryDescriptor", EmitDefaultValue=false)]
        public string AssessmentCategoryDescriptor { get; set; }

        /// <summary>
        /// The title if any specific assessment given to a group
        /// </summary>
        /// <value>The title if any specific assessment given to a group</value>
        [DataMember(Name="assessmentTitle", EmitDefaultValue=false)]
        public string AssessmentTitle { get; set; }

        /// <summary>
        /// Grade level for which effectiveness is measured.
        /// </summary>
        /// <value>Grade level for which effectiveness is measured.</value>
        [DataMember(Name="gradeLevelDescriptor", EmitDefaultValue=false)]
        public string GradeLevelDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets PerformanceLevel
        /// </summary>
        [DataMember(Name="performanceLevel", EmitDefaultValue=false)]
        public TpdmAnonymizedStudentAssessmentPerformanceLevel PerformanceLevel { get; set; }

        /// <summary>
        /// Gets or Sets ScoreResult
        /// </summary>
        [DataMember(Name="scoreResult", EmitDefaultValue=false)]
        public TpdmAnonymizedStudentAssessmentScoreResult ScoreResult { get; set; }

        /// <summary>
        /// The term in which the assessment was administered
        /// </summary>
        /// <value>The term in which the assessment was administered</value>
        [DataMember(Name="termDescriptor", EmitDefaultValue=false)]
        public string TermDescriptor { get; set; }

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
            sb.Append("class TpdmAnonymizedStudentAssessment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AdministrationDate: ").Append(AdministrationDate).Append("\n");
            sb.Append("  AssessmentIdentifier: ").Append(AssessmentIdentifier).Append("\n");
            sb.Append("  AnonymizedStudentReference: ").Append(AnonymizedStudentReference).Append("\n");
            sb.Append("  TakenSchoolYearTypeReference: ").Append(TakenSchoolYearTypeReference).Append("\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  AssessmentCategoryDescriptor: ").Append(AssessmentCategoryDescriptor).Append("\n");
            sb.Append("  AssessmentTitle: ").Append(AssessmentTitle).Append("\n");
            sb.Append("  GradeLevelDescriptor: ").Append(GradeLevelDescriptor).Append("\n");
            sb.Append("  PerformanceLevel: ").Append(PerformanceLevel).Append("\n");
            sb.Append("  ScoreResult: ").Append(ScoreResult).Append("\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
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
            return this.Equals(input as TpdmAnonymizedStudentAssessment);
        }

        /// <summary>
        /// Returns true if TpdmAnonymizedStudentAssessment instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmAnonymizedStudentAssessment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmAnonymizedStudentAssessment input)
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
                    this.AdministrationDate == input.AdministrationDate ||
                    (this.AdministrationDate != null &&
                    this.AdministrationDate.Equals(input.AdministrationDate))
                ) && 
                (
                    this.AssessmentIdentifier == input.AssessmentIdentifier ||
                    (this.AssessmentIdentifier != null &&
                    this.AssessmentIdentifier.Equals(input.AssessmentIdentifier))
                ) && 
                (
                    this.AnonymizedStudentReference == input.AnonymizedStudentReference ||
                    (this.AnonymizedStudentReference != null &&
                    this.AnonymizedStudentReference.Equals(input.AnonymizedStudentReference))
                ) && 
                (
                    this.TakenSchoolYearTypeReference == input.TakenSchoolYearTypeReference ||
                    (this.TakenSchoolYearTypeReference != null &&
                    this.TakenSchoolYearTypeReference.Equals(input.TakenSchoolYearTypeReference))
                ) && 
                (
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
                ) && 
                (
                    this.AssessmentCategoryDescriptor == input.AssessmentCategoryDescriptor ||
                    (this.AssessmentCategoryDescriptor != null &&
                    this.AssessmentCategoryDescriptor.Equals(input.AssessmentCategoryDescriptor))
                ) && 
                (
                    this.AssessmentTitle == input.AssessmentTitle ||
                    (this.AssessmentTitle != null &&
                    this.AssessmentTitle.Equals(input.AssessmentTitle))
                ) && 
                (
                    this.GradeLevelDescriptor == input.GradeLevelDescriptor ||
                    (this.GradeLevelDescriptor != null &&
                    this.GradeLevelDescriptor.Equals(input.GradeLevelDescriptor))
                ) && 
                (
                    this.PerformanceLevel == input.PerformanceLevel ||
                    (this.PerformanceLevel != null &&
                    this.PerformanceLevel.Equals(input.PerformanceLevel))
                ) && 
                (
                    this.ScoreResult == input.ScoreResult ||
                    (this.ScoreResult != null &&
                    this.ScoreResult.Equals(input.ScoreResult))
                ) && 
                (
                    this.TermDescriptor == input.TermDescriptor ||
                    (this.TermDescriptor != null &&
                    this.TermDescriptor.Equals(input.TermDescriptor))
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
                if (this.AdministrationDate != null)
                    hashCode = hashCode * 59 + this.AdministrationDate.GetHashCode();
                if (this.AssessmentIdentifier != null)
                    hashCode = hashCode * 59 + this.AssessmentIdentifier.GetHashCode();
                if (this.AnonymizedStudentReference != null)
                    hashCode = hashCode * 59 + this.AnonymizedStudentReference.GetHashCode();
                if (this.TakenSchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.TakenSchoolYearTypeReference.GetHashCode();
                if (this.AcademicSubjectDescriptor != null)
                    hashCode = hashCode * 59 + this.AcademicSubjectDescriptor.GetHashCode();
                if (this.AssessmentCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentCategoryDescriptor.GetHashCode();
                if (this.AssessmentTitle != null)
                    hashCode = hashCode * 59 + this.AssessmentTitle.GetHashCode();
                if (this.GradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.GradeLevelDescriptor.GetHashCode();
                if (this.PerformanceLevel != null)
                    hashCode = hashCode * 59 + this.PerformanceLevel.GetHashCode();
                if (this.ScoreResult != null)
                    hashCode = hashCode * 59 + this.ScoreResult.GetHashCode();
                if (this.TermDescriptor != null)
                    hashCode = hashCode * 59 + this.TermDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
