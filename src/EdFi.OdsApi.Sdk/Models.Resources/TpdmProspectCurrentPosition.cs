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
    /// TpdmProspectCurrentPosition
    /// </summary>
    [DataContract]
    public partial class TpdmProspectCurrentPosition :  IEquatable<TpdmProspectCurrentPosition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmProspectCurrentPosition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmProspectCurrentPosition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmProspectCurrentPosition" /> class.
        /// </summary>
        /// <param name="academicSubjectDescriptor">The academic subject the staff person&#39;s assignment to a school..</param>
        /// <param name="location">The location, typically City and State, for the institution. (required).</param>
        /// <param name="nameOfInstitution">The formal name of the education organization. (required).</param>
        /// <param name="positionTitle">The descriptive name of an individual&#39;s position. (required).</param>
        /// <param name="gradeLevels">An unordered collection of prospectCurrentPositionGradeLevels. The set of grade levels for which the individual&#39;s assignment is responsible..</param>
        public TpdmProspectCurrentPosition(string academicSubjectDescriptor = default(string), string location = default(string), string nameOfInstitution = default(string), string positionTitle = default(string), List<TpdmProspectCurrentPositionGradeLevel> gradeLevels = default(List<TpdmProspectCurrentPositionGradeLevel>))
        {
            // to ensure "location" is required (not null)
            if (location == null)
            {
                throw new InvalidDataException("location is a required property for TpdmProspectCurrentPosition and cannot be null");
            }
            else
            {
                this.Location = location;
            }
            // to ensure "nameOfInstitution" is required (not null)
            if (nameOfInstitution == null)
            {
                throw new InvalidDataException("nameOfInstitution is a required property for TpdmProspectCurrentPosition and cannot be null");
            }
            else
            {
                this.NameOfInstitution = nameOfInstitution;
            }
            // to ensure "positionTitle" is required (not null)
            if (positionTitle == null)
            {
                throw new InvalidDataException("positionTitle is a required property for TpdmProspectCurrentPosition and cannot be null");
            }
            else
            {
                this.PositionTitle = positionTitle;
            }
            this.AcademicSubjectDescriptor = academicSubjectDescriptor;
            this.GradeLevels = gradeLevels;
        }
        
        /// <summary>
        /// The academic subject the staff person&#39;s assignment to a school.
        /// </summary>
        /// <value>The academic subject the staff person&#39;s assignment to a school.</value>
        [DataMember(Name="academicSubjectDescriptor", EmitDefaultValue=false)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// The location, typically City and State, for the institution.
        /// </summary>
        /// <value>The location, typically City and State, for the institution.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// The formal name of the education organization.
        /// </summary>
        /// <value>The formal name of the education organization.</value>
        [DataMember(Name="nameOfInstitution", EmitDefaultValue=false)]
        public string NameOfInstitution { get; set; }

        /// <summary>
        /// The descriptive name of an individual&#39;s position.
        /// </summary>
        /// <value>The descriptive name of an individual&#39;s position.</value>
        [DataMember(Name="positionTitle", EmitDefaultValue=false)]
        public string PositionTitle { get; set; }

        /// <summary>
        /// An unordered collection of prospectCurrentPositionGradeLevels. The set of grade levels for which the individual&#39;s assignment is responsible.
        /// </summary>
        /// <value>An unordered collection of prospectCurrentPositionGradeLevels. The set of grade levels for which the individual&#39;s assignment is responsible.</value>
        [DataMember(Name="gradeLevels", EmitDefaultValue=false)]
        public List<TpdmProspectCurrentPositionGradeLevel> GradeLevels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmProspectCurrentPosition {\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  NameOfInstitution: ").Append(NameOfInstitution).Append("\n");
            sb.Append("  PositionTitle: ").Append(PositionTitle).Append("\n");
            sb.Append("  GradeLevels: ").Append(GradeLevels).Append("\n");
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
            return this.Equals(input as TpdmProspectCurrentPosition);
        }

        /// <summary>
        /// Returns true if TpdmProspectCurrentPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmProspectCurrentPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmProspectCurrentPosition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.NameOfInstitution == input.NameOfInstitution ||
                    (this.NameOfInstitution != null &&
                    this.NameOfInstitution.Equals(input.NameOfInstitution))
                ) && 
                (
                    this.PositionTitle == input.PositionTitle ||
                    (this.PositionTitle != null &&
                    this.PositionTitle.Equals(input.PositionTitle))
                ) && 
                (
                    this.GradeLevels == input.GradeLevels ||
                    this.GradeLevels != null &&
                    this.GradeLevels.SequenceEqual(input.GradeLevels)
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
                if (this.AcademicSubjectDescriptor != null)
                    hashCode = hashCode * 59 + this.AcademicSubjectDescriptor.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.NameOfInstitution != null)
                    hashCode = hashCode * 59 + this.NameOfInstitution.GetHashCode();
                if (this.PositionTitle != null)
                    hashCode = hashCode * 59 + this.PositionTitle.GetHashCode();
                if (this.GradeLevels != null)
                    hashCode = hashCode * 59 + this.GradeLevels.GetHashCode();
                return hashCode;
            }
        }
    }

}
