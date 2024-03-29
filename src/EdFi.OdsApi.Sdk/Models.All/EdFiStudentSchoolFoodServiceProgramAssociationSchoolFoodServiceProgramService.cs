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
    /// EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService
    /// </summary>
    [DataContract(Name = "edFi_studentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService")]
    public partial class EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService : IEquatable<EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService" /> class.
        /// </summary>
        /// <param name="schoolFoodServiceProgramServiceDescriptor">Indicates the service being provided to the student by the school food service program. (required).</param>
        /// <param name="primaryIndicator">True if service is a primary service..</param>
        /// <param name="serviceBeginDate">First date the student was in this option for the current school year..</param>
        /// <param name="serviceEndDate">Last date the student was in this option for the current school year..</param>
        public EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService(string schoolFoodServiceProgramServiceDescriptor = default(string), bool? primaryIndicator = default(bool?), DateTime? serviceBeginDate = default(DateTime?), DateTime? serviceEndDate = default(DateTime?))
        {
            // to ensure "schoolFoodServiceProgramServiceDescriptor" is required (not null)
            if (schoolFoodServiceProgramServiceDescriptor == null)
            {
                throw new ArgumentNullException("schoolFoodServiceProgramServiceDescriptor is a required property for EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService and cannot be null");
            }
            this.SchoolFoodServiceProgramServiceDescriptor = schoolFoodServiceProgramServiceDescriptor;
            this.PrimaryIndicator = primaryIndicator;
            this.ServiceBeginDate = serviceBeginDate;
            this.ServiceEndDate = serviceEndDate;
        }

        /// <summary>
        /// Indicates the service being provided to the student by the school food service program.
        /// </summary>
        /// <value>Indicates the service being provided to the student by the school food service program.</value>
        [DataMember(Name = "schoolFoodServiceProgramServiceDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string SchoolFoodServiceProgramServiceDescriptor { get; set; }

        /// <summary>
        /// True if service is a primary service.
        /// </summary>
        /// <value>True if service is a primary service.</value>
        [DataMember(Name = "primaryIndicator", EmitDefaultValue = true)]
        public bool? PrimaryIndicator { get; set; }

        /// <summary>
        /// First date the student was in this option for the current school year.
        /// </summary>
        /// <value>First date the student was in this option for the current school year.</value>
        [DataMember(Name = "serviceBeginDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ServiceBeginDate { get; set; }

        /// <summary>
        /// Last date the student was in this option for the current school year.
        /// </summary>
        /// <value>Last date the student was in this option for the current school year.</value>
        [DataMember(Name = "serviceEndDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ServiceEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService {\n");
            sb.Append("  SchoolFoodServiceProgramServiceDescriptor: ").Append(SchoolFoodServiceProgramServiceDescriptor).Append("\n");
            sb.Append("  PrimaryIndicator: ").Append(PrimaryIndicator).Append("\n");
            sb.Append("  ServiceBeginDate: ").Append(ServiceBeginDate).Append("\n");
            sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
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
            return this.Equals(input as EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService);
        }

        /// <summary>
        /// Returns true if EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SchoolFoodServiceProgramServiceDescriptor == input.SchoolFoodServiceProgramServiceDescriptor ||
                    (this.SchoolFoodServiceProgramServiceDescriptor != null &&
                    this.SchoolFoodServiceProgramServiceDescriptor.Equals(input.SchoolFoodServiceProgramServiceDescriptor))
                ) && 
                (
                    this.PrimaryIndicator == input.PrimaryIndicator ||
                    (this.PrimaryIndicator != null &&
                    this.PrimaryIndicator.Equals(input.PrimaryIndicator))
                ) && 
                (
                    this.ServiceBeginDate == input.ServiceBeginDate ||
                    (this.ServiceBeginDate != null &&
                    this.ServiceBeginDate.Equals(input.ServiceBeginDate))
                ) && 
                (
                    this.ServiceEndDate == input.ServiceEndDate ||
                    (this.ServiceEndDate != null &&
                    this.ServiceEndDate.Equals(input.ServiceEndDate))
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
                if (this.SchoolFoodServiceProgramServiceDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolFoodServiceProgramServiceDescriptor.GetHashCode();
                }
                if (this.PrimaryIndicator != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryIndicator.GetHashCode();
                }
                if (this.ServiceBeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceBeginDate.GetHashCode();
                }
                if (this.ServiceEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceEndDate.GetHashCode();
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
            // SchoolFoodServiceProgramServiceDescriptor (string) maxLength
            if (this.SchoolFoodServiceProgramServiceDescriptor != null && this.SchoolFoodServiceProgramServiceDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SchoolFoodServiceProgramServiceDescriptor, length must be less than 306.", new [] { "SchoolFoodServiceProgramServiceDescriptor" });
            }

            yield break;
        }
    }

}
