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
    /// EdFiCourseTranscript
    /// </summary>
    [DataContract]
    public partial class EdFiCourseTranscript :  IEquatable<EdFiCourseTranscript>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseTranscript" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseTranscript() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseTranscript" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="courseAttemptResultDescriptor">The result from the student&#39;s attempt to take the course, for example:          Pass          Fail          Incomplete          Withdrawn. (required).</param>
        /// <param name="courseReference">courseReference (required).</param>
        /// <param name="externalEducationOrganizationReference">externalEducationOrganizationReference.</param>
        /// <param name="studentAcademicRecordReference">studentAcademicRecordReference (required).</param>
        /// <param name="academicSubjects">An unordered collection of courseTranscriptAcademicSubjects. The subject area for the course transcript credits awarded in the course transcript..</param>
        /// <param name="alternativeCourseCode">The local code assigned by the school that identifies the course offering, the code from an external educational organization, or other alternate course code..</param>
        /// <param name="alternativeCourseIdentificationCodes">An unordered collection of courseTranscriptAlternativeCourseIdentificationCodes. The code that identifies the course, course offering, the code from an external educational organization, or other alternate course code..</param>
        /// <param name="alternativeCourseTitle">The descriptive name given to a course of study offered in the school, if different from the CourseTitle..</param>
        /// <param name="assigningOrganizationIdentificationCode">The organization code or name assigning the course identification code..</param>
        /// <param name="attemptedCreditConversion">Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units..</param>
        /// <param name="attemptedCredits">The value of credits or units of value awarded for the completion of a course..</param>
        /// <param name="attemptedCreditTypeDescriptor">The type of credits or units of value awarded for the completion of a course..</param>
        /// <param name="courseCatalogURL">The URL for the course catalog that defines the course identification code..</param>
        /// <param name="courseRepeatCodeDescriptor">Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student&#39;s academic grade average..</param>
        /// <param name="courseTitle">The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts)..</param>
        /// <param name="creditCategories">An unordered collection of courseTranscriptCreditCategories. A categorization for the course transcript credits awarded in the course transcript..</param>
        /// <param name="earnedAdditionalCredits">An unordered collection of courseTranscriptEarnedAdditionalCredits. The number of additional credits a student attempted and could earn for successfully completing a given course (e.g., dual credit, AP, IB)..</param>
        /// <param name="earnedCreditConversion">Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units..</param>
        /// <param name="earnedCredits">The value of credits or units of value awarded for the completion of a course. (required).</param>
        /// <param name="earnedCreditTypeDescriptor">The type of credits or units of value awarded for the completion of a course..</param>
        /// <param name="finalLetterGradeEarned">The final indicator of student performance in a class as submitted by the instructor..</param>
        /// <param name="finalNumericGradeEarned">The final indicator of student performance in a class as submitted by the instructor..</param>
        /// <param name="methodCreditEarnedDescriptor">The method the credits were earned (e.g., Classroom, Examination, Transfer)..</param>
        /// <param name="whenTakenGradeLevelDescriptor">Student&#39;s grade level at time of course..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiCourseTranscript(string id = default(string), string courseAttemptResultDescriptor = default(string), EdFiCourseReference courseReference = default(EdFiCourseReference), EdFiEducationOrganizationReference externalEducationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiStudentAcademicRecordReference studentAcademicRecordReference = default(EdFiStudentAcademicRecordReference), List<EdFiCourseTranscriptAcademicSubject> academicSubjects = default(List<EdFiCourseTranscriptAcademicSubject>), string alternativeCourseCode = default(string), List<EdFiCourseTranscriptAlternativeCourseIdentificationCode> alternativeCourseIdentificationCodes = default(List<EdFiCourseTranscriptAlternativeCourseIdentificationCode>), string alternativeCourseTitle = default(string), string assigningOrganizationIdentificationCode = default(string), double? attemptedCreditConversion = default(double?), double? attemptedCredits = default(double?), string attemptedCreditTypeDescriptor = default(string), string courseCatalogURL = default(string), string courseRepeatCodeDescriptor = default(string), string courseTitle = default(string), List<EdFiCourseTranscriptCreditCategory> creditCategories = default(List<EdFiCourseTranscriptCreditCategory>), List<EdFiCourseTranscriptEarnedAdditionalCredits> earnedAdditionalCredits = default(List<EdFiCourseTranscriptEarnedAdditionalCredits>), double? earnedCreditConversion = default(double?), double? earnedCredits = default(double?), string earnedCreditTypeDescriptor = default(string), string finalLetterGradeEarned = default(string), double? finalNumericGradeEarned = default(double?), string methodCreditEarnedDescriptor = default(string), string whenTakenGradeLevelDescriptor = default(string), string etag = default(string))
        {
            // to ensure "courseAttemptResultDescriptor" is required (not null)
            if (courseAttemptResultDescriptor == null)
            {
                throw new InvalidDataException("courseAttemptResultDescriptor is a required property for EdFiCourseTranscript and cannot be null");
            }
            else
            {
                this.CourseAttemptResultDescriptor = courseAttemptResultDescriptor;
            }
            // to ensure "courseReference" is required (not null)
            if (courseReference == null)
            {
                throw new InvalidDataException("courseReference is a required property for EdFiCourseTranscript and cannot be null");
            }
            else
            {
                this.CourseReference = courseReference;
            }
            // to ensure "studentAcademicRecordReference" is required (not null)
            if (studentAcademicRecordReference == null)
            {
                throw new InvalidDataException("studentAcademicRecordReference is a required property for EdFiCourseTranscript and cannot be null");
            }
            else
            {
                this.StudentAcademicRecordReference = studentAcademicRecordReference;
            }
            // to ensure "earnedCredits" is required (not null)
            if (earnedCredits == null)
            {
                throw new InvalidDataException("earnedCredits is a required property for EdFiCourseTranscript and cannot be null");
            }
            else
            {
                this.EarnedCredits = earnedCredits;
            }
            this.Id = id;
            this.ExternalEducationOrganizationReference = externalEducationOrganizationReference;
            this.AcademicSubjects = academicSubjects;
            this.AlternativeCourseCode = alternativeCourseCode;
            this.AlternativeCourseIdentificationCodes = alternativeCourseIdentificationCodes;
            this.AlternativeCourseTitle = alternativeCourseTitle;
            this.AssigningOrganizationIdentificationCode = assigningOrganizationIdentificationCode;
            this.AttemptedCreditConversion = attemptedCreditConversion;
            this.AttemptedCredits = attemptedCredits;
            this.AttemptedCreditTypeDescriptor = attemptedCreditTypeDescriptor;
            this.CourseCatalogURL = courseCatalogURL;
            this.CourseRepeatCodeDescriptor = courseRepeatCodeDescriptor;
            this.CourseTitle = courseTitle;
            this.CreditCategories = creditCategories;
            this.EarnedAdditionalCredits = earnedAdditionalCredits;
            this.EarnedCreditConversion = earnedCreditConversion;
            this.EarnedCreditTypeDescriptor = earnedCreditTypeDescriptor;
            this.FinalLetterGradeEarned = finalLetterGradeEarned;
            this.FinalNumericGradeEarned = finalNumericGradeEarned;
            this.MethodCreditEarnedDescriptor = methodCreditEarnedDescriptor;
            this.WhenTakenGradeLevelDescriptor = whenTakenGradeLevelDescriptor;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The result from the student&#39;s attempt to take the course, for example:          Pass          Fail          Incomplete          Withdrawn.
        /// </summary>
        /// <value>The result from the student&#39;s attempt to take the course, for example:          Pass          Fail          Incomplete          Withdrawn.</value>
        [DataMember(Name="courseAttemptResultDescriptor", EmitDefaultValue=false)]
        public string CourseAttemptResultDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets CourseReference
        /// </summary>
        [DataMember(Name="courseReference", EmitDefaultValue=false)]
        public EdFiCourseReference CourseReference { get; set; }

        /// <summary>
        /// Gets or Sets ExternalEducationOrganizationReference
        /// </summary>
        [DataMember(Name="externalEducationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference ExternalEducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentAcademicRecordReference
        /// </summary>
        [DataMember(Name="studentAcademicRecordReference", EmitDefaultValue=false)]
        public EdFiStudentAcademicRecordReference StudentAcademicRecordReference { get; set; }

        /// <summary>
        /// An unordered collection of courseTranscriptAcademicSubjects. The subject area for the course transcript credits awarded in the course transcript.
        /// </summary>
        /// <value>An unordered collection of courseTranscriptAcademicSubjects. The subject area for the course transcript credits awarded in the course transcript.</value>
        [DataMember(Name="academicSubjects", EmitDefaultValue=false)]
        public List<EdFiCourseTranscriptAcademicSubject> AcademicSubjects { get; set; }

        /// <summary>
        /// The local code assigned by the school that identifies the course offering, the code from an external educational organization, or other alternate course code.
        /// </summary>
        /// <value>The local code assigned by the school that identifies the course offering, the code from an external educational organization, or other alternate course code.</value>
        [DataMember(Name="alternativeCourseCode", EmitDefaultValue=false)]
        public string AlternativeCourseCode { get; set; }

        /// <summary>
        /// An unordered collection of courseTranscriptAlternativeCourseIdentificationCodes. The code that identifies the course, course offering, the code from an external educational organization, or other alternate course code.
        /// </summary>
        /// <value>An unordered collection of courseTranscriptAlternativeCourseIdentificationCodes. The code that identifies the course, course offering, the code from an external educational organization, or other alternate course code.</value>
        [DataMember(Name="alternativeCourseIdentificationCodes", EmitDefaultValue=false)]
        public List<EdFiCourseTranscriptAlternativeCourseIdentificationCode> AlternativeCourseIdentificationCodes { get; set; }

        /// <summary>
        /// The descriptive name given to a course of study offered in the school, if different from the CourseTitle.
        /// </summary>
        /// <value>The descriptive name given to a course of study offered in the school, if different from the CourseTitle.</value>
        [DataMember(Name="alternativeCourseTitle", EmitDefaultValue=false)]
        public string AlternativeCourseTitle { get; set; }

        /// <summary>
        /// The organization code or name assigning the course identification code.
        /// </summary>
        /// <value>The organization code or name assigning the course identification code.</value>
        [DataMember(Name="assigningOrganizationIdentificationCode", EmitDefaultValue=false)]
        public string AssigningOrganizationIdentificationCode { get; set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        /// <value>Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</value>
        [DataMember(Name="attemptedCreditConversion", EmitDefaultValue=false)]
        public double? AttemptedCreditConversion { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="attemptedCredits", EmitDefaultValue=false)]
        public double? AttemptedCredits { get; set; }

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="attemptedCreditTypeDescriptor", EmitDefaultValue=false)]
        public string AttemptedCreditTypeDescriptor { get; set; }

        /// <summary>
        /// The URL for the course catalog that defines the course identification code.
        /// </summary>
        /// <value>The URL for the course catalog that defines the course identification code.</value>
        [DataMember(Name="courseCatalogURL", EmitDefaultValue=false)]
        public string CourseCatalogURL { get; set; }

        /// <summary>
        /// Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student&#39;s academic grade average.
        /// </summary>
        /// <value>Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student&#39;s academic grade average.</value>
        [DataMember(Name="courseRepeatCodeDescriptor", EmitDefaultValue=false)]
        public string CourseRepeatCodeDescriptor { get; set; }

        /// <summary>
        /// The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts).
        /// </summary>
        /// <value>The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts).</value>
        [DataMember(Name="courseTitle", EmitDefaultValue=false)]
        public string CourseTitle { get; set; }

        /// <summary>
        /// An unordered collection of courseTranscriptCreditCategories. A categorization for the course transcript credits awarded in the course transcript.
        /// </summary>
        /// <value>An unordered collection of courseTranscriptCreditCategories. A categorization for the course transcript credits awarded in the course transcript.</value>
        [DataMember(Name="creditCategories", EmitDefaultValue=false)]
        public List<EdFiCourseTranscriptCreditCategory> CreditCategories { get; set; }

        /// <summary>
        /// An unordered collection of courseTranscriptEarnedAdditionalCredits. The number of additional credits a student attempted and could earn for successfully completing a given course (e.g., dual credit, AP, IB).
        /// </summary>
        /// <value>An unordered collection of courseTranscriptEarnedAdditionalCredits. The number of additional credits a student attempted and could earn for successfully completing a given course (e.g., dual credit, AP, IB).</value>
        [DataMember(Name="earnedAdditionalCredits", EmitDefaultValue=false)]
        public List<EdFiCourseTranscriptEarnedAdditionalCredits> EarnedAdditionalCredits { get; set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        /// <value>Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</value>
        [DataMember(Name="earnedCreditConversion", EmitDefaultValue=false)]
        public double? EarnedCreditConversion { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="earnedCredits", EmitDefaultValue=false)]
        public double? EarnedCredits { get; set; }

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="earnedCreditTypeDescriptor", EmitDefaultValue=false)]
        public string EarnedCreditTypeDescriptor { get; set; }

        /// <summary>
        /// The final indicator of student performance in a class as submitted by the instructor.
        /// </summary>
        /// <value>The final indicator of student performance in a class as submitted by the instructor.</value>
        [DataMember(Name="finalLetterGradeEarned", EmitDefaultValue=false)]
        public string FinalLetterGradeEarned { get; set; }

        /// <summary>
        /// The final indicator of student performance in a class as submitted by the instructor.
        /// </summary>
        /// <value>The final indicator of student performance in a class as submitted by the instructor.</value>
        [DataMember(Name="finalNumericGradeEarned", EmitDefaultValue=false)]
        public double? FinalNumericGradeEarned { get; set; }

        /// <summary>
        /// The method the credits were earned (e.g., Classroom, Examination, Transfer).
        /// </summary>
        /// <value>The method the credits were earned (e.g., Classroom, Examination, Transfer).</value>
        [DataMember(Name="methodCreditEarnedDescriptor", EmitDefaultValue=false)]
        public string MethodCreditEarnedDescriptor { get; set; }

        /// <summary>
        /// Student&#39;s grade level at time of course.
        /// </summary>
        /// <value>Student&#39;s grade level at time of course.</value>
        [DataMember(Name="whenTakenGradeLevelDescriptor", EmitDefaultValue=false)]
        public string WhenTakenGradeLevelDescriptor { get; set; }

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
            sb.Append("class EdFiCourseTranscript {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CourseAttemptResultDescriptor: ").Append(CourseAttemptResultDescriptor).Append("\n");
            sb.Append("  CourseReference: ").Append(CourseReference).Append("\n");
            sb.Append("  ExternalEducationOrganizationReference: ").Append(ExternalEducationOrganizationReference).Append("\n");
            sb.Append("  StudentAcademicRecordReference: ").Append(StudentAcademicRecordReference).Append("\n");
            sb.Append("  AcademicSubjects: ").Append(AcademicSubjects).Append("\n");
            sb.Append("  AlternativeCourseCode: ").Append(AlternativeCourseCode).Append("\n");
            sb.Append("  AlternativeCourseIdentificationCodes: ").Append(AlternativeCourseIdentificationCodes).Append("\n");
            sb.Append("  AlternativeCourseTitle: ").Append(AlternativeCourseTitle).Append("\n");
            sb.Append("  AssigningOrganizationIdentificationCode: ").Append(AssigningOrganizationIdentificationCode).Append("\n");
            sb.Append("  AttemptedCreditConversion: ").Append(AttemptedCreditConversion).Append("\n");
            sb.Append("  AttemptedCredits: ").Append(AttemptedCredits).Append("\n");
            sb.Append("  AttemptedCreditTypeDescriptor: ").Append(AttemptedCreditTypeDescriptor).Append("\n");
            sb.Append("  CourseCatalogURL: ").Append(CourseCatalogURL).Append("\n");
            sb.Append("  CourseRepeatCodeDescriptor: ").Append(CourseRepeatCodeDescriptor).Append("\n");
            sb.Append("  CourseTitle: ").Append(CourseTitle).Append("\n");
            sb.Append("  CreditCategories: ").Append(CreditCategories).Append("\n");
            sb.Append("  EarnedAdditionalCredits: ").Append(EarnedAdditionalCredits).Append("\n");
            sb.Append("  EarnedCreditConversion: ").Append(EarnedCreditConversion).Append("\n");
            sb.Append("  EarnedCredits: ").Append(EarnedCredits).Append("\n");
            sb.Append("  EarnedCreditTypeDescriptor: ").Append(EarnedCreditTypeDescriptor).Append("\n");
            sb.Append("  FinalLetterGradeEarned: ").Append(FinalLetterGradeEarned).Append("\n");
            sb.Append("  FinalNumericGradeEarned: ").Append(FinalNumericGradeEarned).Append("\n");
            sb.Append("  MethodCreditEarnedDescriptor: ").Append(MethodCreditEarnedDescriptor).Append("\n");
            sb.Append("  WhenTakenGradeLevelDescriptor: ").Append(WhenTakenGradeLevelDescriptor).Append("\n");
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
            return this.Equals(input as EdFiCourseTranscript);
        }

        /// <summary>
        /// Returns true if EdFiCourseTranscript instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourseTranscript to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourseTranscript input)
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
                    this.CourseAttemptResultDescriptor == input.CourseAttemptResultDescriptor ||
                    (this.CourseAttemptResultDescriptor != null &&
                    this.CourseAttemptResultDescriptor.Equals(input.CourseAttemptResultDescriptor))
                ) && 
                (
                    this.CourseReference == input.CourseReference ||
                    (this.CourseReference != null &&
                    this.CourseReference.Equals(input.CourseReference))
                ) && 
                (
                    this.ExternalEducationOrganizationReference == input.ExternalEducationOrganizationReference ||
                    (this.ExternalEducationOrganizationReference != null &&
                    this.ExternalEducationOrganizationReference.Equals(input.ExternalEducationOrganizationReference))
                ) && 
                (
                    this.StudentAcademicRecordReference == input.StudentAcademicRecordReference ||
                    (this.StudentAcademicRecordReference != null &&
                    this.StudentAcademicRecordReference.Equals(input.StudentAcademicRecordReference))
                ) && 
                (
                    this.AcademicSubjects == input.AcademicSubjects ||
                    this.AcademicSubjects != null &&
                    this.AcademicSubjects.SequenceEqual(input.AcademicSubjects)
                ) && 
                (
                    this.AlternativeCourseCode == input.AlternativeCourseCode ||
                    (this.AlternativeCourseCode != null &&
                    this.AlternativeCourseCode.Equals(input.AlternativeCourseCode))
                ) && 
                (
                    this.AlternativeCourseIdentificationCodes == input.AlternativeCourseIdentificationCodes ||
                    this.AlternativeCourseIdentificationCodes != null &&
                    this.AlternativeCourseIdentificationCodes.SequenceEqual(input.AlternativeCourseIdentificationCodes)
                ) && 
                (
                    this.AlternativeCourseTitle == input.AlternativeCourseTitle ||
                    (this.AlternativeCourseTitle != null &&
                    this.AlternativeCourseTitle.Equals(input.AlternativeCourseTitle))
                ) && 
                (
                    this.AssigningOrganizationIdentificationCode == input.AssigningOrganizationIdentificationCode ||
                    (this.AssigningOrganizationIdentificationCode != null &&
                    this.AssigningOrganizationIdentificationCode.Equals(input.AssigningOrganizationIdentificationCode))
                ) && 
                (
                    this.AttemptedCreditConversion == input.AttemptedCreditConversion ||
                    (this.AttemptedCreditConversion != null &&
                    this.AttemptedCreditConversion.Equals(input.AttemptedCreditConversion))
                ) && 
                (
                    this.AttemptedCredits == input.AttemptedCredits ||
                    (this.AttemptedCredits != null &&
                    this.AttemptedCredits.Equals(input.AttemptedCredits))
                ) && 
                (
                    this.AttemptedCreditTypeDescriptor == input.AttemptedCreditTypeDescriptor ||
                    (this.AttemptedCreditTypeDescriptor != null &&
                    this.AttemptedCreditTypeDescriptor.Equals(input.AttemptedCreditTypeDescriptor))
                ) && 
                (
                    this.CourseCatalogURL == input.CourseCatalogURL ||
                    (this.CourseCatalogURL != null &&
                    this.CourseCatalogURL.Equals(input.CourseCatalogURL))
                ) && 
                (
                    this.CourseRepeatCodeDescriptor == input.CourseRepeatCodeDescriptor ||
                    (this.CourseRepeatCodeDescriptor != null &&
                    this.CourseRepeatCodeDescriptor.Equals(input.CourseRepeatCodeDescriptor))
                ) && 
                (
                    this.CourseTitle == input.CourseTitle ||
                    (this.CourseTitle != null &&
                    this.CourseTitle.Equals(input.CourseTitle))
                ) && 
                (
                    this.CreditCategories == input.CreditCategories ||
                    this.CreditCategories != null &&
                    this.CreditCategories.SequenceEqual(input.CreditCategories)
                ) && 
                (
                    this.EarnedAdditionalCredits == input.EarnedAdditionalCredits ||
                    this.EarnedAdditionalCredits != null &&
                    this.EarnedAdditionalCredits.SequenceEqual(input.EarnedAdditionalCredits)
                ) && 
                (
                    this.EarnedCreditConversion == input.EarnedCreditConversion ||
                    (this.EarnedCreditConversion != null &&
                    this.EarnedCreditConversion.Equals(input.EarnedCreditConversion))
                ) && 
                (
                    this.EarnedCredits == input.EarnedCredits ||
                    (this.EarnedCredits != null &&
                    this.EarnedCredits.Equals(input.EarnedCredits))
                ) && 
                (
                    this.EarnedCreditTypeDescriptor == input.EarnedCreditTypeDescriptor ||
                    (this.EarnedCreditTypeDescriptor != null &&
                    this.EarnedCreditTypeDescriptor.Equals(input.EarnedCreditTypeDescriptor))
                ) && 
                (
                    this.FinalLetterGradeEarned == input.FinalLetterGradeEarned ||
                    (this.FinalLetterGradeEarned != null &&
                    this.FinalLetterGradeEarned.Equals(input.FinalLetterGradeEarned))
                ) && 
                (
                    this.FinalNumericGradeEarned == input.FinalNumericGradeEarned ||
                    (this.FinalNumericGradeEarned != null &&
                    this.FinalNumericGradeEarned.Equals(input.FinalNumericGradeEarned))
                ) && 
                (
                    this.MethodCreditEarnedDescriptor == input.MethodCreditEarnedDescriptor ||
                    (this.MethodCreditEarnedDescriptor != null &&
                    this.MethodCreditEarnedDescriptor.Equals(input.MethodCreditEarnedDescriptor))
                ) && 
                (
                    this.WhenTakenGradeLevelDescriptor == input.WhenTakenGradeLevelDescriptor ||
                    (this.WhenTakenGradeLevelDescriptor != null &&
                    this.WhenTakenGradeLevelDescriptor.Equals(input.WhenTakenGradeLevelDescriptor))
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
                if (this.CourseAttemptResultDescriptor != null)
                    hashCode = hashCode * 59 + this.CourseAttemptResultDescriptor.GetHashCode();
                if (this.CourseReference != null)
                    hashCode = hashCode * 59 + this.CourseReference.GetHashCode();
                if (this.ExternalEducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.ExternalEducationOrganizationReference.GetHashCode();
                if (this.StudentAcademicRecordReference != null)
                    hashCode = hashCode * 59 + this.StudentAcademicRecordReference.GetHashCode();
                if (this.AcademicSubjects != null)
                    hashCode = hashCode * 59 + this.AcademicSubjects.GetHashCode();
                if (this.AlternativeCourseCode != null)
                    hashCode = hashCode * 59 + this.AlternativeCourseCode.GetHashCode();
                if (this.AlternativeCourseIdentificationCodes != null)
                    hashCode = hashCode * 59 + this.AlternativeCourseIdentificationCodes.GetHashCode();
                if (this.AlternativeCourseTitle != null)
                    hashCode = hashCode * 59 + this.AlternativeCourseTitle.GetHashCode();
                if (this.AssigningOrganizationIdentificationCode != null)
                    hashCode = hashCode * 59 + this.AssigningOrganizationIdentificationCode.GetHashCode();
                if (this.AttemptedCreditConversion != null)
                    hashCode = hashCode * 59 + this.AttemptedCreditConversion.GetHashCode();
                if (this.AttemptedCredits != null)
                    hashCode = hashCode * 59 + this.AttemptedCredits.GetHashCode();
                if (this.AttemptedCreditTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.AttemptedCreditTypeDescriptor.GetHashCode();
                if (this.CourseCatalogURL != null)
                    hashCode = hashCode * 59 + this.CourseCatalogURL.GetHashCode();
                if (this.CourseRepeatCodeDescriptor != null)
                    hashCode = hashCode * 59 + this.CourseRepeatCodeDescriptor.GetHashCode();
                if (this.CourseTitle != null)
                    hashCode = hashCode * 59 + this.CourseTitle.GetHashCode();
                if (this.CreditCategories != null)
                    hashCode = hashCode * 59 + this.CreditCategories.GetHashCode();
                if (this.EarnedAdditionalCredits != null)
                    hashCode = hashCode * 59 + this.EarnedAdditionalCredits.GetHashCode();
                if (this.EarnedCreditConversion != null)
                    hashCode = hashCode * 59 + this.EarnedCreditConversion.GetHashCode();
                if (this.EarnedCredits != null)
                    hashCode = hashCode * 59 + this.EarnedCredits.GetHashCode();
                if (this.EarnedCreditTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.EarnedCreditTypeDescriptor.GetHashCode();
                if (this.FinalLetterGradeEarned != null)
                    hashCode = hashCode * 59 + this.FinalLetterGradeEarned.GetHashCode();
                if (this.FinalNumericGradeEarned != null)
                    hashCode = hashCode * 59 + this.FinalNumericGradeEarned.GetHashCode();
                if (this.MethodCreditEarnedDescriptor != null)
                    hashCode = hashCode * 59 + this.MethodCreditEarnedDescriptor.GetHashCode();
                if (this.WhenTakenGradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.WhenTakenGradeLevelDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
