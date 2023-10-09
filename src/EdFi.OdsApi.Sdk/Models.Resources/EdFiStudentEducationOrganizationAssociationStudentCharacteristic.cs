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
    /// EdFiStudentEducationOrganizationAssociationStudentCharacteristic
    /// </summary>
    [DataContract]
    public partial class EdFiStudentEducationOrganizationAssociationStudentCharacteristic :  IEquatable<EdFiStudentEducationOrganizationAssociationStudentCharacteristic>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentCharacteristic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationStudentCharacteristic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentCharacteristic" /> class.
        /// </summary>
        /// <param name="studentCharacteristicDescriptor">The characteristic designated for the Student. (required).</param>
        /// <param name="designatedBy">The person, organization, or department that designated the characteristic..</param>
        /// <param name="periods">An unordered collection of studentEducationOrganizationAssociationStudentCharacteristicPeriods. The time periods for which characteristic was effective..</param>
        /// <param name="ext">ext.</param>
        public EdFiStudentEducationOrganizationAssociationStudentCharacteristic(string studentCharacteristicDescriptor = default(string), string designatedBy = default(string), List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicPeriod> periods = default(List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicPeriod>), StudentEducationOrganizationAssociationStudentCharacteristicExtensions ext = default(StudentEducationOrganizationAssociationStudentCharacteristicExtensions))
        {
            // to ensure "studentCharacteristicDescriptor" is required (not null)
            if (studentCharacteristicDescriptor == null)
            {
                throw new InvalidDataException("studentCharacteristicDescriptor is a required property for EdFiStudentEducationOrganizationAssociationStudentCharacteristic and cannot be null");
            }
            else
            {
                this.StudentCharacteristicDescriptor = studentCharacteristicDescriptor;
            }
            this.DesignatedBy = designatedBy;
            this.Periods = periods;
            this.Ext = ext;
        }
        
        /// <summary>
        /// The characteristic designated for the Student.
        /// </summary>
        /// <value>The characteristic designated for the Student.</value>
        [DataMember(Name="studentCharacteristicDescriptor", EmitDefaultValue=false)]
        public string StudentCharacteristicDescriptor { get; set; }

        /// <summary>
        /// The person, organization, or department that designated the characteristic.
        /// </summary>
        /// <value>The person, organization, or department that designated the characteristic.</value>
        [DataMember(Name="designatedBy", EmitDefaultValue=false)]
        public string DesignatedBy { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentCharacteristicPeriods. The time periods for which characteristic was effective.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationStudentCharacteristicPeriods. The time periods for which characteristic was effective.</value>
        [DataMember(Name="periods", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicPeriod> Periods { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="_ext", EmitDefaultValue=false)]
        public StudentEducationOrganizationAssociationStudentCharacteristicExtensions Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationStudentCharacteristic {\n");
            sb.Append("  StudentCharacteristicDescriptor: ").Append(StudentCharacteristicDescriptor).Append("\n");
            sb.Append("  DesignatedBy: ").Append(DesignatedBy).Append("\n");
            sb.Append("  Periods: ").Append(Periods).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationStudentCharacteristic);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationStudentCharacteristic instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationStudentCharacteristic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationStudentCharacteristic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StudentCharacteristicDescriptor == input.StudentCharacteristicDescriptor ||
                    (this.StudentCharacteristicDescriptor != null &&
                    this.StudentCharacteristicDescriptor.Equals(input.StudentCharacteristicDescriptor))
                ) && 
                (
                    this.DesignatedBy == input.DesignatedBy ||
                    (this.DesignatedBy != null &&
                    this.DesignatedBy.Equals(input.DesignatedBy))
                ) && 
                (
                    this.Periods == input.Periods ||
                    this.Periods != null &&
                    this.Periods.SequenceEqual(input.Periods)
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
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
                if (this.StudentCharacteristicDescriptor != null)
                    hashCode = hashCode * 59 + this.StudentCharacteristicDescriptor.GetHashCode();
                if (this.DesignatedBy != null)
                    hashCode = hashCode * 59 + this.DesignatedBy.GetHashCode();
                if (this.Periods != null)
                    hashCode = hashCode * 59 + this.Periods.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
