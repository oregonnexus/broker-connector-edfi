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
    /// EdFiLocalEducationAgencyAccountability
    /// </summary>
    [DataContract]
    public partial class EdFiLocalEducationAgencyAccountability :  IEquatable<EdFiLocalEducationAgencyAccountability>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalEducationAgencyAccountability" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLocalEducationAgencyAccountability() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalEducationAgencyAccountability" /> class.
        /// </summary>
        /// <param name="gunFreeSchoolsActReportingStatusDescriptor">An indication of whether the school or Local Education Agency (LEA) submitted a Gun-Free Schools Act (GFSA) of 1994 report to the state, as defined by Title 18, Section 921..</param>
        /// <param name="schoolChoiceImplementStatusDescriptor">An indication of whether the LEA was able to implement the provisions for public school choice under Title I, Part A, Section 1116 of ESEA as amended..</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference (required).</param>
        public EdFiLocalEducationAgencyAccountability(string gunFreeSchoolsActReportingStatusDescriptor = default(string), string schoolChoiceImplementStatusDescriptor = default(string), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference))
        {
            // to ensure "schoolYearTypeReference" is required (not null)
            if (schoolYearTypeReference == null)
            {
                throw new InvalidDataException("schoolYearTypeReference is a required property for EdFiLocalEducationAgencyAccountability and cannot be null");
            }
            else
            {
                this.SchoolYearTypeReference = schoolYearTypeReference;
            }
            this.GunFreeSchoolsActReportingStatusDescriptor = gunFreeSchoolsActReportingStatusDescriptor;
            this.SchoolChoiceImplementStatusDescriptor = schoolChoiceImplementStatusDescriptor;
        }
        
        /// <summary>
        /// An indication of whether the school or Local Education Agency (LEA) submitted a Gun-Free Schools Act (GFSA) of 1994 report to the state, as defined by Title 18, Section 921.
        /// </summary>
        /// <value>An indication of whether the school or Local Education Agency (LEA) submitted a Gun-Free Schools Act (GFSA) of 1994 report to the state, as defined by Title 18, Section 921.</value>
        [DataMember(Name="gunFreeSchoolsActReportingStatusDescriptor", EmitDefaultValue=false)]
        public string GunFreeSchoolsActReportingStatusDescriptor { get; set; }

        /// <summary>
        /// An indication of whether the LEA was able to implement the provisions for public school choice under Title I, Part A, Section 1116 of ESEA as amended.
        /// </summary>
        /// <value>An indication of whether the LEA was able to implement the provisions for public school choice under Title I, Part A, Section 1116 of ESEA as amended.</value>
        [DataMember(Name="schoolChoiceImplementStatusDescriptor", EmitDefaultValue=false)]
        public string SchoolChoiceImplementStatusDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name="schoolYearTypeReference", EmitDefaultValue=false)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiLocalEducationAgencyAccountability {\n");
            sb.Append("  GunFreeSchoolsActReportingStatusDescriptor: ").Append(GunFreeSchoolsActReportingStatusDescriptor).Append("\n");
            sb.Append("  SchoolChoiceImplementStatusDescriptor: ").Append(SchoolChoiceImplementStatusDescriptor).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
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
            return this.Equals(input as EdFiLocalEducationAgencyAccountability);
        }

        /// <summary>
        /// Returns true if EdFiLocalEducationAgencyAccountability instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLocalEducationAgencyAccountability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLocalEducationAgencyAccountability input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GunFreeSchoolsActReportingStatusDescriptor == input.GunFreeSchoolsActReportingStatusDescriptor ||
                    (this.GunFreeSchoolsActReportingStatusDescriptor != null &&
                    this.GunFreeSchoolsActReportingStatusDescriptor.Equals(input.GunFreeSchoolsActReportingStatusDescriptor))
                ) && 
                (
                    this.SchoolChoiceImplementStatusDescriptor == input.SchoolChoiceImplementStatusDescriptor ||
                    (this.SchoolChoiceImplementStatusDescriptor != null &&
                    this.SchoolChoiceImplementStatusDescriptor.Equals(input.SchoolChoiceImplementStatusDescriptor))
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
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
                if (this.GunFreeSchoolsActReportingStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.GunFreeSchoolsActReportingStatusDescriptor.GetHashCode();
                if (this.SchoolChoiceImplementStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.SchoolChoiceImplementStatusDescriptor.GetHashCode();
                if (this.SchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.SchoolYearTypeReference.GetHashCode();
                return hashCode;
            }
        }
    }

}
