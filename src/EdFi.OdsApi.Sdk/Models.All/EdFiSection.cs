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
    /// EdFiSection
    /// </summary>
    [DataContract(Name = "edFi_section")]
    public partial class EdFiSection : IEquatable<EdFiSection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSection" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sectionIdentifier">The local identifier assigned to a section. (required).</param>
        /// <param name="courseOfferingReference">courseOfferingReference (required).</param>
        /// <param name="locationReference">locationReference.</param>
        /// <param name="locationSchoolReference">locationSchoolReference.</param>
        /// <param name="availableCreditConversion">Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units..</param>
        /// <param name="availableCredits">The value of credits or units of value awarded for the completion of a course..</param>
        /// <param name="availableCreditTypeDescriptor">The type of credits or units of value awarded for the completion of a course..</param>
        /// <param name="characteristics">An unordered collection of sectionCharacteristics. Reflects important characteristics of the section, such as whether or not attendance is taken and the section is graded..</param>
        /// <param name="classPeriods">An unordered collection of sectionClassPeriods. The class period during which the section meets..</param>
        /// <param name="courseLevelCharacteristics">An unordered collection of sectionCourseLevelCharacteristics. The type of specific program or designation with which the section is associated. This collection should only be populated if it differs from the course level characteristics identified at the course offering level..</param>
        /// <param name="educationalEnvironmentDescriptor">The setting in which a student receives education and related services..</param>
        /// <param name="instructionLanguageDescriptor">The primary language of instruction. If omitted, English is assumed..</param>
        /// <param name="mediumOfInstructionDescriptor">The media through which teachers provide instruction to students and students and teachers communicate about instructional matters..</param>
        /// <param name="offeredGradeLevels">An unordered collection of sectionOfferedGradeLevels. The grade levels in which the section is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the course offering level..</param>
        /// <param name="officialAttendancePeriod">Indicator of whether this section is used for official daily attendance. Alternatively, official daily attendance may be tied to a class period..</param>
        /// <param name="populationServedDescriptor">The type of students the section is offered and tailored to..</param>
        /// <param name="programs">An unordered collection of sectionPrograms. Optional reference to program to which the section is associated..</param>
        /// <param name="sectionName">A locally-defined name for the section, generally created to make the section more recognizable in informal contexts and generally distinct from the section identifier..</param>
        /// <param name="sequenceOfCourse">When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiSection(string id = default(string), string sectionIdentifier = default(string), EdFiCourseOfferingReference courseOfferingReference = default(EdFiCourseOfferingReference), EdFiLocationReference locationReference = default(EdFiLocationReference), EdFiSchoolReference locationSchoolReference = default(EdFiSchoolReference), double? availableCreditConversion = default(double?), double? availableCredits = default(double?), string availableCreditTypeDescriptor = default(string), List<EdFiSectionCharacteristic> characteristics = default(List<EdFiSectionCharacteristic>), List<EdFiSectionClassPeriod> classPeriods = default(List<EdFiSectionClassPeriod>), List<EdFiSectionCourseLevelCharacteristic> courseLevelCharacteristics = default(List<EdFiSectionCourseLevelCharacteristic>), string educationalEnvironmentDescriptor = default(string), string instructionLanguageDescriptor = default(string), string mediumOfInstructionDescriptor = default(string), List<EdFiSectionOfferedGradeLevel> offeredGradeLevels = default(List<EdFiSectionOfferedGradeLevel>), bool? officialAttendancePeriod = default(bool?), string populationServedDescriptor = default(string), List<EdFiSectionProgram> programs = default(List<EdFiSectionProgram>), string sectionName = default(string), int? sequenceOfCourse = default(int?), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "sectionIdentifier" is required (not null)
            if (sectionIdentifier == null)
            {
                throw new ArgumentNullException("sectionIdentifier is a required property for EdFiSection and cannot be null");
            }
            this.SectionIdentifier = sectionIdentifier;
            // to ensure "courseOfferingReference" is required (not null)
            if (courseOfferingReference == null)
            {
                throw new ArgumentNullException("courseOfferingReference is a required property for EdFiSection and cannot be null");
            }
            this.CourseOfferingReference = courseOfferingReference;
            this.Id = id;
            this.LocationReference = locationReference;
            this.LocationSchoolReference = locationSchoolReference;
            this.AvailableCreditConversion = availableCreditConversion;
            this.AvailableCredits = availableCredits;
            this.AvailableCreditTypeDescriptor = availableCreditTypeDescriptor;
            this.Characteristics = characteristics;
            this.ClassPeriods = classPeriods;
            this.CourseLevelCharacteristics = courseLevelCharacteristics;
            this.EducationalEnvironmentDescriptor = educationalEnvironmentDescriptor;
            this.InstructionLanguageDescriptor = instructionLanguageDescriptor;
            this.MediumOfInstructionDescriptor = mediumOfInstructionDescriptor;
            this.OfferedGradeLevels = offeredGradeLevels;
            this.OfficialAttendancePeriod = officialAttendancePeriod;
            this.PopulationServedDescriptor = populationServedDescriptor;
            this.Programs = programs;
            this.SectionName = sectionName;
            this.SequenceOfCourse = sequenceOfCourse;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The local identifier assigned to a section.
        /// </summary>
        /// <value>The local identifier assigned to a section.</value>
        [DataMember(Name = "sectionIdentifier", IsRequired = true, EmitDefaultValue = true)]
        public string SectionIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets CourseOfferingReference
        /// </summary>
        [DataMember(Name = "courseOfferingReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiCourseOfferingReference CourseOfferingReference { get; set; }

        /// <summary>
        /// Gets or Sets LocationReference
        /// </summary>
        [DataMember(Name = "locationReference", EmitDefaultValue = false)]
        public EdFiLocationReference LocationReference { get; set; }

        /// <summary>
        /// Gets or Sets LocationSchoolReference
        /// </summary>
        [DataMember(Name = "locationSchoolReference", EmitDefaultValue = false)]
        public EdFiSchoolReference LocationSchoolReference { get; set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        /// <value>Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</value>
        [DataMember(Name = "availableCreditConversion", EmitDefaultValue = true)]
        public double? AvailableCreditConversion { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name = "availableCredits", EmitDefaultValue = true)]
        public double? AvailableCredits { get; set; }

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name = "availableCreditTypeDescriptor", EmitDefaultValue = true)]
        public string AvailableCreditTypeDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of sectionCharacteristics. Reflects important characteristics of the section, such as whether or not attendance is taken and the section is graded.
        /// </summary>
        /// <value>An unordered collection of sectionCharacteristics. Reflects important characteristics of the section, such as whether or not attendance is taken and the section is graded.</value>
        [DataMember(Name = "characteristics", EmitDefaultValue = false)]
        public List<EdFiSectionCharacteristic> Characteristics { get; set; }

        /// <summary>
        /// An unordered collection of sectionClassPeriods. The class period during which the section meets.
        /// </summary>
        /// <value>An unordered collection of sectionClassPeriods. The class period during which the section meets.</value>
        [DataMember(Name = "classPeriods", EmitDefaultValue = false)]
        public List<EdFiSectionClassPeriod> ClassPeriods { get; set; }

        /// <summary>
        /// An unordered collection of sectionCourseLevelCharacteristics. The type of specific program or designation with which the section is associated. This collection should only be populated if it differs from the course level characteristics identified at the course offering level.
        /// </summary>
        /// <value>An unordered collection of sectionCourseLevelCharacteristics. The type of specific program or designation with which the section is associated. This collection should only be populated if it differs from the course level characteristics identified at the course offering level.</value>
        [DataMember(Name = "courseLevelCharacteristics", EmitDefaultValue = false)]
        public List<EdFiSectionCourseLevelCharacteristic> CourseLevelCharacteristics { get; set; }

        /// <summary>
        /// The setting in which a student receives education and related services.
        /// </summary>
        /// <value>The setting in which a student receives education and related services.</value>
        [DataMember(Name = "educationalEnvironmentDescriptor", EmitDefaultValue = true)]
        public string EducationalEnvironmentDescriptor { get; set; }

        /// <summary>
        /// The primary language of instruction. If omitted, English is assumed.
        /// </summary>
        /// <value>The primary language of instruction. If omitted, English is assumed.</value>
        [DataMember(Name = "instructionLanguageDescriptor", EmitDefaultValue = true)]
        public string InstructionLanguageDescriptor { get; set; }

        /// <summary>
        /// The media through which teachers provide instruction to students and students and teachers communicate about instructional matters.
        /// </summary>
        /// <value>The media through which teachers provide instruction to students and students and teachers communicate about instructional matters.</value>
        [DataMember(Name = "mediumOfInstructionDescriptor", EmitDefaultValue = true)]
        public string MediumOfInstructionDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of sectionOfferedGradeLevels. The grade levels in which the section is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the course offering level.
        /// </summary>
        /// <value>An unordered collection of sectionOfferedGradeLevels. The grade levels in which the section is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the course offering level.</value>
        [DataMember(Name = "offeredGradeLevels", EmitDefaultValue = false)]
        public List<EdFiSectionOfferedGradeLevel> OfferedGradeLevels { get; set; }

        /// <summary>
        /// Indicator of whether this section is used for official daily attendance. Alternatively, official daily attendance may be tied to a class period.
        /// </summary>
        /// <value>Indicator of whether this section is used for official daily attendance. Alternatively, official daily attendance may be tied to a class period.</value>
        [DataMember(Name = "officialAttendancePeriod", EmitDefaultValue = true)]
        public bool? OfficialAttendancePeriod { get; set; }

        /// <summary>
        /// The type of students the section is offered and tailored to.
        /// </summary>
        /// <value>The type of students the section is offered and tailored to.</value>
        [DataMember(Name = "populationServedDescriptor", EmitDefaultValue = true)]
        public string PopulationServedDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of sectionPrograms. Optional reference to program to which the section is associated.
        /// </summary>
        /// <value>An unordered collection of sectionPrograms. Optional reference to program to which the section is associated.</value>
        [DataMember(Name = "programs", EmitDefaultValue = false)]
        public List<EdFiSectionProgram> Programs { get; set; }

        /// <summary>
        /// A locally-defined name for the section, generally created to make the section more recognizable in informal contexts and generally distinct from the section identifier.
        /// </summary>
        /// <value>A locally-defined name for the section, generally created to make the section more recognizable in informal contexts and generally distinct from the section identifier.</value>
        [DataMember(Name = "sectionName", EmitDefaultValue = true)]
        public string SectionName { get; set; }

        /// <summary>
        /// When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1.
        /// </summary>
        /// <value>When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1.</value>
        [DataMember(Name = "sequenceOfCourse", EmitDefaultValue = true)]
        public int? SequenceOfCourse { get; set; }

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
            sb.Append("class EdFiSection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SectionIdentifier: ").Append(SectionIdentifier).Append("\n");
            sb.Append("  CourseOfferingReference: ").Append(CourseOfferingReference).Append("\n");
            sb.Append("  LocationReference: ").Append(LocationReference).Append("\n");
            sb.Append("  LocationSchoolReference: ").Append(LocationSchoolReference).Append("\n");
            sb.Append("  AvailableCreditConversion: ").Append(AvailableCreditConversion).Append("\n");
            sb.Append("  AvailableCredits: ").Append(AvailableCredits).Append("\n");
            sb.Append("  AvailableCreditTypeDescriptor: ").Append(AvailableCreditTypeDescriptor).Append("\n");
            sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
            sb.Append("  ClassPeriods: ").Append(ClassPeriods).Append("\n");
            sb.Append("  CourseLevelCharacteristics: ").Append(CourseLevelCharacteristics).Append("\n");
            sb.Append("  EducationalEnvironmentDescriptor: ").Append(EducationalEnvironmentDescriptor).Append("\n");
            sb.Append("  InstructionLanguageDescriptor: ").Append(InstructionLanguageDescriptor).Append("\n");
            sb.Append("  MediumOfInstructionDescriptor: ").Append(MediumOfInstructionDescriptor).Append("\n");
            sb.Append("  OfferedGradeLevels: ").Append(OfferedGradeLevels).Append("\n");
            sb.Append("  OfficialAttendancePeriod: ").Append(OfficialAttendancePeriod).Append("\n");
            sb.Append("  PopulationServedDescriptor: ").Append(PopulationServedDescriptor).Append("\n");
            sb.Append("  Programs: ").Append(Programs).Append("\n");
            sb.Append("  SectionName: ").Append(SectionName).Append("\n");
            sb.Append("  SequenceOfCourse: ").Append(SequenceOfCourse).Append("\n");
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
            return this.Equals(input as EdFiSection);
        }

        /// <summary>
        /// Returns true if EdFiSection instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSection input)
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
                    this.SectionIdentifier == input.SectionIdentifier ||
                    (this.SectionIdentifier != null &&
                    this.SectionIdentifier.Equals(input.SectionIdentifier))
                ) && 
                (
                    this.CourseOfferingReference == input.CourseOfferingReference ||
                    (this.CourseOfferingReference != null &&
                    this.CourseOfferingReference.Equals(input.CourseOfferingReference))
                ) && 
                (
                    this.LocationReference == input.LocationReference ||
                    (this.LocationReference != null &&
                    this.LocationReference.Equals(input.LocationReference))
                ) && 
                (
                    this.LocationSchoolReference == input.LocationSchoolReference ||
                    (this.LocationSchoolReference != null &&
                    this.LocationSchoolReference.Equals(input.LocationSchoolReference))
                ) && 
                (
                    this.AvailableCreditConversion == input.AvailableCreditConversion ||
                    (this.AvailableCreditConversion != null &&
                    this.AvailableCreditConversion.Equals(input.AvailableCreditConversion))
                ) && 
                (
                    this.AvailableCredits == input.AvailableCredits ||
                    (this.AvailableCredits != null &&
                    this.AvailableCredits.Equals(input.AvailableCredits))
                ) && 
                (
                    this.AvailableCreditTypeDescriptor == input.AvailableCreditTypeDescriptor ||
                    (this.AvailableCreditTypeDescriptor != null &&
                    this.AvailableCreditTypeDescriptor.Equals(input.AvailableCreditTypeDescriptor))
                ) && 
                (
                    this.Characteristics == input.Characteristics ||
                    this.Characteristics != null &&
                    input.Characteristics != null &&
                    this.Characteristics.SequenceEqual(input.Characteristics)
                ) && 
                (
                    this.ClassPeriods == input.ClassPeriods ||
                    this.ClassPeriods != null &&
                    input.ClassPeriods != null &&
                    this.ClassPeriods.SequenceEqual(input.ClassPeriods)
                ) && 
                (
                    this.CourseLevelCharacteristics == input.CourseLevelCharacteristics ||
                    this.CourseLevelCharacteristics != null &&
                    input.CourseLevelCharacteristics != null &&
                    this.CourseLevelCharacteristics.SequenceEqual(input.CourseLevelCharacteristics)
                ) && 
                (
                    this.EducationalEnvironmentDescriptor == input.EducationalEnvironmentDescriptor ||
                    (this.EducationalEnvironmentDescriptor != null &&
                    this.EducationalEnvironmentDescriptor.Equals(input.EducationalEnvironmentDescriptor))
                ) && 
                (
                    this.InstructionLanguageDescriptor == input.InstructionLanguageDescriptor ||
                    (this.InstructionLanguageDescriptor != null &&
                    this.InstructionLanguageDescriptor.Equals(input.InstructionLanguageDescriptor))
                ) && 
                (
                    this.MediumOfInstructionDescriptor == input.MediumOfInstructionDescriptor ||
                    (this.MediumOfInstructionDescriptor != null &&
                    this.MediumOfInstructionDescriptor.Equals(input.MediumOfInstructionDescriptor))
                ) && 
                (
                    this.OfferedGradeLevels == input.OfferedGradeLevels ||
                    this.OfferedGradeLevels != null &&
                    input.OfferedGradeLevels != null &&
                    this.OfferedGradeLevels.SequenceEqual(input.OfferedGradeLevels)
                ) && 
                (
                    this.OfficialAttendancePeriod == input.OfficialAttendancePeriod ||
                    (this.OfficialAttendancePeriod != null &&
                    this.OfficialAttendancePeriod.Equals(input.OfficialAttendancePeriod))
                ) && 
                (
                    this.PopulationServedDescriptor == input.PopulationServedDescriptor ||
                    (this.PopulationServedDescriptor != null &&
                    this.PopulationServedDescriptor.Equals(input.PopulationServedDescriptor))
                ) && 
                (
                    this.Programs == input.Programs ||
                    this.Programs != null &&
                    input.Programs != null &&
                    this.Programs.SequenceEqual(input.Programs)
                ) && 
                (
                    this.SectionName == input.SectionName ||
                    (this.SectionName != null &&
                    this.SectionName.Equals(input.SectionName))
                ) && 
                (
                    this.SequenceOfCourse == input.SequenceOfCourse ||
                    (this.SequenceOfCourse != null &&
                    this.SequenceOfCourse.Equals(input.SequenceOfCourse))
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
                if (this.SectionIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.SectionIdentifier.GetHashCode();
                }
                if (this.CourseOfferingReference != null)
                {
                    hashCode = (hashCode * 59) + this.CourseOfferingReference.GetHashCode();
                }
                if (this.LocationReference != null)
                {
                    hashCode = (hashCode * 59) + this.LocationReference.GetHashCode();
                }
                if (this.LocationSchoolReference != null)
                {
                    hashCode = (hashCode * 59) + this.LocationSchoolReference.GetHashCode();
                }
                if (this.AvailableCreditConversion != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableCreditConversion.GetHashCode();
                }
                if (this.AvailableCredits != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableCredits.GetHashCode();
                }
                if (this.AvailableCreditTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableCreditTypeDescriptor.GetHashCode();
                }
                if (this.Characteristics != null)
                {
                    hashCode = (hashCode * 59) + this.Characteristics.GetHashCode();
                }
                if (this.ClassPeriods != null)
                {
                    hashCode = (hashCode * 59) + this.ClassPeriods.GetHashCode();
                }
                if (this.CourseLevelCharacteristics != null)
                {
                    hashCode = (hashCode * 59) + this.CourseLevelCharacteristics.GetHashCode();
                }
                if (this.EducationalEnvironmentDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.EducationalEnvironmentDescriptor.GetHashCode();
                }
                if (this.InstructionLanguageDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.InstructionLanguageDescriptor.GetHashCode();
                }
                if (this.MediumOfInstructionDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.MediumOfInstructionDescriptor.GetHashCode();
                }
                if (this.OfferedGradeLevels != null)
                {
                    hashCode = (hashCode * 59) + this.OfferedGradeLevels.GetHashCode();
                }
                if (this.OfficialAttendancePeriod != null)
                {
                    hashCode = (hashCode * 59) + this.OfficialAttendancePeriod.GetHashCode();
                }
                if (this.PopulationServedDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.PopulationServedDescriptor.GetHashCode();
                }
                if (this.Programs != null)
                {
                    hashCode = (hashCode * 59) + this.Programs.GetHashCode();
                }
                if (this.SectionName != null)
                {
                    hashCode = (hashCode * 59) + this.SectionName.GetHashCode();
                }
                if (this.SequenceOfCourse != null)
                {
                    hashCode = (hashCode * 59) + this.SequenceOfCourse.GetHashCode();
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
            // SectionIdentifier (string) maxLength
            if (this.SectionIdentifier != null && this.SectionIdentifier.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionIdentifier, length must be less than 255.", new [] { "SectionIdentifier" });
            }

            // SectionIdentifier (string) minLength
            if (this.SectionIdentifier != null && this.SectionIdentifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionIdentifier, length must be greater than 1.", new [] { "SectionIdentifier" });
            }

            // AvailableCredits (double?) minimum
            if (this.AvailableCredits < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AvailableCredits, must be a value greater than or equal to 0.", new [] { "AvailableCredits" });
            }

            // AvailableCreditTypeDescriptor (string) maxLength
            if (this.AvailableCreditTypeDescriptor != null && this.AvailableCreditTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AvailableCreditTypeDescriptor, length must be less than 306.", new [] { "AvailableCreditTypeDescriptor" });
            }

            // EducationalEnvironmentDescriptor (string) maxLength
            if (this.EducationalEnvironmentDescriptor != null && this.EducationalEnvironmentDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducationalEnvironmentDescriptor, length must be less than 306.", new [] { "EducationalEnvironmentDescriptor" });
            }

            // InstructionLanguageDescriptor (string) maxLength
            if (this.InstructionLanguageDescriptor != null && this.InstructionLanguageDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstructionLanguageDescriptor, length must be less than 306.", new [] { "InstructionLanguageDescriptor" });
            }

            // MediumOfInstructionDescriptor (string) maxLength
            if (this.MediumOfInstructionDescriptor != null && this.MediumOfInstructionDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MediumOfInstructionDescriptor, length must be less than 306.", new [] { "MediumOfInstructionDescriptor" });
            }

            // PopulationServedDescriptor (string) maxLength
            if (this.PopulationServedDescriptor != null && this.PopulationServedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PopulationServedDescriptor, length must be less than 306.", new [] { "PopulationServedDescriptor" });
            }

            // SectionName (string) maxLength
            if (this.SectionName != null && this.SectionName.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionName, length must be less than 100.", new [] { "SectionName" });
            }

            // SectionName (string) minLength
            if (this.SectionName != null && this.SectionName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionName, length must be greater than 1.", new [] { "SectionName" });
            }

            // SequenceOfCourse (int?) maximum
            if (this.SequenceOfCourse > (int?)8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SequenceOfCourse, must be a value less than or equal to 8.", new [] { "SequenceOfCourse" });
            }

            // SequenceOfCourse (int?) minimum
            if (this.SequenceOfCourse < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SequenceOfCourse, must be a value greater than or equal to 1.", new [] { "SequenceOfCourse" });
            }

            yield break;
        }
    }

}
