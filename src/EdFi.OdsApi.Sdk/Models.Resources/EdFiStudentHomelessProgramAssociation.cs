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
    /// EdFiStudentHomelessProgramAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiStudentHomelessProgramAssociation :  IEquatable<EdFiStudentHomelessProgramAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentHomelessProgramAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentHomelessProgramAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentHomelessProgramAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="programReference">programReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="awaitingFosterCare">State defined definition for awaiting foster care..</param>
        /// <param name="endDate">The month, day, and year on which the Student exited the Program or stopped receiving services..</param>
        /// <param name="homelessPrimaryNighttimeResidenceDescriptor">The primary nighttime residence of the student at the time the student is identified as homeless..</param>
        /// <param name="homelessProgramServices">An unordered collection of studentHomelessProgramAssociationHomelessProgramServices. Indicates the service(s) being provided to the Student by the Homeless Program..</param>
        /// <param name="homelessUnaccompaniedYouth">A homeless unaccompanied youth is a youth who is not in the physical custody of a parent or guardian and who fits the McKinney-Vento definition of homeless. Students must be both unaccompanied and homeless to be included as an unaccompanied homeless youth..</param>
        /// <param name="participationStatus">participationStatus.</param>
        /// <param name="reasonExitedDescriptor">The reason the child left the Program within a school or district..</param>
        /// <param name="servedOutsideOfRegularSession">Indicates whether the Student received services during the summer session or between sessions..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentHomelessProgramAssociation(string id = default(string), DateTime? beginDate = default(DateTime?), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiProgramReference programReference = default(EdFiProgramReference), EdFiStudentReference studentReference = default(EdFiStudentReference), bool? awaitingFosterCare = default(bool?), DateTime? endDate = default(DateTime?), string homelessPrimaryNighttimeResidenceDescriptor = default(string), List<EdFiStudentHomelessProgramAssociationHomelessProgramService> homelessProgramServices = default(List<EdFiStudentHomelessProgramAssociationHomelessProgramService>), bool? homelessUnaccompaniedYouth = default(bool?), EdFiGeneralStudentProgramAssociationParticipationStatus participationStatus = default(EdFiGeneralStudentProgramAssociationParticipationStatus), string reasonExitedDescriptor = default(string), bool? servedOutsideOfRegularSession = default(bool?), string etag = default(string))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for EdFiStudentHomelessProgramAssociation and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for EdFiStudentHomelessProgramAssociation and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            // to ensure "programReference" is required (not null)
            if (programReference == null)
            {
                throw new InvalidDataException("programReference is a required property for EdFiStudentHomelessProgramAssociation and cannot be null");
            }
            else
            {
                this.ProgramReference = programReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for EdFiStudentHomelessProgramAssociation and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            this.Id = id;
            this.AwaitingFosterCare = awaitingFosterCare;
            this.EndDate = endDate;
            this.HomelessPrimaryNighttimeResidenceDescriptor = homelessPrimaryNighttimeResidenceDescriptor;
            this.HomelessProgramServices = homelessProgramServices;
            this.HomelessUnaccompaniedYouth = homelessUnaccompaniedYouth;
            this.ParticipationStatus = participationStatus;
            this.ReasonExitedDescriptor = reasonExitedDescriptor;
            this.ServedOutsideOfRegularSession = servedOutsideOfRegularSession;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.
        /// </summary>
        /// <value>The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets ProgramReference
        /// </summary>
        [DataMember(Name="programReference", EmitDefaultValue=false)]
        public EdFiProgramReference ProgramReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// State defined definition for awaiting foster care.
        /// </summary>
        /// <value>State defined definition for awaiting foster care.</value>
        [DataMember(Name="awaitingFosterCare", EmitDefaultValue=false)]
        public bool? AwaitingFosterCare { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student exited the Program or stopped receiving services.
        /// </summary>
        /// <value>The month, day, and year on which the Student exited the Program or stopped receiving services.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The primary nighttime residence of the student at the time the student is identified as homeless.
        /// </summary>
        /// <value>The primary nighttime residence of the student at the time the student is identified as homeless.</value>
        [DataMember(Name="homelessPrimaryNighttimeResidenceDescriptor", EmitDefaultValue=false)]
        public string HomelessPrimaryNighttimeResidenceDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of studentHomelessProgramAssociationHomelessProgramServices. Indicates the service(s) being provided to the Student by the Homeless Program.
        /// </summary>
        /// <value>An unordered collection of studentHomelessProgramAssociationHomelessProgramServices. Indicates the service(s) being provided to the Student by the Homeless Program.</value>
        [DataMember(Name="homelessProgramServices", EmitDefaultValue=false)]
        public List<EdFiStudentHomelessProgramAssociationHomelessProgramService> HomelessProgramServices { get; set; }

        /// <summary>
        /// A homeless unaccompanied youth is a youth who is not in the physical custody of a parent or guardian and who fits the McKinney-Vento definition of homeless. Students must be both unaccompanied and homeless to be included as an unaccompanied homeless youth.
        /// </summary>
        /// <value>A homeless unaccompanied youth is a youth who is not in the physical custody of a parent or guardian and who fits the McKinney-Vento definition of homeless. Students must be both unaccompanied and homeless to be included as an unaccompanied homeless youth.</value>
        [DataMember(Name="homelessUnaccompaniedYouth", EmitDefaultValue=false)]
        public bool? HomelessUnaccompaniedYouth { get; set; }

        /// <summary>
        /// Gets or Sets ParticipationStatus
        /// </summary>
        [DataMember(Name="participationStatus", EmitDefaultValue=false)]
        public EdFiGeneralStudentProgramAssociationParticipationStatus ParticipationStatus { get; set; }

        /// <summary>
        /// The reason the child left the Program within a school or district.
        /// </summary>
        /// <value>The reason the child left the Program within a school or district.</value>
        [DataMember(Name="reasonExitedDescriptor", EmitDefaultValue=false)]
        public string ReasonExitedDescriptor { get; set; }

        /// <summary>
        /// Indicates whether the Student received services during the summer session or between sessions.
        /// </summary>
        /// <value>Indicates whether the Student received services during the summer session or between sessions.</value>
        [DataMember(Name="servedOutsideOfRegularSession", EmitDefaultValue=false)]
        public bool? ServedOutsideOfRegularSession { get; set; }

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
            sb.Append("class EdFiStudentHomelessProgramAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  AwaitingFosterCare: ").Append(AwaitingFosterCare).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  HomelessPrimaryNighttimeResidenceDescriptor: ").Append(HomelessPrimaryNighttimeResidenceDescriptor).Append("\n");
            sb.Append("  HomelessProgramServices: ").Append(HomelessProgramServices).Append("\n");
            sb.Append("  HomelessUnaccompaniedYouth: ").Append(HomelessUnaccompaniedYouth).Append("\n");
            sb.Append("  ParticipationStatus: ").Append(ParticipationStatus).Append("\n");
            sb.Append("  ReasonExitedDescriptor: ").Append(ReasonExitedDescriptor).Append("\n");
            sb.Append("  ServedOutsideOfRegularSession: ").Append(ServedOutsideOfRegularSession).Append("\n");
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
            return this.Equals(input as EdFiStudentHomelessProgramAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStudentHomelessProgramAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentHomelessProgramAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentHomelessProgramAssociation input)
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
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
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
                    this.AwaitingFosterCare == input.AwaitingFosterCare ||
                    (this.AwaitingFosterCare != null &&
                    this.AwaitingFosterCare.Equals(input.AwaitingFosterCare))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.HomelessPrimaryNighttimeResidenceDescriptor == input.HomelessPrimaryNighttimeResidenceDescriptor ||
                    (this.HomelessPrimaryNighttimeResidenceDescriptor != null &&
                    this.HomelessPrimaryNighttimeResidenceDescriptor.Equals(input.HomelessPrimaryNighttimeResidenceDescriptor))
                ) && 
                (
                    this.HomelessProgramServices == input.HomelessProgramServices ||
                    this.HomelessProgramServices != null &&
                    this.HomelessProgramServices.SequenceEqual(input.HomelessProgramServices)
                ) && 
                (
                    this.HomelessUnaccompaniedYouth == input.HomelessUnaccompaniedYouth ||
                    (this.HomelessUnaccompaniedYouth != null &&
                    this.HomelessUnaccompaniedYouth.Equals(input.HomelessUnaccompaniedYouth))
                ) && 
                (
                    this.ParticipationStatus == input.ParticipationStatus ||
                    (this.ParticipationStatus != null &&
                    this.ParticipationStatus.Equals(input.ParticipationStatus))
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
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.ProgramReference != null)
                    hashCode = hashCode * 59 + this.ProgramReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.AwaitingFosterCare != null)
                    hashCode = hashCode * 59 + this.AwaitingFosterCare.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.HomelessPrimaryNighttimeResidenceDescriptor != null)
                    hashCode = hashCode * 59 + this.HomelessPrimaryNighttimeResidenceDescriptor.GetHashCode();
                if (this.HomelessProgramServices != null)
                    hashCode = hashCode * 59 + this.HomelessProgramServices.GetHashCode();
                if (this.HomelessUnaccompaniedYouth != null)
                    hashCode = hashCode * 59 + this.HomelessUnaccompaniedYouth.GetHashCode();
                if (this.ParticipationStatus != null)
                    hashCode = hashCode * 59 + this.ParticipationStatus.GetHashCode();
                if (this.ReasonExitedDescriptor != null)
                    hashCode = hashCode * 59 + this.ReasonExitedDescriptor.GetHashCode();
                if (this.ServedOutsideOfRegularSession != null)
                    hashCode = hashCode * 59 + this.ServedOutsideOfRegularSession.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
