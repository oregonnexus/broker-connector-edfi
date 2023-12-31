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
    /// SampleStaffExtension
    /// </summary>
    [DataContract]
    public partial class SampleStaffExtension :  IEquatable<SampleStaffExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStaffExtension" /> class.
        /// </summary>
        /// <param name="firstPetOwnedDate">The date the staff member adopted the first household pet..</param>
        /// <param name="pets">An unordered collection of staffPets. Details about pets in the staff member&#39;s household..</param>
        /// <param name="petPreference">petPreference.</param>
        public SampleStaffExtension(DateTime? firstPetOwnedDate = default(DateTime?), List<SampleStaffPet> pets = default(List<SampleStaffPet>), SampleStaffPetPreference petPreference = default(SampleStaffPetPreference))
        {
            this.FirstPetOwnedDate = firstPetOwnedDate;
            this.Pets = pets;
            this.PetPreference = petPreference;
        }
        
        /// <summary>
        /// The date the staff member adopted the first household pet.
        /// </summary>
        /// <value>The date the staff member adopted the first household pet.</value>
        [DataMember(Name="firstPetOwnedDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FirstPetOwnedDate { get; set; }

        /// <summary>
        /// An unordered collection of staffPets. Details about pets in the staff member&#39;s household.
        /// </summary>
        /// <value>An unordered collection of staffPets. Details about pets in the staff member&#39;s household.</value>
        [DataMember(Name="pets", EmitDefaultValue=false)]
        public List<SampleStaffPet> Pets { get; set; }

        /// <summary>
        /// Gets or Sets PetPreference
        /// </summary>
        [DataMember(Name="petPreference", EmitDefaultValue=false)]
        public SampleStaffPetPreference PetPreference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleStaffExtension {\n");
            sb.Append("  FirstPetOwnedDate: ").Append(FirstPetOwnedDate).Append("\n");
            sb.Append("  Pets: ").Append(Pets).Append("\n");
            sb.Append("  PetPreference: ").Append(PetPreference).Append("\n");
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
            return this.Equals(input as SampleStaffExtension);
        }

        /// <summary>
        /// Returns true if SampleStaffExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStaffExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStaffExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstPetOwnedDate == input.FirstPetOwnedDate ||
                    (this.FirstPetOwnedDate != null &&
                    this.FirstPetOwnedDate.Equals(input.FirstPetOwnedDate))
                ) && 
                (
                    this.Pets == input.Pets ||
                    this.Pets != null &&
                    this.Pets.SequenceEqual(input.Pets)
                ) && 
                (
                    this.PetPreference == input.PetPreference ||
                    (this.PetPreference != null &&
                    this.PetPreference.Equals(input.PetPreference))
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
                if (this.FirstPetOwnedDate != null)
                    hashCode = hashCode * 59 + this.FirstPetOwnedDate.GetHashCode();
                if (this.Pets != null)
                    hashCode = hashCode * 59 + this.Pets.GetHashCode();
                if (this.PetPreference != null)
                    hashCode = hashCode * 59 + this.PetPreference.GetHashCode();
                return hashCode;
            }
        }
    }

}
