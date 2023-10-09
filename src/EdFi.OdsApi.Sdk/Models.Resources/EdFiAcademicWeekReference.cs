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
    /// EdFiAcademicWeekReference
    /// </summary>
    [DataContract]
    public partial class EdFiAcademicWeekReference :  IEquatable<EdFiAcademicWeekReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAcademicWeekReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAcademicWeekReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAcademicWeekReference" /> class.
        /// </summary>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="weekIdentifier">The school label for the week. (required).</param>
        /// <param name="link">link.</param>
        public EdFiAcademicWeekReference(int? schoolId = default(int?), string weekIdentifier = default(string), Link link = default(Link))
        {
            // to ensure "schoolId" is required (not null)
            if (schoolId == null)
            {
                throw new InvalidDataException("schoolId is a required property for EdFiAcademicWeekReference and cannot be null");
            }
            else
            {
                this.SchoolId = schoolId;
            }
            // to ensure "weekIdentifier" is required (not null)
            if (weekIdentifier == null)
            {
                throw new InvalidDataException("weekIdentifier is a required property for EdFiAcademicWeekReference and cannot be null");
            }
            else
            {
                this.WeekIdentifier = weekIdentifier;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name="schoolId", EmitDefaultValue=false)]
        public int? SchoolId { get; set; }

        /// <summary>
        /// The school label for the week.
        /// </summary>
        /// <value>The school label for the week.</value>
        [DataMember(Name="weekIdentifier", EmitDefaultValue=false)]
        public string WeekIdentifier { get; set; }

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
            sb.Append("class EdFiAcademicWeekReference {\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  WeekIdentifier: ").Append(WeekIdentifier).Append("\n");
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
            return this.Equals(input as EdFiAcademicWeekReference);
        }

        /// <summary>
        /// Returns true if EdFiAcademicWeekReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAcademicWeekReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAcademicWeekReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchoolId == input.SchoolId ||
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
                ) && 
                (
                    this.WeekIdentifier == input.WeekIdentifier ||
                    (this.WeekIdentifier != null &&
                    this.WeekIdentifier.Equals(input.WeekIdentifier))
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
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.WeekIdentifier != null)
                    hashCode = hashCode * 59 + this.WeekIdentifier.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
