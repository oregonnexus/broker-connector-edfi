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
    /// TpdmTeacherCandidateDegreeSpecialization
    /// </summary>
    [DataContract]
    public partial class TpdmTeacherCandidateDegreeSpecialization :  IEquatable<TpdmTeacherCandidateDegreeSpecialization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmTeacherCandidateDegreeSpecialization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmTeacherCandidateDegreeSpecialization() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmTeacherCandidateDegreeSpecialization" /> class.
        /// </summary>
        /// <param name="beginDate">The month, day, and year on which the Teacher Candidate first declared specialization. (required).</param>
        /// <param name="majorSpecialization">The major area for a degree or area of specialization for a certificate. (required).</param>
        /// <param name="endDate">The month, day, and year on which the Teacher Candidate exited the declared specialization..</param>
        /// <param name="minorSpecialization">The major area for a degree or area of specialization for a certificate..</param>
        public TpdmTeacherCandidateDegreeSpecialization(DateTime? beginDate = default(DateTime?), string majorSpecialization = default(string), DateTime? endDate = default(DateTime?), string minorSpecialization = default(string))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for TpdmTeacherCandidateDegreeSpecialization and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "majorSpecialization" is required (not null)
            if (majorSpecialization == null)
            {
                throw new InvalidDataException("majorSpecialization is a required property for TpdmTeacherCandidateDegreeSpecialization and cannot be null");
            }
            else
            {
                this.MajorSpecialization = majorSpecialization;
            }
            this.EndDate = endDate;
            this.MinorSpecialization = minorSpecialization;
        }
        
        /// <summary>
        /// The month, day, and year on which the Teacher Candidate first declared specialization.
        /// </summary>
        /// <value>The month, day, and year on which the Teacher Candidate first declared specialization.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The major area for a degree or area of specialization for a certificate.
        /// </summary>
        /// <value>The major area for a degree or area of specialization for a certificate.</value>
        [DataMember(Name="majorSpecialization", EmitDefaultValue=false)]
        public string MajorSpecialization { get; set; }

        /// <summary>
        /// The month, day, and year on which the Teacher Candidate exited the declared specialization.
        /// </summary>
        /// <value>The month, day, and year on which the Teacher Candidate exited the declared specialization.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The major area for a degree or area of specialization for a certificate.
        /// </summary>
        /// <value>The major area for a degree or area of specialization for a certificate.</value>
        [DataMember(Name="minorSpecialization", EmitDefaultValue=false)]
        public string MinorSpecialization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmTeacherCandidateDegreeSpecialization {\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  MajorSpecialization: ").Append(MajorSpecialization).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  MinorSpecialization: ").Append(MinorSpecialization).Append("\n");
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
            return this.Equals(input as TpdmTeacherCandidateDegreeSpecialization);
        }

        /// <summary>
        /// Returns true if TpdmTeacherCandidateDegreeSpecialization instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmTeacherCandidateDegreeSpecialization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmTeacherCandidateDegreeSpecialization input)
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
                    this.MajorSpecialization == input.MajorSpecialization ||
                    (this.MajorSpecialization != null &&
                    this.MajorSpecialization.Equals(input.MajorSpecialization))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.MinorSpecialization == input.MinorSpecialization ||
                    (this.MinorSpecialization != null &&
                    this.MinorSpecialization.Equals(input.MinorSpecialization))
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
                if (this.MajorSpecialization != null)
                    hashCode = hashCode * 59 + this.MajorSpecialization.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.MinorSpecialization != null)
                    hashCode = hashCode * 59 + this.MinorSpecialization.GetHashCode();
                return hashCode;
            }
        }
    }

}
