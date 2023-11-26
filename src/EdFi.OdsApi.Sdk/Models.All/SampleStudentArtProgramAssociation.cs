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
    /// SampleStudentArtProgramAssociation
    /// </summary>
    [DataContract(Name = "sample_studentArtProgramAssociation")]
    public partial class SampleStudentArtProgramAssociation : IEquatable<SampleStudentArtProgramAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentArtProgramAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentArtProgramAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentArtProgramAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (required).</param>
        /// <param name="styles">An unordered collection of studentArtProgramAssociationStyles. The art style(s) exhibited by the student in the program. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="programReference">programReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="artMedia">An unordered collection of studentArtProgramAssociationArtMedia. The art mediums used in the program (i.e., paint, pencils, clay, etc.)..</param>
        /// <param name="artPieces">The total number of art pieces completed by the student during the program..</param>
        /// <param name="endDate">The month, day, and year on which the student exited the program or stopped receiving services..</param>
        /// <param name="exhibitDate">Start date for the program&#39;s art exhibit to display the student&#39;s work..</param>
        /// <param name="hoursPerDay">The number of hours a student spends in the program each school day..</param>
        /// <param name="identificationCode">A unique identification code used to identify the student&#39;s artwork produced in the program..</param>
        /// <param name="kilnReservation">The student&#39;s reserved time for use of the kiln..</param>
        /// <param name="kilnReservationLength">The number of clock minutes dedicated to the student&#39;s kiln reservation..</param>
        /// <param name="masteredMediums">Percentage of the mediums taught in the program which the student mastered..</param>
        /// <param name="numberOfDaysInAttendance">Number of days the student is in attendance at the program..</param>
        /// <param name="portfolioPieces">The total number of pieces in the student&#39;s portfolio..</param>
        /// <param name="portfolioYears">An unordered collection of studentArtProgramAssociationPortfolioYears. The of year(s) of work included in the student&#39;s portfolio..</param>
        /// <param name="privateArtProgram">Indicator that the student participated in art education at a private agency or institution. (required).</param>
        /// <param name="programFees">Required program fees to purchase materials for the student..</param>
        /// <param name="programParticipationStatuses">An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation..</param>
        /// <param name="reasonExitedDescriptor">The reason the student left the program within a school or district..</param>
        /// <param name="servedOutsideOfRegularSession">Indicates whether the student received services during the summer session or between sessions..</param>
        /// <param name="services">An unordered collection of studentArtProgramAssociationServices. Indicates the Service(s) being provided to the Student by the Program..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public SampleStudentArtProgramAssociation(string id = default(string), DateTime beginDate = default(DateTime), List<SampleStudentArtProgramAssociationStyle> styles = default(List<SampleStudentArtProgramAssociationStyle>), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiProgramReference programReference = default(EdFiProgramReference), EdFiStudentReference studentReference = default(EdFiStudentReference), List<SampleStudentArtProgramAssociationArtMedium> artMedia = default(List<SampleStudentArtProgramAssociationArtMedium>), int? artPieces = default(int?), DateTime? endDate = default(DateTime?), DateTime? exhibitDate = default(DateTime?), double? hoursPerDay = default(double?), string identificationCode = default(string), string kilnReservation = default(string), string kilnReservationLength = default(string), double? masteredMediums = default(double?), double? numberOfDaysInAttendance = default(double?), int? portfolioPieces = default(int?), List<SampleStudentArtProgramAssociationPortfolioYears> portfolioYears = default(List<SampleStudentArtProgramAssociationPortfolioYears>), bool privateArtProgram = default(bool), double? programFees = default(double?), List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus> programParticipationStatuses = default(List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus>), string reasonExitedDescriptor = default(string), bool? servedOutsideOfRegularSession = default(bool?), List<SampleStudentArtProgramAssociationService> services = default(List<SampleStudentArtProgramAssociationService>), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            this.BeginDate = beginDate;
            // to ensure "styles" is required (not null)
            if (styles == null)
            {
                throw new ArgumentNullException("styles is a required property for SampleStudentArtProgramAssociation and cannot be null");
            }
            this.Styles = styles;
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new ArgumentNullException("educationOrganizationReference is a required property for SampleStudentArtProgramAssociation and cannot be null");
            }
            this.EducationOrganizationReference = educationOrganizationReference;
            // to ensure "programReference" is required (not null)
            if (programReference == null)
            {
                throw new ArgumentNullException("programReference is a required property for SampleStudentArtProgramAssociation and cannot be null");
            }
            this.ProgramReference = programReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for SampleStudentArtProgramAssociation and cannot be null");
            }
            this.StudentReference = studentReference;
            this.PrivateArtProgram = privateArtProgram;
            this.Id = id;
            this.ArtMedia = artMedia;
            this.ArtPieces = artPieces;
            this.EndDate = endDate;
            this.ExhibitDate = exhibitDate;
            this.HoursPerDay = hoursPerDay;
            this.IdentificationCode = identificationCode;
            this.KilnReservation = kilnReservation;
            this.KilnReservationLength = kilnReservationLength;
            this.MasteredMediums = masteredMediums;
            this.NumberOfDaysInAttendance = numberOfDaysInAttendance;
            this.PortfolioPieces = portfolioPieces;
            this.PortfolioYears = portfolioYears;
            this.ProgramFees = programFees;
            this.ProgramParticipationStatuses = programParticipationStatuses;
            this.ReasonExitedDescriptor = reasonExitedDescriptor;
            this.ServedOutsideOfRegularSession = servedOutsideOfRegularSession;
            this.Services = services;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.
        /// </summary>
        /// <value>The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// An unordered collection of studentArtProgramAssociationStyles. The art style(s) exhibited by the student in the program.
        /// </summary>
        /// <value>An unordered collection of studentArtProgramAssociationStyles. The art style(s) exhibited by the student in the program.</value>
        [DataMember(Name = "styles", IsRequired = true, EmitDefaultValue = true)]
        public List<SampleStudentArtProgramAssociationStyle> Styles { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name = "educationOrganizationReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets ProgramReference
        /// </summary>
        [DataMember(Name = "programReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiProgramReference ProgramReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// An unordered collection of studentArtProgramAssociationArtMedia. The art mediums used in the program (i.e., paint, pencils, clay, etc.).
        /// </summary>
        /// <value>An unordered collection of studentArtProgramAssociationArtMedia. The art mediums used in the program (i.e., paint, pencils, clay, etc.).</value>
        [DataMember(Name = "artMedia", EmitDefaultValue = false)]
        public List<SampleStudentArtProgramAssociationArtMedium> ArtMedia { get; set; }

        /// <summary>
        /// The total number of art pieces completed by the student during the program.
        /// </summary>
        /// <value>The total number of art pieces completed by the student during the program.</value>
        [DataMember(Name = "artPieces", EmitDefaultValue = true)]
        public int? ArtPieces { get; set; }

        /// <summary>
        /// The month, day, and year on which the student exited the program or stopped receiving services.
        /// </summary>
        /// <value>The month, day, and year on which the student exited the program or stopped receiving services.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Start date for the program&#39;s art exhibit to display the student&#39;s work.
        /// </summary>
        /// <value>Start date for the program&#39;s art exhibit to display the student&#39;s work.</value>
        [DataMember(Name = "exhibitDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ExhibitDate { get; set; }

        /// <summary>
        /// The number of hours a student spends in the program each school day.
        /// </summary>
        /// <value>The number of hours a student spends in the program each school day.</value>
        [DataMember(Name = "hoursPerDay", EmitDefaultValue = true)]
        public double? HoursPerDay { get; set; }

        /// <summary>
        /// A unique identification code used to identify the student&#39;s artwork produced in the program.
        /// </summary>
        /// <value>A unique identification code used to identify the student&#39;s artwork produced in the program.</value>
        [DataMember(Name = "identificationCode", EmitDefaultValue = true)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// The student&#39;s reserved time for use of the kiln.
        /// </summary>
        /// <value>The student&#39;s reserved time for use of the kiln.</value>
        [DataMember(Name = "kilnReservation", EmitDefaultValue = true)]
        public string KilnReservation { get; set; }

        /// <summary>
        /// The number of clock minutes dedicated to the student&#39;s kiln reservation.
        /// </summary>
        /// <value>The number of clock minutes dedicated to the student&#39;s kiln reservation.</value>
        [DataMember(Name = "kilnReservationLength", EmitDefaultValue = true)]
        public string KilnReservationLength { get; set; }

        /// <summary>
        /// Percentage of the mediums taught in the program which the student mastered.
        /// </summary>
        /// <value>Percentage of the mediums taught in the program which the student mastered.</value>
        [DataMember(Name = "masteredMediums", EmitDefaultValue = true)]
        public double? MasteredMediums { get; set; }

        /// <summary>
        /// Number of days the student is in attendance at the program.
        /// </summary>
        /// <value>Number of days the student is in attendance at the program.</value>
        [DataMember(Name = "numberOfDaysInAttendance", EmitDefaultValue = true)]
        public double? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// The total number of pieces in the student&#39;s portfolio.
        /// </summary>
        /// <value>The total number of pieces in the student&#39;s portfolio.</value>
        [DataMember(Name = "portfolioPieces", EmitDefaultValue = true)]
        public int? PortfolioPieces { get; set; }

        /// <summary>
        /// An unordered collection of studentArtProgramAssociationPortfolioYears. The of year(s) of work included in the student&#39;s portfolio.
        /// </summary>
        /// <value>An unordered collection of studentArtProgramAssociationPortfolioYears. The of year(s) of work included in the student&#39;s portfolio.</value>
        [DataMember(Name = "portfolioYears", EmitDefaultValue = false)]
        public List<SampleStudentArtProgramAssociationPortfolioYears> PortfolioYears { get; set; }

        /// <summary>
        /// Indicator that the student participated in art education at a private agency or institution.
        /// </summary>
        /// <value>Indicator that the student participated in art education at a private agency or institution.</value>
        [DataMember(Name = "privateArtProgram", IsRequired = true, EmitDefaultValue = true)]
        public bool PrivateArtProgram { get; set; }

        /// <summary>
        /// Required program fees to purchase materials for the student.
        /// </summary>
        /// <value>Required program fees to purchase materials for the student.</value>
        [DataMember(Name = "programFees", EmitDefaultValue = true)]
        public double? ProgramFees { get; set; }

        /// <summary>
        /// An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation.
        /// </summary>
        /// <value>An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation.</value>
        [DataMember(Name = "programParticipationStatuses", EmitDefaultValue = false)]
        public List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus> ProgramParticipationStatuses { get; set; }

        /// <summary>
        /// The reason the student left the program within a school or district.
        /// </summary>
        /// <value>The reason the student left the program within a school or district.</value>
        [DataMember(Name = "reasonExitedDescriptor", EmitDefaultValue = true)]
        public string ReasonExitedDescriptor { get; set; }

        /// <summary>
        /// Indicates whether the student received services during the summer session or between sessions.
        /// </summary>
        /// <value>Indicates whether the student received services during the summer session or between sessions.</value>
        [DataMember(Name = "servedOutsideOfRegularSession", EmitDefaultValue = true)]
        public bool? ServedOutsideOfRegularSession { get; set; }

        /// <summary>
        /// An unordered collection of studentArtProgramAssociationServices. Indicates the Service(s) being provided to the Student by the Program.
        /// </summary>
        /// <value>An unordered collection of studentArtProgramAssociationServices. Indicates the Service(s) being provided to the Student by the Program.</value>
        [DataMember(Name = "services", EmitDefaultValue = false)]
        public List<SampleStudentArtProgramAssociationService> Services { get; set; }

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
            sb.Append("class SampleStudentArtProgramAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  Styles: ").Append(Styles).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  ArtMedia: ").Append(ArtMedia).Append("\n");
            sb.Append("  ArtPieces: ").Append(ArtPieces).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExhibitDate: ").Append(ExhibitDate).Append("\n");
            sb.Append("  HoursPerDay: ").Append(HoursPerDay).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
            sb.Append("  KilnReservation: ").Append(KilnReservation).Append("\n");
            sb.Append("  KilnReservationLength: ").Append(KilnReservationLength).Append("\n");
            sb.Append("  MasteredMediums: ").Append(MasteredMediums).Append("\n");
            sb.Append("  NumberOfDaysInAttendance: ").Append(NumberOfDaysInAttendance).Append("\n");
            sb.Append("  PortfolioPieces: ").Append(PortfolioPieces).Append("\n");
            sb.Append("  PortfolioYears: ").Append(PortfolioYears).Append("\n");
            sb.Append("  PrivateArtProgram: ").Append(PrivateArtProgram).Append("\n");
            sb.Append("  ProgramFees: ").Append(ProgramFees).Append("\n");
            sb.Append("  ProgramParticipationStatuses: ").Append(ProgramParticipationStatuses).Append("\n");
            sb.Append("  ReasonExitedDescriptor: ").Append(ReasonExitedDescriptor).Append("\n");
            sb.Append("  ServedOutsideOfRegularSession: ").Append(ServedOutsideOfRegularSession).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
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
            return this.Equals(input as SampleStudentArtProgramAssociation);
        }

        /// <summary>
        /// Returns true if SampleStudentArtProgramAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentArtProgramAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentArtProgramAssociation input)
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
                    this.Styles == input.Styles ||
                    this.Styles != null &&
                    input.Styles != null &&
                    this.Styles.SequenceEqual(input.Styles)
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.ProgramReference == input.ProgramReference ||
                    (this.ProgramReference != null &&
                    this.ProgramReference.Equals(input.ProgramReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.ArtMedia == input.ArtMedia ||
                    this.ArtMedia != null &&
                    input.ArtMedia != null &&
                    this.ArtMedia.SequenceEqual(input.ArtMedia)
                ) && 
                (
                    this.ArtPieces == input.ArtPieces ||
                    (this.ArtPieces != null &&
                    this.ArtPieces.Equals(input.ArtPieces))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ExhibitDate == input.ExhibitDate ||
                    (this.ExhibitDate != null &&
                    this.ExhibitDate.Equals(input.ExhibitDate))
                ) && 
                (
                    this.HoursPerDay == input.HoursPerDay ||
                    (this.HoursPerDay != null &&
                    this.HoursPerDay.Equals(input.HoursPerDay))
                ) && 
                (
                    this.IdentificationCode == input.IdentificationCode ||
                    (this.IdentificationCode != null &&
                    this.IdentificationCode.Equals(input.IdentificationCode))
                ) && 
                (
                    this.KilnReservation == input.KilnReservation ||
                    (this.KilnReservation != null &&
                    this.KilnReservation.Equals(input.KilnReservation))
                ) && 
                (
                    this.KilnReservationLength == input.KilnReservationLength ||
                    (this.KilnReservationLength != null &&
                    this.KilnReservationLength.Equals(input.KilnReservationLength))
                ) && 
                (
                    this.MasteredMediums == input.MasteredMediums ||
                    (this.MasteredMediums != null &&
                    this.MasteredMediums.Equals(input.MasteredMediums))
                ) && 
                (
                    this.NumberOfDaysInAttendance == input.NumberOfDaysInAttendance ||
                    (this.NumberOfDaysInAttendance != null &&
                    this.NumberOfDaysInAttendance.Equals(input.NumberOfDaysInAttendance))
                ) && 
                (
                    this.PortfolioPieces == input.PortfolioPieces ||
                    (this.PortfolioPieces != null &&
                    this.PortfolioPieces.Equals(input.PortfolioPieces))
                ) && 
                (
                    this.PortfolioYears == input.PortfolioYears ||
                    this.PortfolioYears != null &&
                    input.PortfolioYears != null &&
                    this.PortfolioYears.SequenceEqual(input.PortfolioYears)
                ) && 
                (
                    this.PrivateArtProgram == input.PrivateArtProgram ||
                    this.PrivateArtProgram.Equals(input.PrivateArtProgram)
                ) && 
                (
                    this.ProgramFees == input.ProgramFees ||
                    (this.ProgramFees != null &&
                    this.ProgramFees.Equals(input.ProgramFees))
                ) && 
                (
                    this.ProgramParticipationStatuses == input.ProgramParticipationStatuses ||
                    this.ProgramParticipationStatuses != null &&
                    input.ProgramParticipationStatuses != null &&
                    this.ProgramParticipationStatuses.SequenceEqual(input.ProgramParticipationStatuses)
                ) && 
                (
                    this.ReasonExitedDescriptor == input.ReasonExitedDescriptor ||
                    (this.ReasonExitedDescriptor != null &&
                    this.ReasonExitedDescriptor.Equals(input.ReasonExitedDescriptor))
                ) && 
                (
                    this.ServedOutsideOfRegularSession == input.ServedOutsideOfRegularSession ||
                    (this.ServedOutsideOfRegularSession != null &&
                    this.ServedOutsideOfRegularSession.Equals(input.ServedOutsideOfRegularSession))
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
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
                if (this.BeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                }
                if (this.Styles != null)
                {
                    hashCode = (hashCode * 59) + this.Styles.GetHashCode();
                }
                if (this.EducationOrganizationReference != null)
                {
                    hashCode = (hashCode * 59) + this.EducationOrganizationReference.GetHashCode();
                }
                if (this.ProgramReference != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramReference.GetHashCode();
                }
                if (this.StudentReference != null)
                {
                    hashCode = (hashCode * 59) + this.StudentReference.GetHashCode();
                }
                if (this.ArtMedia != null)
                {
                    hashCode = (hashCode * 59) + this.ArtMedia.GetHashCode();
                }
                if (this.ArtPieces != null)
                {
                    hashCode = (hashCode * 59) + this.ArtPieces.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.ExhibitDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExhibitDate.GetHashCode();
                }
                if (this.HoursPerDay != null)
                {
                    hashCode = (hashCode * 59) + this.HoursPerDay.GetHashCode();
                }
                if (this.IdentificationCode != null)
                {
                    hashCode = (hashCode * 59) + this.IdentificationCode.GetHashCode();
                }
                if (this.KilnReservation != null)
                {
                    hashCode = (hashCode * 59) + this.KilnReservation.GetHashCode();
                }
                if (this.KilnReservationLength != null)
                {
                    hashCode = (hashCode * 59) + this.KilnReservationLength.GetHashCode();
                }
                if (this.MasteredMediums != null)
                {
                    hashCode = (hashCode * 59) + this.MasteredMediums.GetHashCode();
                }
                if (this.NumberOfDaysInAttendance != null)
                {
                    hashCode = (hashCode * 59) + this.NumberOfDaysInAttendance.GetHashCode();
                }
                if (this.PortfolioPieces != null)
                {
                    hashCode = (hashCode * 59) + this.PortfolioPieces.GetHashCode();
                }
                if (this.PortfolioYears != null)
                {
                    hashCode = (hashCode * 59) + this.PortfolioYears.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PrivateArtProgram.GetHashCode();
                if (this.ProgramFees != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramFees.GetHashCode();
                }
                if (this.ProgramParticipationStatuses != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramParticipationStatuses.GetHashCode();
                }
                if (this.ReasonExitedDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ReasonExitedDescriptor.GetHashCode();
                }
                if (this.ServedOutsideOfRegularSession != null)
                {
                    hashCode = (hashCode * 59) + this.ServedOutsideOfRegularSession.GetHashCode();
                }
                if (this.Services != null)
                {
                    hashCode = (hashCode * 59) + this.Services.GetHashCode();
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
            // ArtPieces (int?) maximum
            if (this.ArtPieces > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ArtPieces, must be a value less than or equal to 100.", new [] { "ArtPieces" });
            }

            // ArtPieces (int?) minimum
            if (this.ArtPieces < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ArtPieces, must be a value greater than or equal to 0.", new [] { "ArtPieces" });
            }

            // IdentificationCode (string) maxLength
            if (this.IdentificationCode != null && this.IdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationCode, length must be less than 60.", new [] { "IdentificationCode" });
            }

            // IdentificationCode (string) minLength
            if (this.IdentificationCode != null && this.IdentificationCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationCode, length must be greater than 1.", new [] { "IdentificationCode" });
            }

            // KilnReservationLength (string) maxLength
            if (this.KilnReservationLength != null && this.KilnReservationLength.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for KilnReservationLength, length must be less than 30.", new [] { "KilnReservationLength" });
            }

            // NumberOfDaysInAttendance (double?) minimum
            if (this.NumberOfDaysInAttendance < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfDaysInAttendance, must be a value greater than or equal to 0.", new [] { "NumberOfDaysInAttendance" });
            }

            // PortfolioPieces (int?) maximum
            if (this.PortfolioPieces > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioPieces, must be a value less than or equal to 100.", new [] { "PortfolioPieces" });
            }

            // PortfolioPieces (int?) minimum
            if (this.PortfolioPieces < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioPieces, must be a value greater than or equal to 0.", new [] { "PortfolioPieces" });
            }

            // ReasonExitedDescriptor (string) maxLength
            if (this.ReasonExitedDescriptor != null && this.ReasonExitedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReasonExitedDescriptor, length must be less than 306.", new [] { "ReasonExitedDescriptor" });
            }

            yield break;
        }
    }

}