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
    /// EdFiStaffDisciplineIncidentAssociation
    /// </summary>
    [DataContract(Name = "edFi_staffDisciplineIncidentAssociation")]
    public partial class EdFiStaffDisciplineIncidentAssociation : IEquatable<EdFiStaffDisciplineIncidentAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffDisciplineIncidentAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffDisciplineIncidentAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffDisciplineIncidentAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="disciplineIncidentParticipationCodes">An unordered collection of staffDisciplineIncidentAssociationDisciplineIncidentParticipationCodes. The role or type of participation of a student in a discipline incident. (required).</param>
        /// <param name="disciplineIncidentReference">disciplineIncidentReference (required).</param>
        /// <param name="staffReference">staffReference (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiStaffDisciplineIncidentAssociation(string id = default(string), List<EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode> disciplineIncidentParticipationCodes = default(List<EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode>), EdFiDisciplineIncidentReference disciplineIncidentReference = default(EdFiDisciplineIncidentReference), EdFiStaffReference staffReference = default(EdFiStaffReference), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "disciplineIncidentParticipationCodes" is required (not null)
            if (disciplineIncidentParticipationCodes == null)
            {
                throw new ArgumentNullException("disciplineIncidentParticipationCodes is a required property for EdFiStaffDisciplineIncidentAssociation and cannot be null");
            }
            this.DisciplineIncidentParticipationCodes = disciplineIncidentParticipationCodes;
            // to ensure "disciplineIncidentReference" is required (not null)
            if (disciplineIncidentReference == null)
            {
                throw new ArgumentNullException("disciplineIncidentReference is a required property for EdFiStaffDisciplineIncidentAssociation and cannot be null");
            }
            this.DisciplineIncidentReference = disciplineIncidentReference;
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new ArgumentNullException("staffReference is a required property for EdFiStaffDisciplineIncidentAssociation and cannot be null");
            }
            this.StaffReference = staffReference;
            this.Id = id;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An unordered collection of staffDisciplineIncidentAssociationDisciplineIncidentParticipationCodes. The role or type of participation of a student in a discipline incident.
        /// </summary>
        /// <value>An unordered collection of staffDisciplineIncidentAssociationDisciplineIncidentParticipationCodes. The role or type of participation of a student in a discipline incident.</value>
        [DataMember(Name = "disciplineIncidentParticipationCodes", IsRequired = true, EmitDefaultValue = true)]
        public List<EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode> DisciplineIncidentParticipationCodes { get; set; }

        /// <summary>
        /// Gets or Sets DisciplineIncidentReference
        /// </summary>
        [DataMember(Name = "disciplineIncidentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiDisciplineIncidentReference DisciplineIncidentReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name = "staffReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStaffReference StaffReference { get; set; }

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
            sb.Append("class EdFiStaffDisciplineIncidentAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisciplineIncidentParticipationCodes: ").Append(DisciplineIncidentParticipationCodes).Append("\n");
            sb.Append("  DisciplineIncidentReference: ").Append(DisciplineIncidentReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
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
            return this.Equals(input as EdFiStaffDisciplineIncidentAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStaffDisciplineIncidentAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffDisciplineIncidentAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffDisciplineIncidentAssociation input)
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
                    this.DisciplineIncidentParticipationCodes == input.DisciplineIncidentParticipationCodes ||
                    this.DisciplineIncidentParticipationCodes != null &&
                    input.DisciplineIncidentParticipationCodes != null &&
                    this.DisciplineIncidentParticipationCodes.SequenceEqual(input.DisciplineIncidentParticipationCodes)
                ) && 
                (
                    this.DisciplineIncidentReference == input.DisciplineIncidentReference ||
                    (this.DisciplineIncidentReference != null &&
                    this.DisciplineIncidentReference.Equals(input.DisciplineIncidentReference))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
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
                if (this.DisciplineIncidentParticipationCodes != null)
                {
                    hashCode = (hashCode * 59) + this.DisciplineIncidentParticipationCodes.GetHashCode();
                }
                if (this.DisciplineIncidentReference != null)
                {
                    hashCode = (hashCode * 59) + this.DisciplineIncidentReference.GetHashCode();
                }
                if (this.StaffReference != null)
                {
                    hashCode = (hashCode * 59) + this.StaffReference.GetHashCode();
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
            yield break;
        }
    }

}
