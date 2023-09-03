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
    /// EdFiStudentProgramAssociationReference
    /// </summary>
    [DataContract]
    public partial class EdFiStudentProgramAssociationReference :  IEquatable<EdFiStudentProgramAssociationReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentProgramAssociationReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentProgramAssociationReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentProgramAssociationReference" /> class.
        /// </summary>
        /// <param name="beginDate">The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (required).</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="programEducationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="programName">The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (required).</param>
        /// <param name="programTypeDescriptor">The type of program. (required).</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="link">link.</param>
        public EdFiStudentProgramAssociationReference(DateTime? beginDate = default(DateTime?), int? educationOrganizationId = default(int?), int? programEducationOrganizationId = default(int?), string programName = default(string), string programTypeDescriptor = default(string), string studentUniqueId = default(string), Link link = default(Link))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for EdFiStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "educationOrganizationId" is required (not null)
            if (educationOrganizationId == null)
            {
                throw new InvalidDataException("educationOrganizationId is a required property for EdFiStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.EducationOrganizationId = educationOrganizationId;
            }
            // to ensure "programEducationOrganizationId" is required (not null)
            if (programEducationOrganizationId == null)
            {
                throw new InvalidDataException("programEducationOrganizationId is a required property for EdFiStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.ProgramEducationOrganizationId = programEducationOrganizationId;
            }
            // to ensure "programName" is required (not null)
            if (programName == null)
            {
                throw new InvalidDataException("programName is a required property for EdFiStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.ProgramName = programName;
            }
            // to ensure "programTypeDescriptor" is required (not null)
            if (programTypeDescriptor == null)
            {
                throw new InvalidDataException("programTypeDescriptor is a required property for EdFiStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.ProgramTypeDescriptor = programTypeDescriptor;
            }
            // to ensure "studentUniqueId" is required (not null)
            if (studentUniqueId == null)
            {
                throw new InvalidDataException("studentUniqueId is a required property for EdFiStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.StudentUniqueId = studentUniqueId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.
        /// </summary>
        /// <value>The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name="educationOrganizationId", EmitDefaultValue=false)]
        public int? EducationOrganizationId { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name="programEducationOrganizationId", EmitDefaultValue=false)]
        public int? ProgramEducationOrganizationId { get; set; }

        /// <summary>
        /// The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies.
        /// </summary>
        /// <value>The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies.</value>
        [DataMember(Name="programName", EmitDefaultValue=false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// The type of program.
        /// </summary>
        /// <value>The type of program.</value>
        [DataMember(Name="programTypeDescriptor", EmitDefaultValue=false)]
        public string ProgramTypeDescriptor { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name="studentUniqueId", EmitDefaultValue=false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentProgramAssociationReference {\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  ProgramEducationOrganizationId: ").Append(ProgramEducationOrganizationId).Append("\n");
            sb.Append("  ProgramName: ").Append(ProgramName).Append("\n");
            sb.Append("  ProgramTypeDescriptor: ").Append(ProgramTypeDescriptor).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiStudentProgramAssociationReference);
        }

        /// <summary>
        /// Returns true if EdFiStudentProgramAssociationReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentProgramAssociationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentProgramAssociationReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    (this.EducationOrganizationId != null &&
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId))
                ) && 
                (
                    this.ProgramEducationOrganizationId == input.ProgramEducationOrganizationId ||
                    (this.ProgramEducationOrganizationId != null &&
                    this.ProgramEducationOrganizationId.Equals(input.ProgramEducationOrganizationId))
                ) && 
                (
                    this.ProgramName == input.ProgramName ||
                    (this.ProgramName != null &&
                    this.ProgramName.Equals(input.ProgramName))
                ) && 
                (
                    this.ProgramTypeDescriptor == input.ProgramTypeDescriptor ||
                    (this.ProgramTypeDescriptor != null &&
                    this.ProgramTypeDescriptor.Equals(input.ProgramTypeDescriptor))
                ) && 
                (
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EducationOrganizationId != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationId.GetHashCode();
                if (this.ProgramEducationOrganizationId != null)
                    hashCode = hashCode * 59 + this.ProgramEducationOrganizationId.GetHashCode();
                if (this.ProgramName != null)
                    hashCode = hashCode * 59 + this.ProgramName.GetHashCode();
                if (this.ProgramTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.ProgramTypeDescriptor.GetHashCode();
                if (this.StudentUniqueId != null)
                    hashCode = hashCode * 59 + this.StudentUniqueId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
