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
    /// TpdmFieldworkExperience
    /// </summary>
    [DataContract]
    public partial class TpdmFieldworkExperience :  IEquatable<TpdmFieldworkExperience>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmFieldworkExperience" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmFieldworkExperience() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmFieldworkExperience" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The month, day, and year on which the staff first starts fieldwork. (required).</param>
        /// <param name="fieldworkIdentifier">The unique identifier for the fieldwork experience (required).</param>
        /// <param name="schools">An unordered collection of fieldworkExperienceSchools. The school the field work experience is associated with (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="coteaching">coteaching.</param>
        /// <param name="endDate">The month, day, and year on which the staff ends fieldwork..</param>
        /// <param name="fieldworkTypeDescriptor">The type of fieldwork being executed by a staff. (required).</param>
        /// <param name="hoursCompleted">The number of hours completed during the fieldwork experience..</param>
        /// <param name="programGatewayDescriptor">The descriptor holds the program gateway that is associated with continuation in a program..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmFieldworkExperience(string id = default(string), DateTime? beginDate = default(DateTime?), string fieldworkIdentifier = default(string), List<TpdmFieldworkExperienceSchool> schools = default(List<TpdmFieldworkExperienceSchool>), EdFiStudentReference studentReference = default(EdFiStudentReference), TpdmFieldworkExperienceCoteaching coteaching = default(TpdmFieldworkExperienceCoteaching), DateTime? endDate = default(DateTime?), string fieldworkTypeDescriptor = default(string), double? hoursCompleted = default(double?), string programGatewayDescriptor = default(string), string etag = default(string))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for TpdmFieldworkExperience and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "fieldworkIdentifier" is required (not null)
            if (fieldworkIdentifier == null)
            {
                throw new InvalidDataException("fieldworkIdentifier is a required property for TpdmFieldworkExperience and cannot be null");
            }
            else
            {
                this.FieldworkIdentifier = fieldworkIdentifier;
            }
            // to ensure "schools" is required (not null)
            if (schools == null)
            {
                throw new InvalidDataException("schools is a required property for TpdmFieldworkExperience and cannot be null");
            }
            else
            {
                this.Schools = schools;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for TpdmFieldworkExperience and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            // to ensure "fieldworkTypeDescriptor" is required (not null)
            if (fieldworkTypeDescriptor == null)
            {
                throw new InvalidDataException("fieldworkTypeDescriptor is a required property for TpdmFieldworkExperience and cannot be null");
            }
            else
            {
                this.FieldworkTypeDescriptor = fieldworkTypeDescriptor;
            }
            this.Id = id;
            this.Coteaching = coteaching;
            this.EndDate = endDate;
            this.HoursCompleted = hoursCompleted;
            this.ProgramGatewayDescriptor = programGatewayDescriptor;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The month, day, and year on which the staff first starts fieldwork.
        /// </summary>
        /// <value>The month, day, and year on which the staff first starts fieldwork.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The unique identifier for the fieldwork experience
        /// </summary>
        /// <value>The unique identifier for the fieldwork experience</value>
        [DataMember(Name="fieldworkIdentifier", EmitDefaultValue=false)]
        public string FieldworkIdentifier { get; set; }

        /// <summary>
        /// An unordered collection of fieldworkExperienceSchools. The school the field work experience is associated with
        /// </summary>
        /// <value>An unordered collection of fieldworkExperienceSchools. The school the field work experience is associated with</value>
        [DataMember(Name="schools", EmitDefaultValue=false)]
        public List<TpdmFieldworkExperienceSchool> Schools { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// Gets or Sets Coteaching
        /// </summary>
        [DataMember(Name="coteaching", EmitDefaultValue=false)]
        public TpdmFieldworkExperienceCoteaching Coteaching { get; set; }

        /// <summary>
        /// The month, day, and year on which the staff ends fieldwork.
        /// </summary>
        /// <value>The month, day, and year on which the staff ends fieldwork.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The type of fieldwork being executed by a staff.
        /// </summary>
        /// <value>The type of fieldwork being executed by a staff.</value>
        [DataMember(Name="fieldworkTypeDescriptor", EmitDefaultValue=false)]
        public string FieldworkTypeDescriptor { get; set; }

        /// <summary>
        /// The number of hours completed during the fieldwork experience.
        /// </summary>
        /// <value>The number of hours completed during the fieldwork experience.</value>
        [DataMember(Name="hoursCompleted", EmitDefaultValue=false)]
        public double? HoursCompleted { get; set; }

        /// <summary>
        /// The descriptor holds the program gateway that is associated with continuation in a program.
        /// </summary>
        /// <value>The descriptor holds the program gateway that is associated with continuation in a program.</value>
        [DataMember(Name="programGatewayDescriptor", EmitDefaultValue=false)]
        public string ProgramGatewayDescriptor { get; set; }

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
            sb.Append("class TpdmFieldworkExperience {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  FieldworkIdentifier: ").Append(FieldworkIdentifier).Append("\n");
            sb.Append("  Schools: ").Append(Schools).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  Coteaching: ").Append(Coteaching).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FieldworkTypeDescriptor: ").Append(FieldworkTypeDescriptor).Append("\n");
            sb.Append("  HoursCompleted: ").Append(HoursCompleted).Append("\n");
            sb.Append("  ProgramGatewayDescriptor: ").Append(ProgramGatewayDescriptor).Append("\n");
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
            return this.Equals(input as TpdmFieldworkExperience);
        }

        /// <summary>
        /// Returns true if TpdmFieldworkExperience instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmFieldworkExperience to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmFieldworkExperience input)
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
                    this.FieldworkIdentifier == input.FieldworkIdentifier ||
                    (this.FieldworkIdentifier != null &&
                    this.FieldworkIdentifier.Equals(input.FieldworkIdentifier))
                ) && 
                (
                    this.Schools == input.Schools ||
                    this.Schools != null &&
                    this.Schools.SequenceEqual(input.Schools)
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.Coteaching == input.Coteaching ||
                    (this.Coteaching != null &&
                    this.Coteaching.Equals(input.Coteaching))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.FieldworkTypeDescriptor == input.FieldworkTypeDescriptor ||
                    (this.FieldworkTypeDescriptor != null &&
                    this.FieldworkTypeDescriptor.Equals(input.FieldworkTypeDescriptor))
                ) && 
                (
                    this.HoursCompleted == input.HoursCompleted ||
                    (this.HoursCompleted != null &&
                    this.HoursCompleted.Equals(input.HoursCompleted))
                ) && 
                (
                    this.ProgramGatewayDescriptor == input.ProgramGatewayDescriptor ||
                    (this.ProgramGatewayDescriptor != null &&
                    this.ProgramGatewayDescriptor.Equals(input.ProgramGatewayDescriptor))
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
                if (this.FieldworkIdentifier != null)
                    hashCode = hashCode * 59 + this.FieldworkIdentifier.GetHashCode();
                if (this.Schools != null)
                    hashCode = hashCode * 59 + this.Schools.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.Coteaching != null)
                    hashCode = hashCode * 59 + this.Coteaching.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.FieldworkTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.FieldworkTypeDescriptor.GetHashCode();
                if (this.HoursCompleted != null)
                    hashCode = hashCode * 59 + this.HoursCompleted.GetHashCode();
                if (this.ProgramGatewayDescriptor != null)
                    hashCode = hashCode * 59 + this.ProgramGatewayDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
