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
    /// SampleStudentExtension
    /// </summary>
    [DataContract(Name = "sample_studentExtension")]
    public partial class SampleStudentExtension : IEquatable<SampleStudentExtension>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentExtension" /> class.
        /// </summary>
        /// <param name="aquaticPets">An unordered collection of studentAquaticPets. Details about aquatic pets in the student&#39;s household.</param>
        /// <param name="favoriteBooks">An unordered collection of studentFavoriteBooks. This is documentation..</param>
        /// <param name="pets">An unordered collection of studentPets. Details about pets in the student&#39;s household..</param>
        /// <param name="petPreference">petPreference.</param>
        public SampleStudentExtension(List<SampleStudentAquaticPet> aquaticPets = default(List<SampleStudentAquaticPet>), List<SampleStudentFavoriteBook> favoriteBooks = default(List<SampleStudentFavoriteBook>), List<SampleStudentPet> pets = default(List<SampleStudentPet>), SampleStudentPetPreference petPreference = default(SampleStudentPetPreference))
        {
            this.AquaticPets = aquaticPets;
            this.FavoriteBooks = favoriteBooks;
            this.Pets = pets;
            this.PetPreference = petPreference;
        }

        /// <summary>
        /// An unordered collection of studentAquaticPets. Details about aquatic pets in the student&#39;s household
        /// </summary>
        /// <value>An unordered collection of studentAquaticPets. Details about aquatic pets in the student&#39;s household</value>
        [DataMember(Name = "aquaticPets", EmitDefaultValue = false)]
        public List<SampleStudentAquaticPet> AquaticPets { get; set; }

        /// <summary>
        /// An unordered collection of studentFavoriteBooks. This is documentation.
        /// </summary>
        /// <value>An unordered collection of studentFavoriteBooks. This is documentation.</value>
        [DataMember(Name = "favoriteBooks", EmitDefaultValue = false)]
        public List<SampleStudentFavoriteBook> FavoriteBooks { get; set; }

        /// <summary>
        /// An unordered collection of studentPets. Details about pets in the student&#39;s household.
        /// </summary>
        /// <value>An unordered collection of studentPets. Details about pets in the student&#39;s household.</value>
        [DataMember(Name = "pets", EmitDefaultValue = false)]
        public List<SampleStudentPet> Pets { get; set; }

        /// <summary>
        /// Gets or Sets PetPreference
        /// </summary>
        [DataMember(Name = "petPreference", EmitDefaultValue = false)]
        public SampleStudentPetPreference PetPreference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SampleStudentExtension {\n");
            sb.Append("  AquaticPets: ").Append(AquaticPets).Append("\n");
            sb.Append("  FavoriteBooks: ").Append(FavoriteBooks).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SampleStudentExtension);
        }

        /// <summary>
        /// Returns true if SampleStudentExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentExtension input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AquaticPets == input.AquaticPets ||
                    this.AquaticPets != null &&
                    input.AquaticPets != null &&
                    this.AquaticPets.SequenceEqual(input.AquaticPets)
                ) && 
                (
                    this.FavoriteBooks == input.FavoriteBooks ||
                    this.FavoriteBooks != null &&
                    input.FavoriteBooks != null &&
                    this.FavoriteBooks.SequenceEqual(input.FavoriteBooks)
                ) && 
                (
                    this.Pets == input.Pets ||
                    this.Pets != null &&
                    input.Pets != null &&
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
                if (this.AquaticPets != null)
                {
                    hashCode = (hashCode * 59) + this.AquaticPets.GetHashCode();
                }
                if (this.FavoriteBooks != null)
                {
                    hashCode = (hashCode * 59) + this.FavoriteBooks.GetHashCode();
                }
                if (this.Pets != null)
                {
                    hashCode = (hashCode * 59) + this.Pets.GetHashCode();
                }
                if (this.PetPreference != null)
                {
                    hashCode = (hashCode * 59) + this.PetPreference.GetHashCode();
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
